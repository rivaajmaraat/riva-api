using Hayden.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hayden.Services.ResponseModel;
using Hayden.Services.RequestModel;
using Microsoft.EntityFrameworkCore;

namespace Hayden.Services
{
    public class LoginService
    {
        #region Constructor
        public LoginService()
        {

        }

        #endregion

        #region CRUD
        /// <summary>
        /// Checks if the login creadentials are correct
        /// </summary>
        /// <param name="request">The login credentials sent by the client for verification</param>
        /// <returns></returns>
        public static async Task<Response<AuthResponse>> Login(LoginRequest request)
        {
            using (HAYDENContext context = new HAYDENContext())
            {
                try
                {
                    SqlParameter result = new SqlParameter("@Authenticated", System.Data.SqlDbType.Bit);
                    result.Direction = System.Data.ParameterDirection.Output;
                    object[] sprocParams = {
                    new SqlParameter("@UserName", request.UserName),
                    new SqlParameter("@Password", request.Password),
                    result };
                    var test = await context.Database.ExecuteSqlRawAsync(
                        "EXEC [spAuthLogin] @UserName, @Password, @Authenticated OUTPUT"
                        , parameters: sprocParams);

                    if (result.Value is bool value)
                    {
                        if ((bool)result.Value)
                        {
                            var login = await context.Login.FirstOrDefaultAsync(l => l.UserName == request.UserName);
                            login.LastLogin = DateTime.UtcNow;
                            await context.SaveChangesAsync();
                            AuthResponse response =
                                new AuthResponse
                                {
                                    UserName = login.UserName,
                                    Token = "",
                                    LastLogin = login.LastLogin
                                };
                            return Response<AuthResponse>.Success(response);
                        }
                        return Response<AuthResponse>.Error("Credentials did not match.");
                    }

                    return Response<AuthResponse>.Error("Error logging in credentials.");

                }
                catch (Exception ex)
                {
                    return Response<AuthResponse>.Error(ex.Message);
                }
            }
        }

        /// <summary>
        /// Gets the list of existing login details with encrypted passwords
        /// </summary>
        /// <returns></returns>
        public static async Task<Response<List<Login>>> LoginList() 
        {
            using (HAYDENContext context = new HAYDENContext())
            {
                try
                {
                    List<Login> logins = await context.Login.OrderBy(l => l.LoginId).ToListAsync();
                    return Response<List<Login>>.Success(logins);

                }
                catch (Exception ex)
                {
                    return Response<List<Login>>.Error(ex);
                }
            }
        }

        /// <summary>
        /// Creates new login data.
        /// </summary>
        /// <param name="data">Login data</param>
        /// <returns><see cref="ResponseMessage"/></returns>
        public static async Task<Response> CreateUser(LoginRequest data)
        {
            using (HAYDENContext context = new HAYDENContext())
            {
                using var transaction = context.Database.BeginTransaction();
                try
                {
                    var existLogin = await context.Login.FirstOrDefaultAsync(l => l.UserName == data.UserName);
                    if (existLogin != null)
                        return Response.Error("Login already exists.");
                    object[] sprocParams = {
                    new SqlParameter("@UserName", data.UserName),
                    new SqlParameter("@Password", data.Password),
                    new SqlParameter("@DateCreated", DateTime.UtcNow),
                    new SqlParameter("@LastLogin", DateTime.UtcNow),
                    new SqlParameter("@status", 1)
                };
                    await context.Database.ExecuteSqlRawAsync(
                        "EXEC [spInsertLogin] @UserName, @Password, @DateCreated, @LastLogin, @status",
                        parameters: sprocParams);
                    await transaction.CommitAsync();
                    return Response.Success();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    return Response.Error(ex);
                }
            }
        }

        public static async Task<Response> UpdateLoginDetails(LoginRequest login)
        {
            using (HAYDENContext context = new HAYDENContext())
            {
                using var transaction = context.Database.BeginTransaction();
                try
                {
                    var existLogin = await context.Login.FirstOrDefaultAsync(l => l.LoginId == login.LoginId);
                    if (existLogin == null)
                        return Response.Error("Data not found.");

                    if (string.IsNullOrEmpty(login.UserName) || string.IsNullOrWhiteSpace(login.UserName))
                    {
                        object[] sprocParams = {
                        new SqlParameter("@LoginID", existLogin.LoginId),
                        new SqlParameter("@Password", login.Password)
                    };
                        await context.Database.ExecuteSqlRawAsync(
                            "EXEC [spUpdateLoginPassword] @LoginID, @Password",
                            parameters: sprocParams);
                        await transaction.CommitAsync();
                    }
                    else if (string.IsNullOrEmpty(login.Password) || string.IsNullOrWhiteSpace(login.Password))
                    {
                        existLogin.UserName = login.UserName;
                        await context.SaveChangesAsync();
                        await transaction.CommitAsync();
                    }
                    else
                    {
                        await transaction.RollbackAsync();
                        return Response.Error("Username and Password are required.");
                    }
                    return Response.Success();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    return Response.Error(ex);
                }
            }
        }

        public static async Task<Response> DeleteLogin(int id)
        {
            using (HAYDENContext context = new HAYDENContext())
            {
                using var transaction = context.Database.BeginTransaction();
                try
                {
                    Login existLogin = await context.Login
                        .FirstOrDefaultAsync(l => l.LoginId == id);
                    if (existLogin == null)
                    {
                        await transaction.RollbackAsync();
                        return Response.Error("Data not found.");
                    }
                    context.Login.Remove(existLogin);
                    await context.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return Response.Success();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    return Response<Login>.Error(ex);
                }
            }
        }
        #endregion
    }
}

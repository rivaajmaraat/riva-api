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

        public static IQueryable<Login> Get(HAYDENContext context, int loginID)
        {
            if (context == null) context = new HAYDENContext();

            var item = (from i in context.Login
                        select i);

            if (loginID > 0)
            {
                item = item.Where(i => i.LoginId == loginID);
            }

            return item;
        }


        public static List<Login> GetAll(HAYDENContext context)
        {
            return Get(context, 0).ToList();
        }

        public static Login GetById(HAYDENContext context, int loginID)
        {
            return Get(context, loginID).FirstOrDefault();
        }

        public static async Task<Response<AuthResponse>> Login(LoginRequest request) 
        {
            try
            {
                using (HAYDENContext context = new HAYDENContext()) 
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
            }
            catch (Exception ex) 
            {
                return Response<AuthResponse>.Error(ex.Message);
            }
        }

        #endregion

        #region Helpers

        // TODO : Apply SP calls
        //public static Login GetLogin(string username, string password)
        //{
        //    var context = new HAYDENContext();

        //    var param = new SqlParameter("@FirstName", "Bill");
        //    //or
        //    /*var param = new SqlParameter() {
        //                        ParameterName = "@FirstName",
        //                        SqlDbType =  System.Data.SqlDbType.VarChar,
        //                        Direction = System.Data.ParameterDirection.Input,
        //                        Size = 50,
        //                        Value = "Bill"
        //    };*/

        //    var students = context.Login.FromSql("GetStudents @FirstName", param).ToList();
        //}

        #endregion

    }
}

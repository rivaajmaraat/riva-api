using Riva.Api.Models.Responses;
using Riva.Models.HAYDEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Features;

namespace Riva.Api.Services
{
    public class AuthService
    {
        private readonly HAYDENContext _haydenContext;

        public AuthService(HAYDENContext haydenContext)
        {
            _haydenContext = haydenContext;
        }

        public async Task<Response<AuthResponse>> Login(Login data)
        {
            try
            {
                var login = await _haydenContext.Login.FirstOrDefaultAsync(l => l.UserName == data.UserName && l.Password == data.Password);
                if (login != null)
                {
                    login.LastLogin = DateTime.UtcNow;
                    await _haydenContext.Login.AddAsync(login);
                    await _haydenContext.SaveChangesAsync();
                    var response = new AuthResponse() 
                    {
                        UserName = login.UserName,
                        Token = "",
                        Last_Login = login.LastLogin
                    };
                    return Response<AuthResponse>.Success(response);
                }
                return Response<AuthResponse>.Error("User not found!");

            }
            catch (Exception ex)
            {
                return Response<AuthResponse>.Error(ex.Message);
            }
        }

        /// <summary>
        /// Creates new login data.
        /// </summary>
        /// <param name="data">Login data</param>
        /// <returns><see cref="ResponseMessage"/></returns>
        public async Task<Response> CreateUser(Login data)
        {
            using var transaction = _haydenContext.Database.BeginTransaction();
            try
            {
                var existLogin = await _haydenContext.Login.FirstOrDefaultAsync(l => l.UserName == data.UserName);
                if (existLogin != null)
                    return Response.Error("Login already exists.");
                data.DateCreated = DateTime.UtcNow;
                data.LastLogin = data.DateCreated;
                await _haydenContext.Login.AddAsync(data);
                await _haydenContext.SaveChangesAsync();
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
}

using Riva.Api.Models.Responses;
using Riva.Models.HAYDEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Features;
using Riva.Api.Models.Requests;
using System.Text;

namespace Riva.Api.Services
{
    public class AuthService
    {
        private readonly HAYDENContext _haydenContext;

        public AuthService(HAYDENContext haydenContext)
        {
            _haydenContext = haydenContext;
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="data">Login data from user request</param>
        /// <returns></returns>
        public async Task<Response<AuthResponse>> Login(LoginRequest data)
        {
            try
            {
                var pass = Encoding.ASCII.GetBytes(data.Password);
                var login = await _haydenContext.Login
                    .FirstOrDefaultAsync(l => l.UserName == data.UserName && l.Password == Encoding.ASCII.GetBytes(data.Password));
                if (login != null)
                {
                    login.LastLogin = DateTime.UtcNow;
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
        public async Task<Response> CreateUser(LoginRequest data)
        {
            using var transaction = _haydenContext.Database.BeginTransaction();
            try
            {
                var existLogin = await _haydenContext.Login.FirstOrDefaultAsync(l => l.UserName == data.UserName);
                if (existLogin != null)
                    return Response.Error("Login already exists.");
                await _haydenContext.Login.AddAsync(new Login 
                {
                    UserName = data.UserName,
                    Password = Encoding.ASCII.GetBytes(data.Password),
                    DateCreated = DateTime.UtcNow,
                    LastLogin = DateTime.UtcNow,
                    Status = 1
                });
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

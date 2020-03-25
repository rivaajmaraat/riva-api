using Hayden.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hayden.BLL
{
    public class BLLlogin
    {
        #region Constructor
        public BLLlogin()
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

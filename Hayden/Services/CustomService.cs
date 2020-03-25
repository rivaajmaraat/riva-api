using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hayden.Models;

namespace Hayden.Services
{
    public class CustomerService
    {
        #region Constructor
        public CustomerService()
        {

        }
        #endregion

        #region CRUD

        public static IQueryable<Customers> Get(HAYDENContext context, int custIdno)
        {
            if (context == null) context = new HAYDENContext();

            var item = (from i in context.Customers
                        select i);

            if (custIdno > 0)
            {
                item = item.Where(i => i.CustIdno == custIdno);
            }

            return item;
        }


        public static List<Customers> GetAll(HAYDENContext context)
        {
            return Get(context, 0).ToList();
        }

        public static Customers GetById(HAYDENContext context, int custIdno)
        {
            return Get(context, custIdno).FirstOrDefault();
        }

        #endregion

    }
}

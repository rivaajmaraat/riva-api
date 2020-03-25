using Hayden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hayden.BLL
{
    public class BLLorders
    {
        #region Constructor
        public BLLorders()
        {

        }

        #endregion

        #region CRUD

        public static IQueryable<Orders> Get(HAYDENContext context, int ordersId)
        {
            if (context == null) context = new HAYDENContext();

            var item = (from i in context.Orders
                        select i);

            if (ordersId > 0)
            {
                item = item.Where(i => i.OrdersId == ordersId);
            }

            return item;
        }


        public static List<Orders> GetAll(HAYDENContext context)
        {
            return Get(context, 0).ToList();
        }

        public static Orders GetById(HAYDENContext context, int ordersId)
        {
            return Get(context, ordersId).FirstOrDefault();
        }

        public static Orders InsertUpdate(HAYDENContext context, Orders iOrders)
        {
            var ExternalContext = false;

            if (context == null) context = new HAYDENContext();
            else ExternalContext = true;

            Orders item = null;

            if (iOrders.OrdersId <= 0)
            {
                item = new Orders();
            }
            else
            {
                item = GetById(context, iOrders.OrdersId);
            }

            if (item != null)
            {
                item.OrdersId = iOrders.OrdersId;
                item.OrderNoInternal = iOrders.OrderNoInternal;
                item.OrderNoCustomer = iOrders.OrderNoCustomer;
                item.OrderDate = iOrders.OrderDate;
                item.CustomerId = iOrders.CustomerId;
                item.RequiredDate = iOrders.RequiredDate;
                item.ShippedDate = iOrders.ShippedDate;
                item.OrderStatus = iOrders.OrderStatus;
                item.Comment = iOrders.Comment;

                if (iOrders.OrdersId <= 0) context.Orders.Add(item);
                if (!ExternalContext) context.SaveChanges();

                return item;
            }
            return null;
        }

        #endregion

    }
}

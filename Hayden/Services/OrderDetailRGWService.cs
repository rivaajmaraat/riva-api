using Hayden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hayden.Services
{
    public class OrderDetailRGWService
    {
        #region Constructor
        public OrderDetailRGWService()
        {

        }

        #endregion

        #region CRUD

        public static IQueryable<OrdersDetailsRgw> Get(HAYDENContext context, int ordersDetailsRgwid)
        {
            if (context == null) context = new HAYDENContext();

            var item = (from i in context.OrdersDetailsRgw
                        select i);

            if (ordersDetailsRgwid > 0)
            {
                item = item.Where(i => i.OrdersDetailsRgwid == ordersDetailsRgwid);
            }

            return item;
        }


        public static List<OrdersDetailsRgw> GetAll(HAYDENContext context)
        {
            return Get(context, 0).ToList();
        }

        public static OrdersDetailsRgw GetById(HAYDENContext context, int ordersDetailsRgwid)
        {
            return Get(context, ordersDetailsRgwid).FirstOrDefault();
        }

        public static OrdersDetailsRgw InsertUpdate(HAYDENContext context, OrdersDetailsRgw iOrdersDetailRgw)
        {
            var ExternalContext = false;

            if (context == null) context = new HAYDENContext();
            else ExternalContext = true;

            OrdersDetailsRgw item = null;

            if (iOrdersDetailRgw.OrdersDetailsRgwid <= 0)
            {
                item = new OrdersDetailsRgw();
            }
            else
            {
                item = GetById(context, iOrdersDetailRgw.OrdersDetailsRgwid);
            }

            if (item != null)
            {
                item.OrdersDetailsRgwid = iOrdersDetailRgw.OrdersDetailsRgwid;
                item.OrderDetailsId = iOrdersDetailRgw.OrderDetailsId;
                item.OrderCode = iOrdersDetailRgw.OrderCode;
                item.MoldCode = iOrdersDetailRgw.MoldCode;
                item.RivaCode = iOrdersDetailRgw.RivaCode;
                item.ResizeWax = iOrdersDetailRgw.ResizeWax;

                if (iOrdersDetailRgw.OrdersDetailsRgwid <= 0) context.OrdersDetailsRgw.Add(item);
                if (!ExternalContext) context.SaveChanges();

                return item;
            }
            return null;
        }

        #endregion


    }
}

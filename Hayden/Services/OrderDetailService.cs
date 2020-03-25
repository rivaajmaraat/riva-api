using Hayden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hayden.Services
{
    public class OrderDetailService
    {
        #region Constructor
        public OrderDetailService()
        {

        }

        #endregion

        #region CRUD

        public static IQueryable<OrdersDetails> Get(HAYDENContext context, int ordersDetailsId)
        {
            if (context == null) context = new HAYDENContext();

            var item = (from i in context.OrdersDetails
                        select i);

            if (ordersDetailsId > 0)
            {
                item = item.Where(i => i.OrdersDetailsId == ordersDetailsId);
            }

            return item;
        }


        public static List<OrdersDetails> GetAll(HAYDENContext context)
        {
            return Get(context, 0).ToList();
        }

        public static OrdersDetails GetById(HAYDENContext context, int ordersDetailsId)
        {
            return Get(context, ordersDetailsId).FirstOrDefault();
        }

        public static OrdersDetails InsertUpdate(HAYDENContext context, OrdersDetails iOrdersDetail)
        {
            var ExternalContext = false;

            if (context == null) context = new HAYDENContext();
            else ExternalContext = true;

            OrdersDetails item = null;

            if (iOrdersDetail.OrdersDetailsId <= 0)
            {
                item = new OrdersDetails();
            }
            else
            {
                item = GetById(context, iOrdersDetail.OrdersDetailsId);
            }

            if (item != null)
            {
                item.OrdersDetailsId = iOrdersDetail.OrdersDetailsId;
                item.OrdersId = iOrdersDetail.OrdersId;
                item.ProductsId = iOrdersDetail.ProductsId;
                item.MaterialCode = iOrdersDetail.MaterialCode;
                item.Size = iOrdersDetail.Size;
                item.Qtyrequested = iOrdersDetail.Qtyrequested;
                item.Qtyshipped = iOrdersDetail.Qtyshipped;
                item.Comment = iOrdersDetail.Comment;

                if (iOrdersDetail.OrdersDetailsId <= 0) context.OrdersDetails.Add(item);
                if (!ExternalContext) context.SaveChanges();

                return item;
            }
            return null;
        }

        #endregion
    }
}

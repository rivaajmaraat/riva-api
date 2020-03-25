using Hayden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hayden.Services
{
    public class MetalMarketService
    {
        #region Constructor
        public MetalMarketService()
        {

        }

        #endregion

        #region CRUD

        public static IQueryable<MetalMarket> Get(HAYDENContext context, int metalMarketId)
        {
            if (context == null) context = new HAYDENContext();

            var item = (from i in context.MetalMarket
                        select i);

            if (metalMarketId > 0)
            {
                item = item.Where(i => i.MetalMarketId == metalMarketId);
            }

            return item;
        }


        public static List<MetalMarket> GetAll(HAYDENContext context)
        {
            return Get(context, 0).ToList();
        }

        public static MetalMarket GetById(HAYDENContext context, int metalMarketId)
        {
            return Get(context, metalMarketId).FirstOrDefault();
        }

        #endregion


    }
}

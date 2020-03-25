using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hayden.Models;

namespace Hayden.Services
{
    public class GemInventoryService
    {
        #region Constructor
        public GemInventoryService()
        {

        }
        #endregion

        #region CRUD

        public static IQueryable<GemInventory> Get(HAYDENContext context, int gemId)
        {
            if (context == null) context = new HAYDENContext();

            var item = (from i in context.GemInventory
                        select i);

            if (gemId > 0)
            {
                item = item.Where(i => i.GemId == gemId);
            }

            return item;
        }


        public static List<GemInventory> GetAll(HAYDENContext context)
        {
            return Get(context, 0).ToList();
        }

        public static GemInventory GetById(HAYDENContext context, int gemID)
        {
            return Get(context, gemID).FirstOrDefault();
        }

        #endregion

    }
}

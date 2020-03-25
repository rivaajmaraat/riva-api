using Hayden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hayden.Services
{
    public class MaterialCodeService
    {

        #region Constructor
        public MaterialCodeService()
        {

        }

        #endregion

        #region CRUD

        public static IQueryable<MaterialCodes> Get(HAYDENContext context, int materialCodeId)
        {
            if (context == null) context = new HAYDENContext();

            var item = (from i in context.MaterialCodes
                        select i);

            if (materialCodeId > 0)
            {
                item = item.Where(i => i.MaterialCodeId == materialCodeId);
            }

            return item;
        }


        public static List<MaterialCodes> GetAll(HAYDENContext context)
        {
            return Get(context, 0).ToList();
        }

        public static MaterialCodes GetById(HAYDENContext context, int materialCodeId)
        {
            return Get(context, materialCodeId).FirstOrDefault();
        }

        #endregion


    }
}

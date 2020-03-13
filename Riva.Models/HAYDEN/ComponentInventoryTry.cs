using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class ComponentInventoryTry
    {
        public int ComponentId { get; set; }
        public string Series { get; set; }
        public string ComponentName { get; set; }
        public int ComponentTypeId { get; set; }
        public bool? Cursive { get; set; }
        public bool? Dia { get; set; }
        public int? DiaQty10 { get; set; }
        public int? DiaQty13 { get; set; }
        public int? DiaQty15 { get; set; }
        public int? DiaQty18 { get; set; }
        public string Location { get; set; }
        public int? Lenght { get; set; }
        public int? StockSs { get; set; }
        public int? MinStockSs { get; set; }
        public int? MaxStockSs { get; set; }
        public int? Stock14yg { get; set; }
        public int? MinStock14yg { get; set; }
        public int? MaxStock14yg { get; set; }
        public int? Stock18yg { get; set; }
        public int? MinStock18yg { get; set; }
        public int? MaxStock18yg { get; set; }
        public int? Stock14wg { get; set; }
        public int? MinStock14wg { get; set; }
        public int? MaxStock14wg { get; set; }
        public int? Stock18wg { get; set; }
        public int? MinStock18wg { get; set; }
        public int? MaxStock18wg { get; set; }
        public int? Stock14rg { get; set; }
        public int? MinStock14rg { get; set; }
        public int? MaxStock14rg { get; set; }
        public int? Stock18rg { get; set; }
        public int? MinStock18rg { get; set; }
        public int? MaxStock18rg { get; set; }

        public virtual ComponentTypes ComponentType { get; set; }
    }
}

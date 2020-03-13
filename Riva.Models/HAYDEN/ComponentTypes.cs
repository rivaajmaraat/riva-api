using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class ComponentTypes
    {
        public ComponentTypes()
        {
            ComponentInventoryTry = new HashSet<ComponentInventoryTry>();
        }

        public int ComponentTypeId { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }

        public virtual ICollection<ComponentInventoryTry> ComponentInventoryTry { get; set; }
    }
}

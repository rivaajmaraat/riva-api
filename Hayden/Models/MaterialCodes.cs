using System;
using System.Collections.Generic;

namespace Hayden.Models
{
    public partial class MaterialCodes
    {
        public int MaterialCodeId { get; set; }
        public string Code { get; set; }
        public string Karat { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
    }
}

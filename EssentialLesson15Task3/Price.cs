using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson15Task1
{
    struct Price
    {
        public string Product { get; set; }
        public string Shop { get; set; }
        public int? PriceUAH { get; set; }

        public override string ToString()
        {
            return $"Product {Product}, Shop {Shop}, PriceUAH {PriceUAH}";
        }
    }
}

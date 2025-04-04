using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfm2
{
    public class Part
    {
        public int PartID { get; set; }
        public string PartName { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string Source { get; set; }
        public string where { get; set; }
        public Part(int PartID, string Name, decimal Price, int InStock, int Min, int Max, string where)
        {
            this.PartID = PartID;
            this.PartName = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.Source = "null";
            this.where = where;
        }
    }
    public class InHouse : Part
    {
        public InHouse(int PartID, string Name, decimal Price, int InStock, int Min, int Max, string where)
            : base(PartID, Name, Price, InStock, Min, Max, where)
        {
            this.Source = "inhouse";
        }
    }

    public class Outsourced : Part
    {
        public Outsourced(int PartID, string Name, decimal Price, int InStock, int Min, int Max, string where)
            : base(PartID, Name, Price, InStock, Min, Max, where)
        {
            this.Source = "out";
        }
    }
}

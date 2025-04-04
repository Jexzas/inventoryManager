using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfm2
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(BindingList<Part> parts, int proid, string name, decimal price, int instock, int min, int max)
        {
            this.AssociatedParts = parts;
            this.ProductID = proid;
            this.Name = name;
            this.Price = price;
            this.InStock = instock;
            this.Min = min;
            this.Max = max;
        }

        public void addAssociatedPart(Part part)
        {

        }

        public bool removeAssociatedPart(int id)
        {
            return false;
        }

        public Part lookupAssociatedPart(int partID)
        {
            return AssociatedParts[partID];
        }
    }
}

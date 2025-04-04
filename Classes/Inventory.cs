using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfm2
{
    public class Inventory
    {
        public BindingList<Product> Products;
        public BindingList<Part> AllParts;
        public Inventory()
        {
            this.AllParts = new BindingList<Part>() {
                new InHouse(0, "Wheel", 12.11m, 13, 5, 25, "1"),
                new Outsourced(1, "Pedal", 8.22m, 11, 5, 25, "MegaPedal"),
                new Outsourced(2, "Chain", 8.33m, 12, 5, 25, "BikeMaster"),
                new InHouse(3, "Seat", 42.55m, 8, 2, 15, "1")
                };
            this.Products = new BindingList<Product>() {
                new Product([], 0, "Red Bicycle", 167.94m, 15, 1, 25),
                new Product([], 1, "White Bicycle", 197.94m, 13, 1, 25),
                new Product([], 2, "Green Bicycle", 117.94m, 4, 1, 25)
                };
        }

        public void addProduct(Product product)
        {
            Products.Add(product);
        }
        public bool removeProduct(int number)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete?", "Deleting Product", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                if (lookupProduct(number) != null)
                {
                    Products.Remove(lookupProduct(number));
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
        public Product lookupProduct(int number)
        {
            return Products[0];
        }

        public void updateProduct(int number, Product product)
        {
            Products[number] = product;
        }

        public void addPart(Part part) { 
            AllParts.Add(part);
        }
        public bool deletePart(Part part)
        {
            bool isAssoc = false;
            foreach (Product product in Products)
            {
                foreach (Part parted in product.AssociatedParts)
                {
                    if (parted == part)
                    {
                        isAssoc = true;
                    }
                }
            }
            var confirm = MessageBox.Show("Are you sure you want to delete?", "Deleting Part", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK && isAssoc == false)
            {
                foreach (var parted in AllParts)
                {
                    if (part == parted)
                    {
                        AllParts.Remove(parted);
                        return true;
                    }
                }
                return false;
            } else if (isAssoc == true)
            {
                MessageBox.Show("That part cannot be deleted. It is associated with a product.");
                return false;
            } else 
            {
                return false;
            }
        }

        public Part lookupPart(int number) {
            return AllParts[number];

        }
        public void updatePart(int number, Part part) {

            this.AllParts[number] = part;
        }
    }
}

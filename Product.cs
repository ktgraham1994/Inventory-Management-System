using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_PA
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        public Product()
        { }
        public void AddAssociatedPart(Part x)
        {
            AssociatedParts.Add(x);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            bool y = false;
            foreach(Part x in AssociatedParts)
            {
                if (x.PartID == partID)
                {
                    AssociatedParts.Remove(x);
                    return y = true;
                }
                else y = false;
            }
            return y;
        }

        public Part LookupAssociatedPart(int partID)
        {
            foreach(Part x in AssociatedParts)
            {
                if(x.PartID == partID)
                {
                    return x;
                }
            }
            return null;
        }
    }
}

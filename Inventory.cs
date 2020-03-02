using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_PA
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }
        
        public static bool DeleteProduct(int productID)
        {
            bool y = false;
            foreach(Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    Products.Remove(product);
                    y = true;
                }
                else 
                    y = false;
            }
            return y;
        }

        public static Product LookupProduct(int productID)
        {
            foreach(Product product in Products)
            {
                if(product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }

        public static void UpdateProduct(int productID, Product product)
        {
            foreach(Product x in Products)
            {
                if(x.ProductID == productID)
                {
                    x.Name = product.Name;
                    x.Price = product.Price;
                    x.InStock = product.InStock;
                    x.Min = product.Min;
                    x.Max = product.Max;
                    return;
                }
            }
        }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool DeletePart(int partID)
        {
            bool y = false;
            foreach(Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    AllParts.Remove(part);
                    y = true;
                }
                else
                    y = false;
            }
            return y;
        }

        public static Part LookupPart(int partID)
        {
            foreach(Part part in AllParts)
            {
                if(part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public static void UpdatePart(int partID, Part part)
        {
            foreach(Part x in AllParts)
            {
                if(x.PartID == partID)
                {
                    x.Name = part.Name;
                    x.Price = part.Price;
                    x.InStock = part.InStock;
                    x.Min = part.Min;
                    x.Max = part.Max;
                    return;
                }
            }
        }
    }
}

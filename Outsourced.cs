﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_PA
{
    public class Outsourced:Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
    }
}

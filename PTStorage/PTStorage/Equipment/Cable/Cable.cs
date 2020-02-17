﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Equipment.Cable
{
    class Cable:BaseEquip
    {
        public Cable()
        {
                
        }
        public Cable(string name, string description, double ePrice, double price)
        {
            Name = name;
            Description = description;
            EntryPrice = ePrice;
            Price = price;
            Coefficient = Price / EntryPrice;
        }
        
        
    }
}
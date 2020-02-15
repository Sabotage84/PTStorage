using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Equipment.Meinberg
{
    class SDU:BaseEquip
    {
        public SDU()
        {

        }
        public SDU(string name, string description, double ePrice, double price)
        {
            Name = name;
            Description = description;
            EntryPrice = ePrice;
            Price = price;
            Coefficient = Price / EntryPrice;
        }
    }
}

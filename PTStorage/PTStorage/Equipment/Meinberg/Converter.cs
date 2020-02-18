using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Equipment.Meinberg
{
    public class Converter:BaseEquip
    {
        public Converter()
        {

        }
        public Converter(string name, string description, double ePrice, double price) : base(name, description, ePrice, price)
        {
            
        }

    }
}

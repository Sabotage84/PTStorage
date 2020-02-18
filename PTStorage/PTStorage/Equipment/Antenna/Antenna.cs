using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Equipment.Antenna
{
    public class Antenna:BaseEquip
    {
        public Antenna()
        {

        }
        public Antenna(string name, string description, double ePrice, double price) : base(name, description, ePrice, price)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Equipment.Cable
{
    public class Cable:BaseEquip
    {
        int meters;
        public Cable()
        {
                
        }
        public Cable(string name, string description, double ePrice, double price, int metr=0) : base(name, description, ePrice, price)
        {
            Meters = metr;
        }

        public int Meters { get => meters; set => meters = value; }
    }
}

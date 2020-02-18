using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Equipment.Meinberg
{
    public class SDU:BaseEquip
    {
        public SDU()
        {
            //NullReferenceException e = new NullReferenceException();
            //throw (e);
        }
        public SDU(string name, string description, double ePrice, double price) : base(name, description, ePrice, price)
        {
            
        }
    }
}

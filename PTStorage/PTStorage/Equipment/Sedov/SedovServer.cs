using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Equipment.Sedov
{
    public class SedovServer:BaseEquip
    {
        bool possibilityOfVerification;

        public SedovServer()
        {

        }
        

        public SedovServer(string name, string description, double ePrice, double price, bool verification=false) : base(name, description, ePrice, price)
        {
            PossibilityOfVerification = verification;
        }

        public bool PossibilityOfVerification { get => possibilityOfVerification; set => possibilityOfVerification = value; }
    }
}

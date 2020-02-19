using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Equipment.Meinberg
{
    public class Server : BaseEquip
    {
        bool possibilityOfVerification;

        public Server()
        {
        }
        public Server(string name, string description, double ePrice, double price) : base(name, description, ePrice, price)
        {
            
        }
        public Server(string name, string description, double ePrice, double price, bool verification=false) : base(name, description, ePrice, price)
        {
            PossibilityOfVerification = verification;
        }

        public bool PossibilityOfVerification { get => possibilityOfVerification; set => possibilityOfVerification = value; }
    }
}

using PTStorage.Options;
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
        List<Option> options;

        public Server()
        {
            options = new List<Option>();
        }

        public Server(string name, string description, double ePrice, double price, List<Option> ops, bool verification=false) : base(name, description, ePrice, price)
        {
            options = ops;
            PossibilityOfVerification = verification;
        }

        public bool PossibilityOfVerification { get => possibilityOfVerification; set => possibilityOfVerification = value; }
    }
}

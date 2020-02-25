using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Equipment
{
    public abstract class BaseEquip:IComparable
    {
        
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public double EntryPrice { get => entryPrice; set => entryPrice = value; }
        public double Coefficient { get => coefficient; set => coefficient = value; }

        string name;
        private double price;
        string description;
        double entryPrice;
        double coefficient;

        public BaseEquip(string name, string description, double ePrice, double price)
        {
            Name = name;
            Description = description;
            EntryPrice = ePrice;
            Price = price;
            Coefficient = Price / EntryPrice;
        }

        public BaseEquip()
        {

        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            BaseEquip otherEq = obj as BaseEquip;
            if (otherEq != null)
                return this.Name.CompareTo(otherEq.Name);
            else
                throw new ArgumentException("Object is not a Temperature");
        }
    }
}

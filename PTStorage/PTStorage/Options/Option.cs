using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Options
{
    public class Option
    {
        public int ID;
        string shortName;
        int count;
        string fullName;

        public string ShortName { get => shortName; set => shortName = value; }
        public int Count { get => count; set => count = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public Option()
        {

        }

        public Option(string name, int count=1)
        { 
            Count = count;
            ShortName = name;
            if (Count < 2)
            {
                if (ShortName == "TC")
                    FullName = ShortName + "-" + Count + "-" + Count;
                else
                    FullName = ShortName;
            }
            else
            {
                if (ShortName == "LNE" || ShortName == "GE")
                    FullName = Count + ShortName;
                else if (ShortName == "TC")
                    FullName = ShortName + "-" + Count + "-" + Count;
                else
                    FullName = ShortName + "-" + Count;
            }
           
        }

        public override bool Equals(object obj)
        {
            if (obj is Option)
            {
                Option op = (Option)obj;
                return FullName.Equals(op.FullName);
            }
            else
                return false;
            
        }

        public override int GetHashCode()
        {
            var hashCode = 1111060993;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(shortName);
            hashCode = hashCode * -1521134295 + count.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(fullName);
            return hashCode;
        }
    }
}

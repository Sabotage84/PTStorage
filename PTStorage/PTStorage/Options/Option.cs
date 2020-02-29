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
            //return base.Equals(obj);
        }

    }
}

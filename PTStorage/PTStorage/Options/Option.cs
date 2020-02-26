using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Options
{
    public class Option
    {
        string shortName;
        int count;
        string fullName;

        public string ShortName { get => shortName; set => shortName = value; }
        public int Count { get => count; set => count = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public Option()
        {

        }

        public Option(string name, int count)
        { 
            Count = count;
            ShortName = name;
            if (Count<2)
                FullName = name;
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
        
    }
}

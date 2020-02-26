using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage.Options
{
    public static class OptionManager
    {
        static List<Option> allOptions;
        static OptionManager()
        {
            AllOptions = new List<Option>();
        }

        public static List<Option> AllOptions { get => allOptions; set => allOptions = value; }
    }
}

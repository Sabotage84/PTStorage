using PTStorage.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionManager.TestMeth();
            OptionManager.SaveAllOptions();
            Console.ReadKey();
        }
    }
}

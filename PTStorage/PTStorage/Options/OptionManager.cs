using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PTStorage.Options
{
[Serializable]
    public static class OptionManager
    {
        
        static List<Option> allOptions;
        static XmlSerializer formatter = new XmlSerializer(typeof(List<Option>));
        static OptionManager()
        {
            AllOptions = new List<Option>();
            LoadAllOptions();
        }

        public static List<Option> AllOptions { get => allOptions; set => allOptions = value; }

        static void LoadAllOptions(string filename= "options.xml")
        {
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    AllOptions = (List<Option>)formatter.Deserialize(fs);
                }
            }
            catch
            {
#if DEBUG
                Console.WriteLine("File Options.xml not found!");
#endif
                LoadDefaultOptions();
            }

            
        }

        private static void LoadDefaultOptions()
        {
            AllOptions.Add(new Option("TC"));
            AllOptions.Add(new Option("TC",2));
            AllOptions.Add(new Option("TC",3));
            AllOptions.Add(new Option("TC",4));
            AllOptions.Add(new Option("LNE"));
            AllOptions.Add(new Option("LNE",2));
            AllOptions.Add(new Option("FS"));
            AllOptions.Add(new Option("FS",2));
            AllOptions.Add(new Option("FS",3));
            AllOptions.Add(new Option("FS",4));
            AllOptions.Add(new Option("PS"));
            AllOptions.Add(new Option("PS", 2));
            AllOptions.Add(new Option("PS", 3));
            AllOptions.Add(new Option("PS", 4));
            AllOptions.Add(new Option("GE"));
            AllOptions.Add(new Option("GE", 3));

        }

        static public void SaveAllOptions()
        {
            try
            {
                using (FileStream fs = new FileStream("options.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, AllOptions);
                }
            }
            catch
            {
#if DEBUG
                Console.WriteLine("Can not serialize alloptions");
#endif
            }
        }

        public static void TestMeth()
        {
            Console.WriteLine("test from option manager");
        }

        public static void AddOption(Option op)
        {
            if (AllOptions.Contains(op))
            {
#if DEBUG
                Console.WriteLine("Option already in list!");
#endif

            }
            else
                AllOptions.Add(op);
        }

    }
}

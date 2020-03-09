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

        static void LoadAllOptions(string filename = "options.xml")
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
            AllOptions.Add(new Option("TC",2500));
            AllOptions.Add(new Option("TC",2500, 2));
            AllOptions.Add(new Option("TC",2500, 3));
            AllOptions.Add(new Option("TC",2500, 4));
            AllOptions.Add(new Option("LNE",2000));
            AllOptions.Add(new Option("LNE",2000, 2));
            AllOptions.Add(new Option("FS",3000));
            AllOptions.Add(new Option("FS",3000, 2));
            AllOptions.Add(new Option("FS",3000, 3));
            AllOptions.Add(new Option("FS",3000, 4));
            AllOptions.Add(new Option("PS",3000));
            AllOptions.Add(new Option("PS", 3000, 2));
            AllOptions.Add(new Option("PS", 3000, 3));
            AllOptions.Add(new Option("PS", 3000, 4));
            AllOptions.Add(new Option("GE", 3000));
            AllOptions.Add(new Option("GE", 3000, 3));
            SaveAllOptions();
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

        public static void RemoveOption(string fullName)
        {
            int count = allOptions.RemoveAll(x => x.FullName == fullName);
#if DEBUG
            Console.WriteLine("{0} element(s) deleted");
#endif
        }

        public static List<Option>  FindAllOptionsLike(string shortName)
        {
            return AllOptions.FindAll(x => x.ShortName.Contains(shortName));
        }

        public static Option GetOption(string fullName)
        {
            return AllOptions.Find(x => x.FullName == fullName);
        }

        public static string GetFullOptionName(List<Option> options)
        {
            string res = "";
            foreach (var item in options)
            {
                res += item.FullName + "/";
            }
            return res.Substring(0,res.Length-1);
        }
    }
}

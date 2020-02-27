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

        static void LoadAllOptions()
        {
            using (FileStream fs = new FileStream("options.xml", FileMode.OpenOrCreate))
            {
                AllOptions = (List<Option>)formatter.Deserialize(fs);
            }

            AllOptions.Add(new Option("GE", 3));
        }

        static public void SaveAllOptions()
        {
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("options.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, AllOptions);
            }
        }

        public static void TestMeth()
        {
            Console.WriteLine("test from option manager");
        }

    }
}

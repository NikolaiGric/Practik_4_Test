using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace Practik_4_Test
{
    class Class1
    {
        public static void mySerialize<T>(T ob)
        {
            string Put = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\.json";
            string json = JsonConvert.SerializeObject(ob);
            File.WriteAllText(Put, json);
        }
        public static T myDeserialize<T>()
        {
            string Put = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\.json";
            string json = File.ReadAllText(Put);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
    }
}

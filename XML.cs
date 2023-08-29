using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OtusHome4
{
    internal class XML
    {
        public static void GetStringXML() 
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(F));
            F f = new F().Get();
            using (FileStream fs = new FileStream("E:\\person.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, f);
            }
        }
    }
}

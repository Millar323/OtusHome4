using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHome4
{
    internal class Deser
    {
        public static DeserialisedData Deserialise() 
        {
            using (TextFieldParser textFieldParser = new TextFieldParser("D:\\csv.csv"))
            {
                textFieldParser.TextFieldType = FieldType.Delimited;
                textFieldParser.SetDelimiters(",");
                var testDeser = new DeserialisedData();
                string[] rows = textFieldParser.ReadFields();
                testDeser.i1 = Int32.Parse(rows[0]);
                testDeser.i2 = Int32.Parse(rows[1]);
                testDeser.i3 = Int32.Parse(rows[2]);
                testDeser.i4 = Int32.Parse(rows[3]);
                return testDeser;
            }
        }
    }
}

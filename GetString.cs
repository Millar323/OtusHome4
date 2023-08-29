using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHome4
{
    internal class GetString
    {
        public static void GetFString()
        {
            var type = typeof(F);
            var newF = new F().Get();
            var fields = newF.GetType().GetFields();
            List<string> result = new List<string>();
            foreach (var field in fields)
            {
                string fieldValue = type.GetField(field.Name).GetValue(newF).ToString();
                result.Add(fieldValue);
            }

            string pathCsvFile = "D:\\csv.csv";
            if (!File.Exists(pathCsvFile))
            {
                File.Create(pathCsvFile);
            }
            File.AppendAllLines(pathCsvFile, result);
        }

    }
}

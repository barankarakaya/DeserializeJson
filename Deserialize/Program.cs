using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deserialize
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Json veri getir
            var data=GetJsonData();

            //kullanılacak model Weather
            //Json daatayı modele uyarlamak gerekiyor.
            var MyEntities=Deserialize(data);

            //C# modelimi Json' a geri çevir.
            ConvertJson(MyEntities);
        }

        public static void ConvertJson(Weather model)
        {
            WriteMessage("Json Data'ta geri çevir.");
            var jsonObject = JsonConvert.SerializeObject(model);
            WriteMessage(jsonObject);

        }

        public static Weather Deserialize(string model)
        {
            WriteMessage("Modelimize uyarlıyoruz..");
            var convertData=JsonConvert.DeserializeObject<Weather>(model);
            WriteMessage(convertData.GetType().ToString());
            WriteMessage(convertData.Summary);
            return convertData;
        }
        //Get Json datayı içine atıcaz.
        public static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string GetJsonData()
        {
            var model = @"{
            'Date': '2019 - 08 - 01T00: 00:00 - 07:00',
            'TemperatureCelsius': 25,
            'Summary': 'Hot',
            'TemperatureRanges': {
                          'coldMinTemp': 20,
              'hotMinTemp': 40
            }
           }";

            return model;
        }
    }

}

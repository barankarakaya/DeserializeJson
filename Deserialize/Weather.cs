using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Deserialize.Program;

namespace Deserialize
{
    public class Weather
    {
        public string Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
        public TemperatureRanges TemperatureRanges { get; set; }
    }
}

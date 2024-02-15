using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Weather
    {
        [JsonProperty("humidity")]
        public string Humidity { get; set; }

        [JsonProperty("temp_celsius")]
        public string TempCelsius { get; set; }

        [JsonProperty("temp_farenheit")]
        public string TempFahrenheit { get; set; }

        [JsonProperty("wind_speed")]
        public string WindSpeed { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}

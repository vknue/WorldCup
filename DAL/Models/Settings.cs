using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace DAL.Models
{
    public class Settings
    {
        private const string PATH =Constants.SETTINGS_FILE;



        [JsonProperty("gender")]
        public Gender gender { get; set; }
        [JsonProperty("data_access_mode")]
        public DataAccessMode dataAccessMode { get; set; }
        [JsonProperty("language")]
        public Language language { get; set; }
        [JsonProperty("window_mode")]
        public WindowMode windowMode { get; set; }



        private Settings() { }

        public void save()
        {



            string settingsJson = JsonConvert.SerializeObject(this, Formatting.Indented);



            File.WriteAllText(PATH, settingsJson);



        }



        public static Settings load()
        {
            if (File.Exists(PATH))
            {
                string content = File.ReadAllText(PATH);



                return JsonConvert.DeserializeObject<Settings>(content);



            }
            else
            {
                return new Settings()
                {
                    gender = Gender.MEN,
                    dataAccessMode = DataAccessMode.API,
                    language = Language.ENG,
                    //favouritePlayers = new(),
                    windowMode = WindowMode.M
                };
            }
        }



        public static bool FirstRun()
        {
            return File.Exists(PATH) ? false : true;
        }



    }



    public enum Language
    {
        ENG = 0,
        CRO
    }



    public enum DataAccessMode
    {
        API = 0,
        FILE
    }



    public enum Gender
    {
        MEN = 0,
        WOMEN
    }



    public enum WindowMode
    {
        XL = 0,
        L,
        M
    }
}
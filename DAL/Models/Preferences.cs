using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace DAL.Models
{
    public class Preferences
    {
        private const string PATH =Constants.PREFERENCES_FILE;

        [JsonProperty("favouriteTeam")]
        public string favouriteTeam { get; set; }
        
        [JsonProperty("favouritePlayers")]
        public List<Player> favouritePlayers { get; set; } = new List<Player>();
     
        public void save()
        {
            if (favouriteTeam is null || favouriteTeam == "") favouriteTeam = "ENG";
            string settingsJson = JsonConvert.SerializeObject(this, Formatting.Indented);

            File.WriteAllText(PATH, settingsJson);
        }



        public static Preferences load()
        {
            if (File.Exists(PATH))
            {
                string content = File.ReadAllText(PATH);
                Preferences? preferences = JsonConvert.DeserializeObject<Preferences>(content);
                if(preferences.favouritePlayers is null )
                    preferences.favouritePlayers = new List<Player>();
                return preferences;

            }
            else
            {
                return new Preferences()
                {

                    favouriteTeam = "HR",
                    favouritePlayers = new()
                };
            }
        }



        public static bool FirstRun()
        {
            return File.Exists(PATH) ? false : true;
        }



    }


}
using DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace DAL.Repositories
{
    public class APIRepository : IRepository
    {
        
        private static APIRepository instance;

        private APIRepository()
        {
        }

       

        public static APIRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new APIRepository();
                }
                return instance;
            }
        }

        public async Task<List<Match>> getMatchesForTeam(string CountryCode)
        {
            String gender = Settings.load().gender.ToString().ToLower();
            string baseUrl = $"https://worldcup-vua.nullbit.hr/{gender}/matches/country";
            UriBuilder uriBuilder = new UriBuilder(baseUrl);
            uriBuilder.Query = $"fifa_code={WebUtility.UrlEncode(CountryCode)}";

            using (WebClient client = new WebClient())
            {
                string TeamsJSON = client.DownloadString(uriBuilder.Uri);
                return JsonConvert.DeserializeObject<List<Match>>(TeamsJSON);
            }
        }

        public async Task<List<Player>> getPlayersForCountry(string CountryCode)
        {
            String gender = Settings.load().gender.ToString().ToLower();
            string baseUrl = $"https://worldcup-vua.nullbit.hr/{gender}/matches/country";
            UriBuilder uriBuilder = new UriBuilder(baseUrl);
            uriBuilder.Query = $"fifa_code={WebUtility.UrlEncode(CountryCode)}";

            using WebClient client = new();
            string TeamsJSON = client.DownloadString(uriBuilder.Uri);
            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(TeamsJSON);
            var teamStatistics = (matches[0].HomeTeam.FifaCode == CountryCode)
                ? matches[0].HomeTeamStatistics
                : matches[0].AwayTeamStatistics;

            return teamStatistics.StartingEleven.Concat(teamStatistics.Substitutes).ToList();
        }

        public async Task<List<Team>> getTeams()
        {
            String gender = Settings.load().gender.ToString().ToLower();
            WebClient client = new();
            string TeamsJSON = client.DownloadString($"https://worldcup-vua.nullbit.hr/{gender}/teams");
            return JsonConvert.DeserializeObject<List<Team>>(TeamsJSON);
        }
    }
}

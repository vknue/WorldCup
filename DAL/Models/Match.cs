using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Match
    {
        [JsonProperty("venue")]
        public string Venue { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("fifa_id")]
        public string FifaId { get; set; }

        [JsonProperty("weather")]
        public Weather Weather { get; set; }

        [JsonProperty("attendance")]
        public string Attendance { get; set; }

        [JsonProperty("officials")]
        public List<string> Officials { get; set; }

        [JsonProperty("stage_name")]
        public string StageName { get; set; }

        [JsonProperty("home_team_country")]
        public string HomeTeamCountry { get; set; }

        [JsonProperty("away_team_country")]
        public string AwayTeamCountry { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }

        [JsonProperty("winner")]
        public string? Winner { get; set; }

        [JsonProperty("winner_code")]
        public string? WinnerCode { get; set; }

        [JsonProperty("home_team")]
        public Team? HomeTeam { get; set; }

        [JsonProperty("away_team")]
        public Team? AwayTeam { get; set; }

        [JsonProperty("home_team_events")]
        public List<Event>? HomeTeamEvents { get; set; }

        [JsonProperty("away_team_events")]
        public List<Event>? AwayTeamEvents { get; set; }

        [JsonProperty("home_team_statistics")]
        public Statistics HomeTeamStatistics { get; set; }

        [JsonProperty("away_team_statistics")]
        public Statistics AwayTeamStatistics { get; set; }

        public override string ToString()
        => $"{Location}, {AwayTeamCountry}";
    }
}

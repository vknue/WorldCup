using DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class FileRepository : IRepository
    {

        private static FileRepository instance;

        private FileRepository()
        {
        }

        public static FileRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FileRepository();
                }
                return instance;
            }
        }

        public async Task<List<Match>> getMatchesForTeam(string CountryCode)
        {
            try
            {
                string filePath = $"C:\\Users\\valon\\Documents\\Algebra\\Semestar 4\\.NET\\worldcup-sfg-io\\worldcup.sfg.io\\{Settings.load().gender.ToString().ToLower()}\\matches.json";
                string jsonContent = File.ReadAllText(filePath);
                List<Match> allMatches = JsonConvert.DeserializeObject<List<Match>>(jsonContent);
                List<Match> teamMatches = new();
                allMatches.ForEach(x =>
                {
                    if (x.HomeTeam.FifaCode == CountryCode || x.AwayTeam.FifaCode == CountryCode) { teamMatches.Add(x); }
                });
                return teamMatches;

            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., file not found or invalid JSON format
                Console.WriteLine($"Error reading data from file: {ex.Message}");
                return null;
            }
        }

        public async  Task<List<Player>> getPlayersForCountry(string CountryCode)
        {
            try
            {
                string filePath = $"C:\\Users\\valon\\Documents\\Algebra\\Semestar 4\\.NET\\worldcup-sfg-io\\worldcup.sfg.io\\{Settings.load().gender.ToString().ToLower()}\\matches.json";
                string jsonContent = File.ReadAllText(filePath);
                List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(jsonContent);
                var teamStatistics = (matches[0].HomeTeam.FifaCode == CountryCode)
                    ? matches[0].HomeTeamStatistics
                    : matches[0].AwayTeamStatistics;

                return teamStatistics.StartingEleven.Concat(teamStatistics.Substitutes).ToList();

            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., file not found or invalid JSON format
                Console.WriteLine($"Error reading data from file: {ex.Message}");
                return null;
            }
        }

        public async Task<List<Team>> getTeams()
        {
            try
            {
                string filePath = $"C:\\Users\\valon\\Documents\\Algebra\\Semestar 4\\.NET\\worldcup-sfg-io\\worldcup.sfg.io\\{Settings.load().gender.ToString().ToLower()}\\teams.json";
                string jsonContent = File.ReadAllText(filePath);
                List<Team> allTeams = JsonConvert.DeserializeObject<List<Team>>(jsonContent);
                return allTeams;
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., file not found or invalid JSON format
                Console.WriteLine($"Error reading data from file: {ex.Message}");
                return null;
            }
        }
    }
}

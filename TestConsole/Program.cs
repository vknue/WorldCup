using DAL.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;


internal class Program
{
    private static void Main(string[] args)
    {
        WebClient client = new();
        string TeamsJSON = client.DownloadString("https://worldcup-vua.nullbit.hr/men/teams");
        string MatchesJSON = client.DownloadString("https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=ENG");

        List<Team> Teams = JsonConvert.DeserializeObject<List<Team>>(TeamsJSON);

        // Now, you have a list of Team objects.
        Teams.ForEach(Console.WriteLine);


        // Deserialize the JSON array into a list of Match objects
        List<Match> Matches = JsonConvert.DeserializeObject<List<Match>>(MatchesJSON);

        Matches.ForEach(Console.WriteLine);
        // Now you can access the data within the 'matches' list
    }
}
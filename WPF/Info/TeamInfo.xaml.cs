using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF.Info
{
    /// <summary>
    /// Interaction logic for TeamInfo.xaml
    /// </summary>
    public partial class TeamInfo : Window
    {
        public  TeamInfo(Team team)
        {
            InitializeComponent();
            ShowAnimation();
            FillData(team);
            


        }
        private async void ShowAnimation()
        {
            var openAnimation = Resources["OpenAnimation"] as Storyboard;
            if (openAnimation != null)
            {
                await Task.Delay(100); // Delay for a short moment before starting the animation
                openAnimation.Begin(this);
            }
        }

        private async Task FillData(Team team)
        {
            List<Match> matches =await RepositoryFactory.GetRepository().getMatchesForTeam(team.FifaCode);

            txtTeamName.Text = team.Country;
            txtFifaCode.Text = team.FifaCode;
            txtGames.Text = matches.Count.ToString();


            int numberOfGoals = 0;
            int numberOfGoalsConcided = 0;
            int numberOfWins = 0;
            int numberOfLoses = 0;
            int numberOfDraws = 0;
            foreach (Match match in matches)
            {
                Team t = match.HomeTeam.Equals(team) ? match.HomeTeam : match.AwayTeam;
                Team ot = match.HomeTeam.Equals(team) ? match.AwayTeam : match.HomeTeam;
                numberOfGoals += (int)t.Goals;
                numberOfGoalsConcided += (int)ot.Goals;
                if (match.WinnerCode == "Draw") numberOfDraws++;
                else if (match.WinnerCode == team.FifaCode) numberOfWins++;
                else  numberOfLoses++;

            }

            txtWins.Text = numberOfWins.ToString();
            txtLosses.Text = numberOfLoses.ToString();
            txtDraws.Text = numberOfDraws.ToString();
            txtGoalsScored.Text = numberOfGoals.ToString();
            txtGoalsConceded.Text = numberOfGoalsConcided.ToString();
            txtGoalDifference.Text = Math.Abs(numberOfGoals - numberOfGoalsConcided).ToString();
        }
    }
}

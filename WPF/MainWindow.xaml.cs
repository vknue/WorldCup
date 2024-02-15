using DAL;
using DAL.Models;
using DAL.Repositories;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.Info;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IRepository repository;
        List<Team> teams;

        public MainWindow()
        {

            InitializeComponent();

            if(!File.Exists(Constants.SETTINGS_FILE)) { 
                new SettingsWindow().Show();
                Hide();
            }
            else
            {
                SetSize();
            }

            
            ReceiveData();
            FillComboBox();
            LoadPreferedTeam();
        }

        private void SetSize()
        {
            Settings settings = Settings.load();
            if (settings.windowMode == WindowMode.XL)
            {
                WindowState = WindowState.Maximized;
            }
            else if (settings.windowMode == WindowMode.L)
            {
                Rect workingArea = SystemParameters.WorkArea;
                mainWindow.Width = workingArea.Width * 0.75;
                mainWindow.Height = workingArea.Height * 0.75;
            }
            else
            {
                Rect workingArea = SystemParameters.WorkArea;
                mainWindow.Width = workingArea.Width * 0.5;
                mainWindow.Height = workingArea.Height * 0.5;
            }
        }

        private void LoadPreferedTeam()
        {
            Preferences preferences = new Preferences();
            foreach (var item in cbFirstTeam.Items)
            {
                if (item is Team team && team. Equals(preferences.favouriteTeam))
                {
                    cbFirstTeam.SelectedItem = item;
                }
            }
        }

        private void FillComboBox()
        {
            cbFirstTeam.ItemsSource = teams;
            
        }

        private async void ReceiveData()
        {
            repository = RepositoryFactory.GetRepository();
            teams = await repository.getTeams();
        }

        private async void cbFirstTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbFirstTeam.SelectedItem != null)
            {
                var selectedItem = cbFirstTeam.SelectedItem;
                if (selectedItem is Team team)
                {
                    List<Match> matches = await repository.getMatchesForTeam(team.FifaCode);
                    List<Team> oppositeTeams = new();


                    matches.ForEach(match =>
                    {
                        Team y = match.HomeTeam.Equals(team) ?
                            match.AwayTeam :
                            match.HomeTeam;

                        oppositeTeams.Add(teams.First(x => x.Equals(y)));


                    });


                    cbSecondTeam.ItemsSource = oppositeTeams;
                    clearPlayers();
                    scoreFirstTeam.Text = "0";
                    scoreSecondTeam.Text = "0";
                    
                }
            }
        }

        private async void cbSecondTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbSecondTeam.SelectedItem != null)
            {
                var firstTeam = cbFirstTeam.SelectedItem;
                var secondTeam = cbSecondTeam.SelectedItem;
                if (firstTeam is Team team1 && secondTeam is Team team2)
                {
                    List<Match> matches = await repository.getMatchesForTeam(team1.FifaCode);
                    Match match = matches.First(x =>
                        (x.HomeTeam.Equals(team1) || x.AwayTeam.Equals(team1))
                        && (x.HomeTeam.Equals(team2) || x.AwayTeam.Equals(team2))
                    );

                    scoreFirstTeam.Text = 
                        match.HomeTeam.Equals(team1) 
                        ? match.HomeTeam.Goals.ToString() 
                        : match.AwayTeam.Goals.ToString();
                    scoreSecondTeam.Text = 
                        match.HomeTeam.Equals(team1) 
                        ? match.AwayTeam.Goals.ToString() 
                        : match.HomeTeam.Goals.ToString();


                    setUpPlayers(match);

                }
            }
        }

        private void setUpPlayers(Match match)
        {
            clearPlayers();

            if (cbFirstTeam.SelectedItem is Team team1 && cbSecondTeam.SelectedItem is Team team2)
            {
                setUpTeamPlayers(match, team1, homeGoalie, homeDefense, homeMidfield, homeAttack, match.HomeTeamEvents);
                setUpTeamPlayers(match, team2, awayGoalie, awayDefense, awayMidfield, awayAttack, match.AwayTeamEvents);
            }
        }

        private void setUpTeamPlayers(Match match, Team team, Panel goaliePanel, Panel defensePanel, Panel midfieldPanel, Panel attackPanel, List<Event> events)
        {
            var (teamStat, opponentStat) = match.HomeTeam.Equals(team)
                ? (match.HomeTeamStatistics, match.AwayTeamStatistics)
                : (match.AwayTeamStatistics, match.HomeTeamStatistics);

            teamStat.StartingEleven.ForEach(x =>
            {
                PlayerCard card = new(x);
                card.MouseLeftButtonDown += (sender, e) => Card_Clicked(sender, e, x, events);
                card.VerticalContentAlignment = VerticalAlignment.Center;
                AddCardToPanel(x.Position, card, goaliePanel, defensePanel, midfieldPanel, attackPanel);
            });
        }

        private void AddCardToPanel(string position, PlayerCard card, Panel goaliePanel, Panel defensePanel, Panel midfieldPanel, Panel attackPanel)
        {
            switch (position)
            {
                case "Goalie":
                    goaliePanel.Children.Add(card);
                    break;
                case "Defender":
                    defensePanel.Children.Add(card);
                    break;
                case "Midfield":
                    midfieldPanel.Children.Add(card);
                    break;
                case "Forward":
                    attackPanel.Children.Add(card);
                    break;
            }
        }

        private void Card_Clicked(object sender, MouseButtonEventArgs e, Player playerData, List<Event> events)
        {
            new PlayerInfo(playerData, events).ShowDialog();
        }

        private void clearPlayers()
        {
            foreach (var panel in gridPitch.Children)
            {
                if (panel is StackPanel sp) sp.Children.Clear();
            }
        }

        private void infoFirstTeam_Click(object sender, RoutedEventArgs e)
        {
            Team team = cbFirstTeam.SelectedItem as Team;
            if (team is null) {
                MessageBox.Show("Please select a team first");
                return;
            };
            new TeamInfo(team).ShowDialog();
        }

        private void infoSecondTeam_Click(object sender, RoutedEventArgs e)
        {
            Team team = cbSecondTeam.SelectedItem as Team;
            if (team is null)
            {
                MessageBox.Show("Please select a team first");
                return;
            };
            new TeamInfo(team).ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you really want to Exit?", "Confirmation", MessageBoxButton.YesNoCancel);

            if (result == MessageBoxResult.Yes)
            {
                e.Cancel = false;
            }
            else if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new SettingsWindow().Show();
            Hide();
        }
    
        private void ChangeName_Click(object sender, RoutedEventArgs e)
        {
            InputDialogWindow dialog = new InputDialogWindow();
            if (dialog.ShowDialog() == true)
            {
                string enteredText = dialog.InputText;
                mainWindow.Title = enteredText;

            }
        }
    }
}
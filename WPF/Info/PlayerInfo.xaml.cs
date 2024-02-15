using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for PlayerInfo.xaml
    /// </summary>
    public partial class PlayerInfo : Window
    {
        public PlayerInfo(Player player, List<Event> events)
        {

            InitializeComponent();
            SetupStrings();
            String imagePath = $"{Constants.IMAGES_FOLDER}{WebUtility.UrlEncode(player.ToString())}{Constants.IMAGES_EXTENSION}";
            txtPlayerName.Text = player.Name;
            txtShirtNumber.Text=player.ShirtNumber.ToString();
            txtPosition.Text=player.Position;
            txtIsCaptain.Text = player.Captain ? "Yes" : "No";
            txtGoalsScored.Text  = events.Count(e => e.TypeOfEvent == EventType.Goal && e.Player == player.Name).ToString();
            txtYellowCards.Text = events.Count(e => e.TypeOfEvent == EventType.YellowCard && e.Player == player.Name).ToString();


            if (File.Exists(imagePath))
            {
                try
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = new Uri(imagePath, UriKind.Absolute);
                    bitmapImage.EndInit();

                    imgPlayerImage.Source = bitmapImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File Error: {ex.Message}");
                    return;
                }
            }
        }

        private void SetupStrings()
        {
            Settings settings =Settings.load();
            if (settings.language == DAL.Models.Language.CRO)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("hr-HR");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            }

            lblPlayerName.Text = Properties.String.PlayerName;
            lblGoalsScored.Text = Properties.String.GoalsScored;
            lblIsCaptain.Text = Properties.String.Captain;
            lblPosition.Text = Properties.String.Position;
            lblShirtNumber.Text = Properties.String.ShirtNumber;
            lblYellowCards.Text = Properties.String.YellowCards;
            lblPlayerInformation.Text = Properties.String.PlayerInformation;
        }

        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);

            // Start the animation
            StartAnimation();
        }

        private void StartAnimation()
        {
            Storyboard openAnimation = (Storyboard)FindResource("OpenAnimation");
            openAnimation.Begin(this);
        }
    }
}

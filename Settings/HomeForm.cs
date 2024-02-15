using DAL.Models;
using DAL.Repositories;
using Forms.UserControls;
using Newtonsoft.Json.Linq;
using Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class HomeForm : Form
    {
        IRepository repo;
        Preferences preferences = Preferences.load();

        public HomeForm()
        {
            InitializeComponent();
            repo = RepositoryFactory.GetRepository();
            SetupStrings();
            PopulateList();

            this.CenterToScreen();

            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void SetupStrings()
        {
            DAL.Models.Settings settings = DAL.Models.Settings.load();
            if (settings.language == Language.CRO)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("hr-HR");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            }

            lbTeam.Text = Properties.Strings.Team;
            btnSeatAsFavourite.Text = Properties.Strings.SetAsFavourite;
            rankingsToolStripMenuItem.Text = Properties.Strings.Rankings;
            visitorsRankingsToolStripMenuItem.Text = Properties.Strings.VisitorRankings;
            playerRankingsToolStripMenuItem.Text = Properties.Strings.PlayerRankings;
            settingsToolStripMenuItem.Text = Properties.Strings.Settings;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(Properties.Resources.SettingsFilePath))
            {
                SettingsForm settings = new();
                Hide();
                settings.Show();
            }

        }



        private async  void PopulateList()
        {
            lblLoading.Visible = true;
            cbTeams.DataSource = await repo.getTeams();
            lblLoading.Visible = false; 
            cbTeams.Format += (sender, e) =>
            {
                if (e.ListItem is Team team)
                {
                    e.Value = $"{team.Country} ({team.FifaCode})";
                }
            };
            //set initial selection

            Preferences preferences = Preferences.load();
            selectTeam(preferences.favouriteTeam);
        }

        private void selectTeam(string favouriteTeam)
        {
            int selectedIndex = -1;
            for (int i = 0; i < cbTeams.Items.Count; i++)
            {
                Team team = (Team)cbTeams.Items[i];
                if (team.FifaCode == favouriteTeam)
                {
                    selectedIndex = i;
                    break;
                }
            }
            cbTeams.SelectedIndex = selectedIndex;
            FillPlayers();
        }




        private async void FillPlayers()
        {
            lblLoading.Visible = true;
            EmptyPlayerPanels();
            pnlPlayers.FlowDirection = FlowDirection.TopDown;
            Team selectedTeam = null;
            if (cbTeams.SelectedIndex >= 0)
            {
                selectedTeam = (Team)cbTeams.SelectedItem;

            }
            try
            {
                
                List<Player> players = await repo.getPlayersForCountry(selectedTeam is null ? "ENG" : selectedTeam.FifaCode);
                
                players.ForEach(x =>
                {
                    if (!preferences.favouritePlayers.Contains(x)) //its not favourite
                    {
                        pnlPlayers.Controls.Add(new PlayerCard(x));
                    }
                    else
                    {
                        pnlFavouritePlayers.Controls.Add(new PlayerCard(x));
                    }

                });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            lblLoading.Visible = false;
        }



        private void EmptyPlayerPanels()
        {
            pnlFavouritePlayers.Controls.Clear();
            pnlPlayers.Controls.Clear();
        }

        private void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTeams.SelectedIndex >= 0)
            {
                Team selectedItem = (Team)cbTeams.SelectedItem;
            }
            FillPlayers();
        }



        private void btnSeatAsFavourite_Click(object sender, EventArgs e)
        {
            Team selectedItem = (Team)cbTeams.SelectedItem;
            preferences.favouriteTeam = selectedItem.FifaCode;
            preferences.save();
        }

        private void pnlFavouritePlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pnlFavouritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            Player p = (Player)e.Data.GetData(typeof(Player));

            if (this.pnlFavouritePlayers.Controls.Count >= 3)
            {
                MessageBox.Show("Only 3 favourite players allowed per team!");
                return;
            }

            if (((FlowLayoutPanel)sender).Controls.ContainsKey(p.Name))
            {
                return;
            }


            preferences.favouritePlayers.Add(p);
            preferences.save();

            FillPlayers();
            //LoadFlowPanels();
        }

        private void pnlPlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pnlPlayers_DragDrop(object sender, DragEventArgs e)
        {
            Player p = (Player)e.Data.GetData(typeof(Player));

            if (((FlowLayoutPanel)sender).Controls.ContainsKey(p.Name))
            {
                return;
            }

            preferences.favouritePlayers.Remove(p);
            preferences.save();

            FillPlayers();
        }

        private void visitorsRankingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintMatches;

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            printPreviewDialog.ShowDialog();
        }

        private async void PrintMatches(object sender, PrintPageEventArgs e)
        {
            Team selectedTeam = null;
            if (cbTeams.SelectedIndex >= 0)
            {
                selectedTeam = (Team)cbTeams.SelectedItem;
            }
            Graphics? graphics = e.Graphics;

            if (graphics == null)
            {
                return;
            }

            graphics.DrawString("MATCH RANKING", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(Height / 2, 30));

            int yPos = 100;
            Font font = new Font("Arial", 10, FontStyle.Bold);

            graphics.DrawLine(new Pen(Color.FromArgb(50, 0, 0, 0)), new Point(0, yPos - 5), new Point(1000, yPos - 5));
            
            lblLoading.Visible = true;

            List<DAL.Models.Match> matches = await repo.getMatchesForTeam(selectedTeam.FifaCode);
            lblLoading.Visible = false;



            foreach (DAL.Models.Match m in matches.OrderBy(x => x.Attendance).Reverse().ToList())
            {
                graphics.DrawString($"{m.Venue}", font, Brushes.Black, new PointF(10, yPos));
                graphics.DrawString($"Home Team: {m.HomeTeam}", font, Brushes.Red, new PointF(150, yPos));
                graphics.DrawString($"Away Team: {m.AwayTeam}", font, Brushes.Blue, new PointF(400, yPos));
                graphics.DrawString($"Visitors: {m.Attendance}", font, Brushes.Black, new PointF(650, yPos));

                graphics.DrawLine(new Pen(Color.FromArgb(50, 0, 0, 0)), new Point(0, yPos + 20), new Point(1000, yPos + 20));

                yPos += 30;
            }



        }

        private void playerRankingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPlayers;


            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            printPreviewDialog.ShowDialog();
        }

        private async void  PrintPlayers(object sender, PrintPageEventArgs e)
        {
            Graphics? graphics = e.Graphics;
            Team selectedTeam = null;
            if (cbTeams.SelectedIndex >= 0)
             {
                selectedTeam = (Team)cbTeams.SelectedItem;
                
            }
            if (graphics == null)
            {
                return;
            }

            graphics.DrawString("PLAYER RANKING", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(Height / 2, 30));

            int yPos = 100;
            Font font = new Font("Arial", 10, FontStyle.Bold);

            graphics.DrawLine(new Pen(Color.FromArgb(50, 0, 0, 0)), new Point(0, yPos - 5), new Point(1000, yPos - 5));
            lblLoading.Visible = true;
            foreach (Player p in await repo.getPlayersForCountry(selectedTeam is null ? "ENG" : selectedTeam.FifaCode))
            {
                graphics.DrawString($"{p.Name} ({p.ShirtNumber})", font, Brushes.Black, new PointF(10, yPos));
                graphics.DrawString($"Goals: {p}", font, Brushes.Black, new PointF(250, yPos));
                graphics.DrawString($"Yellow Cards: {p}", font, Brushes.Black, new PointF(325, yPos));
                graphics.DrawString($"Appearances: {p}", font, Brushes.Black, new PointF(450, yPos));

                graphics.DrawLine(new Pen(Color.FromArgb(50, 0, 0, 0)), new Point(0, yPos + 20), new Point(1000, yPos + 20));

                yPos += 30;
            }
            lblLoading.Visible = false;

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new();
            Hide();
            settings.Show();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

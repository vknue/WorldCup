using System.Windows.Forms;

namespace Forms
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTeam = new Label();
            cbTeams = new ComboBox();
            btnSeatAsFavourite = new Button();
            pnlPlayers = new FlowLayoutPanel();
            pnlFavouritePlayers = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            rankingsToolStripMenuItem = new ToolStripMenuItem();
            visitorsRankingsToolStripMenuItem = new ToolStripMenuItem();
            playerRankingsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            lblLoading = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTeam
            // 
            lbTeam.AutoSize = true;
            lbTeam.Location = new Point(12, 42);
            lbTeam.Name = "lbTeam";
            lbTeam.Size = new Size(35, 15);
            lbTeam.TabIndex = 0;
            lbTeam.Text = "Team";
            // 
            // cbTeams
            // 
            cbTeams.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTeams.FormattingEnabled = true;
            cbTeams.Location = new Point(53, 39);
            cbTeams.Name = "cbTeams";
            cbTeams.Size = new Size(121, 23);
            cbTeams.TabIndex = 1;
            cbTeams.SelectedIndexChanged += cbTeams_SelectedIndexChanged;
            // 
            // btnSeatAsFavourite
            // 
            btnSeatAsFavourite.Location = new Point(12, 393);
            btnSeatAsFavourite.Name = "btnSeatAsFavourite";
            btnSeatAsFavourite.Size = new Size(162, 23);
            btnSeatAsFavourite.TabIndex = 3;
            btnSeatAsFavourite.Text = "Set as favourite";
            btnSeatAsFavourite.UseVisualStyleBackColor = true;
            btnSeatAsFavourite.Click += btnSeatAsFavourite_Click;
            // 
            // pnlPlayers
            // 
            pnlPlayers.AllowDrop = true;
            pnlPlayers.AutoScroll = true;
            pnlPlayers.BackColor = SystemColors.HighlightText;
            pnlPlayers.FlowDirection = FlowDirection.TopDown;
            pnlPlayers.Location = new Point(222, 28);
            pnlPlayers.Name = "pnlPlayers";
            pnlPlayers.Size = new Size(364, 388);
            pnlPlayers.TabIndex = 6;
            pnlPlayers.WrapContents = false;
            pnlPlayers.DragDrop += pnlPlayers_DragDrop;
            pnlPlayers.DragEnter += pnlPlayers_DragEnter;
            // 
            // pnlFavouritePlayers
            // 
            pnlFavouritePlayers.AllowDrop = true;
            pnlFavouritePlayers.AutoScroll = true;
            pnlFavouritePlayers.BackColor = SystemColors.HighlightText;
            pnlFavouritePlayers.FlowDirection = FlowDirection.TopDown;
            pnlFavouritePlayers.Location = new Point(615, 28);
            pnlFavouritePlayers.Name = "pnlFavouritePlayers";
            pnlFavouritePlayers.Size = new Size(364, 388);
            pnlFavouritePlayers.TabIndex = 7;
            pnlFavouritePlayers.WrapContents = false;
            pnlFavouritePlayers.DragDrop += pnlFavouritePlayers_DragDrop;
            pnlFavouritePlayers.DragEnter += pnlFavouritePlayers_DragEnter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { rankingsToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1087, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // rankingsToolStripMenuItem
            // 
            rankingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visitorsRankingsToolStripMenuItem, playerRankingsToolStripMenuItem });
            rankingsToolStripMenuItem.Name = "rankingsToolStripMenuItem";
            rankingsToolStripMenuItem.Size = new Size(67, 20);
            rankingsToolStripMenuItem.Text = "Rankings";
            // 
            // visitorsRankingsToolStripMenuItem
            // 
            visitorsRankingsToolStripMenuItem.Name = "visitorsRankingsToolStripMenuItem";
            visitorsRankingsToolStripMenuItem.Size = new Size(163, 22);
            visitorsRankingsToolStripMenuItem.Text = "Visitors Rankings";
            visitorsRankingsToolStripMenuItem.Click += visitorsRankingsToolStripMenuItem_Click;
            // 
            // playerRankingsToolStripMenuItem
            // 
            playerRankingsToolStripMenuItem.Name = "playerRankingsToolStripMenuItem";
            playerRankingsToolStripMenuItem.Size = new Size(163, 22);
            playerRankingsToolStripMenuItem.Text = "Player Rankings";
            playerRankingsToolStripMenuItem.Click += playerRankingsToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLoading.ForeColor = Color.LimeGreen;
            lblLoading.Location = new Point(27, 218);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(167, 27);
            lblLoading.TabIndex = 9;
            lblLoading.Text = "Loading . . .";
            lblLoading.Visible = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 535);
            Controls.Add(lblLoading);
            Controls.Add(pnlFavouritePlayers);
            Controls.Add(pnlPlayers);
            Controls.Add(btnSeatAsFavourite);
            Controls.Add(cbTeams);
            Controls.Add(lbTeam);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomeForm";
            Text = "Home";
            FormClosing += HomeForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTeam;
        private ComboBox cbTeams;
        private Button btnSeatAsFavourite;
        private FlowLayoutPanel pnlPlayers;
        private FlowLayoutPanel pnlFavouritePlayers;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem rankingsToolStripMenuItem;
        private ToolStripMenuItem visitorsRankingsToolStripMenuItem;
        private ToolStripMenuItem playerRankingsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Label lblLoading;
    }
}
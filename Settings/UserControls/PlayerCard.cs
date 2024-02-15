using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.UserControls
{
    public partial class PlayerCard : UserControl
    {
        private Player player;
        public PlayerCard(Player player)
        {
            InitializeComponent();
            this.player = player;
            lblName.Text = player.Name;
            lblCaptain.Visible = player.Captain;
            lblPosition.Text = player.Position.Substring(0, 2); 
            lblShirtNumber.Text = player.ShirtNumber.ToString();
            lblShirtNumber.ForeColor = Color.FromArgb(2, Color.Gold);

            checkIfFavourite();
            String imagePath = $"{Constants.IMAGES_FOLDER}{WebUtility.UrlEncode(player.ToString())}{Constants.IMAGES_EXTENSION}";

            if (File.Exists(imagePath))
            {
                try
                {
                    pbProfilePicture.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(imagePath)));
                }
                catch
                {
                    MessageBox.Show("File Error!");
                    return;
                }

            }
        }

        private void checkIfFavourite()
        {
            if (!Preferences.load().favouritePlayers.Contains(player))
            {
                this.BackgroundImage = null;
            }
        }

        private void PlayerCard_Load(object sender, EventArgs e)
        {

        }

        private void PlayerCard_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left)
            {
                DoDragDrop(this.player, DragDropEffects.Copy | DragDropEffects.Move);
            }


        }

        private void pbProfilePicture_Click(object sender, EventArgs e)
        {
            String imagePath = $"{Constants.IMAGES_FOLDER}{WebUtility.UrlEncode(player.ToString())}{Constants.IMAGES_EXTENSION}";
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = "c:\\";
                fileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;*";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = fileDialog.FileName;

                    File.Copy(filePath, imagePath,true);

                }
            }

            if (File.Exists(imagePath))
            {
                try
                {
                    pbProfilePicture.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(imagePath)));
                }
                catch
                {
                    MessageBox.Show("File Error!");
                    return;
                }

            }
        }
    }
}

using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for PlayerCard.xaml
    /// </summary>
    public partial class PlayerCard : UserControl
    {
        public PlayerCard(Player player)
        {
            InitializeComponent();
            lblName.Text = player.Name;
            lblNumber.Text = player.ShirtNumber.ToString();
            String imagePath = $"{Constants.IMAGES_FOLDER}{WebUtility.UrlEncode(player.ToString())}{Constants.IMAGES_EXTENSION}";

            if (File.Exists(imagePath))
            {
                try
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = new Uri(imagePath, UriKind.Absolute);
                    bitmapImage.EndInit();

                    imgPlayerImage.ImageSource = bitmapImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File Error: {ex.Message}");
                    return;
                }
            }
        }
    }
}

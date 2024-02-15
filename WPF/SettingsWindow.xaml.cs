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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
         
        public SettingsWindow(  )
        {
            InitializeComponent();
            Check();
            
        }

        private void Check()
        {
            DAL.Models.Settings settings = DAL.Models.Settings.load();
            if(settings.language == DAL.Models.Language.CRO) rbCRO.IsChecked = true;
            else rbENG.IsChecked = true;

            if (settings.windowMode == DAL.Models.WindowMode.XL) XL.IsChecked = true;
            else if (settings.windowMode == DAL.Models.WindowMode.L) L.IsChecked = true;
            else M.IsChecked = true;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to save these changes?", "Confirmation", MessageBoxButton.YesNoCancel);

            if (result == MessageBoxResult.Yes)
            {
                DAL.Models.Settings settings = DAL.Models.Settings.load();
                settings.language = rbENG.IsChecked==true ? DAL.Models.Language.ENG : DAL.Models.Language.CRO;
                if (XL.IsChecked == true) settings.windowMode = DAL.Models.WindowMode.XL;
                else if (L.IsChecked == true) settings.windowMode = DAL.Models.WindowMode.L;
                else if (M.IsChecked == true) settings.windowMode = DAL.Models.WindowMode.M;

                settings.save();
                new MainWindow().Show();
                Hide();
            }
            else if (result == MessageBoxResult.No)
            {
                return;
            }
        }
    }
}

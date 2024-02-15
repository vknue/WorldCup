using DAL.Models;
using Forms;

namespace Settings
{
    public partial class SettingsForm : Form
    {
        private static DAL.Models.Settings settings = DAL.Models.Settings.load();

        public SettingsForm()
        {
            InitializeComponent();
            InitCurrentPreferences();
        }

        private void InitCurrentPreferences()
        {
             rbFemale.Checked = settings.gender == Gender.WOMEN;
             rbCroatian.Checked = settings.language == Language.CRO;
             rbFile.Checked = settings.dataAccessMode == DataAccessMode.FILE;
             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(confirm() == DialogResult.Yes)) return;
            settings.gender = rbMale.Checked ? Gender.MEN : Gender.WOMEN ;

            settings.language = rbEnglish.Checked ? Language.ENG : Language.CRO ;

            settings.dataAccessMode = rbApi.Checked ? DataAccessMode.API : DataAccessMode.FILE ;

            settings.save();

            new HomeForm().Show();
            Dispose();

        }

        private DialogResult confirm() => 
            MessageBox.Show(
                "Do you want to proceed?"
                , "Confirmation"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
        
    }
}
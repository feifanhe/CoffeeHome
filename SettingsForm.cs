using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace CoffeeHome
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.WorkingCapitalTextBox.Text = ConfigurationManager.AppSettings["WorkingCapital"];
        }

        private void FormOKButton_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            app.Settings["WorkingCapital"].Value = this.WorkingCapitalTextBox.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            if (this.BackupFolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var SqlLocalDb = new ProcessStartInfo("sqllocaldb", "stop v11.0");
                    SqlLocalDb.WindowStyle = ProcessWindowStyle.Hidden;
                    using (var Stop = Process.Start(SqlLocalDb))
                        Stop.WaitForExit();

                    File.Copy("CoffeeHome.mdf", Path.Combine(this.BackupFolderBrowserDialog.SelectedPath, "CoffeeHome.mdf"));
                    File.Copy("CoffeeHome_log.ldf", Path.Combine(this.BackupFolderBrowserDialog.SelectedPath, "CoffeeHome_log.ldf"));

                    SqlLocalDb.Arguments = "start v11.0";
                    using (var Start = Process.Start(SqlLocalDb))
                        Start.WaitForExit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

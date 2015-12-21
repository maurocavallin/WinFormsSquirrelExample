using LemcubeLibrary;
using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LemcubeWinformProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBoxPathForUpdate.Text = @"C:\temp\t";

            this.Text = "Version:" + this.ProductVersion;
        }

        private async void toolStripButtonCheckForUpdates_Click(object sender, EventArgs e)
        {
            // NB: For this version, always say your app is using .NET 4.5, even if it's
            // totally not
            using (var mgr = new UpdateManager(textBoxPathForUpdate.Text))
            {
               var release = await mgr.UpdateApp();

               if (release != null)
               {
                   MessageBox.Show("New App Version Installed " + release.Version + " \n Close and reopen to load new version.");
               }
            }
        }

        private void buttonCallLibrary_Click(object sender, EventArgs e)
        {
            LibraryClass lc = new LibraryClass();
            try
            {
                string result = lc.GetDateTimeFromLibrary();
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             var dir = this.textBoxPathForUpdate.Text;

             if (!Directory.Exists(dir))
             {
                 MessageBox.Show("Directory does not exists");
                 return;
             }

             string releaseCatalogFullFilePath = Path.Combine(dir, "RELEASES");

             if (!File.Exists(releaseCatalogFullFilePath))
             {
                 MessageBox.Show("Updates catalog file does not exists " + releaseCatalogFullFilePath);
                 return;
             }

             MessageBox.Show("Updates directory is OK");
        }
    }
}

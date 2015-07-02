using LemcubeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemcubeWinformProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButtonCheckForUpdates_Click(object sender, EventArgs e)
        {

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
    }
}

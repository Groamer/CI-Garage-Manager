using CI_Garage_Manager_Server.Views;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CI_Garage_Manager_Server.Views
{
    public partial class ControlPanel : Form
    {
        private Information information;

        public ControlPanel()
        {
            information = new Information();

            InitializeComponent();
        }

        private void ShowInformation()
        {
            if(information.IsDisposed)
            {
                information = new Information();
            }

            if(Application.OpenForms[information.Name] == null)
            {
                information.Show();
            }
            else
            {
                Application.OpenForms[information.Name].Activate();

                if(information.WindowState == FormWindowState.Minimized)
                {
                    information.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInformation();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Environment.Exit(0);
        }

        private void computerInforToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.computerinfor.nl");
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInformation();
        }
    }
}

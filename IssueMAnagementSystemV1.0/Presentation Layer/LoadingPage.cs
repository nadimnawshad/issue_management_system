using IssueMAnagementSystemV1._0.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueMAnagementSystemV1._0.Presentation_Layer
{
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Load_timer.Start();
        }

        private void Load_timer_Tick(object sender, EventArgs e)
        {
            Loading_progressBar.Increment(1);
            Load_label.Text = "Loading..." + Loading_progressBar.Value.ToString() + "%";
            if (Loading_progressBar.Value == Loading_progressBar.Maximum)
            {
                Load_timer.Stop();
                LoginPage loginPage = new LoginPage();
                this.Hide();
                loginPage.Show();
            }
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {

        }

        private void LoadingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Loading_progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}

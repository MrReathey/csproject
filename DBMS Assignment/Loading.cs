using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Assignment
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        int progress;

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 30;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 1;
            loadingProgress.Value = progress;
            loadingLabel.Text = progress.ToString();
            if (loadingProgress.Value == 100)
            {
                loadingProgress.Value = 0;
                timer1.Stop();
                Login L1 = new Login();
                this.Hide();
                L1.ShowDialog();
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Assignment
{
    public partial class VendorForm : Form
    {
        public VendorForm()
        {
            InitializeComponent();
        }

        private void VendorForm_Load(object sender, EventArgs e)
        {
            cbAddress.Items.Add("ទីក្រុង ភ្នំពេញ");
            cbAddress.Items.Add("ខេត្ត សៀមរាប");
            cbAddress.Items.Add("​​ខេត្ត តាកែវ");
            cbAddress.Items.Add("ខេត្ត កំពង់​ចាម");
            cbAddress.Items.Add("ខេត្ត បាត់ដំបង");

        }
    }
}

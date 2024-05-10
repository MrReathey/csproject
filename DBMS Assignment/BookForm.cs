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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            cbSex.Items.Add("ប្រុស");
            cbSex.Items.Add("ស្រី");
            cbStatus.Items.Add("នៅលីវ");
            cbStatus.Items.Add("មានគ្រួសារ");
            cbFamily.Items.Add("គ្មាន");
            cbFamily.Items.Add("មានប្ដី");
            cbFamily.Items.Add("មានប្រពន្ធ");
            cbChild.Items.Add("គ្មាន");
            cbChild.Items.Add("១");
            cbChild.Items.Add("២");
            cbChild.Items.Add("៣");
            cbChild.Items.Add("៤");
            cbChild.Items.Add("៥");
            cbChild.Items.Add("៦");
            cbChild.Items.Add("៧");
            cbChild.Items.Add("៨");
            cbChild.Items.Add("៩");
            cbRole.Items.Add("លក់");
            cbRole.Items.Add("គិតលុយ");
            cbRole.Items.Add("អនាម័យ");
            cbRole.Items.Add("ដឹកជញ្ជូន");
            cbRole.Items.Add("រៀបចំសៀវភៅ");
           

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

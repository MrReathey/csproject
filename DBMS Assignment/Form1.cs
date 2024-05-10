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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnEmployee.BackColor = Color.Black;
            btnDashboard.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnAdjustment.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            Employee form = new Employee();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            pnBookshopSys.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            DashbordForm form = new DashbordForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            pnBookshopSys.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnEmployee.BackColor = Color.Teal;
            btnDashboard.BackColor = Color.Black;
            btnVendor.BackColor = Color.Teal;
            btnAdjustment.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            DashbordForm form = new DashbordForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            pnBookshopSys.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnEmployee.BackColor = Color.Teal;
            btnDashboard.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Black;
            btnAdjustment.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            VendorForm form = new VendorForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            pnBookshopSys.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            btnCustomer.BackColor = Color.Black;
            btnAdmin.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnEmployee.BackColor = Color.Teal;
            btnDashboard.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnAdjustment.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            CustomerForm form = new CustomerForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            pnBookshopSys.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void ptnSale_Click(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            
            btnPurchase.BackColor = Color.Teal;
            btnSale.BackColor = Color.Black;
            btnEmployee.BackColor = Color.Teal;
            btnDashboard.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnAdjustment.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
            SaleForm form = new SaleForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            pnBookshopSys.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
           
            btnPurchase.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnEmployee.BackColor = Color.Teal;
            btnDashboard.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnAdjustment.BackColor = Color.Teal;
            btnItem.BackColor = Color.Black;
            ItemForm form = new ItemForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            pnBookshopSys.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnAdjustment_Click(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnEmployee.BackColor = Color.Teal;
            btnDashboard.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnAdjustment.BackColor = Color.Black;
            btnItem.BackColor = Color.Teal;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.Black;
            btnCustomer.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Teal;
            btnSale.BackColor = Color.Teal;
            btnEmployee.BackColor = Color.Teal;
            btnDashboard.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnAdjustment.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnCustomer.BackColor = Color.Teal;
            btnPurchase.BackColor = Color.Black; ;
            btnSale.BackColor = Color.Teal;
            btnEmployee.BackColor = Color.Teal;
            btnDashboard.BackColor = Color.Teal;
            btnVendor.BackColor = Color.Teal;
            btnAdjustment.BackColor = Color.Teal;
            btnItem.BackColor = Color.Teal;
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

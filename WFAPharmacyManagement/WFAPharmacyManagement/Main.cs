using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPharmacyManagement
{
    public partial class Main : Form
    {
        private Login L1 { get; set; }

        public Main()
        {
            InitializeComponent();
            panelSide.Height = btnEmployee.Height;
            panelSide.Top = btnEmployee.Top;
            employee1.BringToFront();
        }

        public Main(string str, Login l1) : this()
        {
            panelSide.Height = btnEmployee.Height;
            panelSide.Top = btnEmployee.Top;
            employee1.BringToFront();
            this.txtLoggedPerson.Text = str;
            this.L1 = l1;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnEmployee.Height;
            panelSide.Top = btnEmployee.Top;
            employee1.BringToFront();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnMedicine.Height;
            panelSide.Top = btnMedicine.Top;
            medicine1.BringToFront();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnHistory.Height;
            panelSide.Top = btnHistory.Top;
            history1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            L1.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


//saikat_baul..
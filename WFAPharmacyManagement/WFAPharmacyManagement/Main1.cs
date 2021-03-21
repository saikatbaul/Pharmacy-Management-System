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
    public partial class Main1 : Form
    {
        private Login L2 { get; set; }

        public Main1()
        {
            InitializeComponent();
            panelSide.Height = btnCart.Height;
            panelSide.Top = btnCart.Top;
            cart2.BringToFront();
        }

        public Main1(string str, Login l2) : this()
        {
            panelSide.Height = btnCart.Height;
            panelSide.Top = btnCart.Top;
            cart2.BringToFront();
            this.txtLoggedPerson.Text = str;
            this.L2 = l2;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            L2.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnCart.Height;
            panelSide.Top = btnCart.Top;
            cart2.BringToFront();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnHistory.Height;
            panelSide.Top = btnHistory.Top;
            history13.BringToFront();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnCart.Height;
            panelSide.Top = btnCart.Top;
            cart2.BringToFront();
        }

        public string StaffName
        {
            get
            {
                string staffName = txtLoggedPerson.Text;
                string[] str = staffName.Split('_');
                string newStaffName = str[1];
                return newStaffName;
            }
        }

        private void txtLoggedPerson_TextChanged(object sender, EventArgs e)
        {
            cart2.StaffName = StaffName;
            history13.StaffName = StaffName;
        }
    }
}


//saikat_baul..

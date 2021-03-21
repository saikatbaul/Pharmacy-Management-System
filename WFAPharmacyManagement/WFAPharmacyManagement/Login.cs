using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WFAPharmacyManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = @"select * from staff where staffId = '" + this.txtEmployeeId.Text + "' and password = '" + this.txtPassword.Text + "';";

            DataAccess da = new DataAccess();
            DataTable dt = da.ExecuteQueryTable(sql);

            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0]["type"].ToString() == "Officer")
                {
                    Main m = new Main(("Welcome_" + dt.Rows[0]["staffName"].ToString()), this);
                    m.Show();
                    this.Hide();
                }

                else if(dt.Rows[0]["type"].ToString() == "Staff")
                {
                    Main1 m1 = new Main1(("Welcome_" + dt.Rows[0]["staffName"].ToString()), this);
                    m1.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Login Invalid..");
            };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


//saikat_baul..
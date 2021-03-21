using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPharmacyManagement
{
    public partial class History1 : UserControl
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        private string Sql { get; set; }

        public string StaffName
        {
            set { txtLoggedIn.Text = value; }
        }

        public History1()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView()
        {
            string Sql = "select * from history where staffName = '" + txtLoggedIn.Text + "';";
            this.Ds = this.Da.ExecuteQuery(Sql);
            this.dgvStaffHistory.AutoGenerateColumns = false;
            this.dgvStaffHistory.DataSource = this.Ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
    }
}


//md_ratan_rana..

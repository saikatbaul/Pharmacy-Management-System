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
    public partial class History : UserControl
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        private string Sql { get; set; }

        public History()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string Sql = "select * from history;")
        {
            this.Ds = this.Da.ExecuteQuery(Sql);
            this.dgvHistory.AutoGenerateColumns = false;
            this.dgvHistory.DataSource = this.Ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from history where staffName like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.txtSearch.Clear();
        }
    }
}


//sakimul_karim_adan..

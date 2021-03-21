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
    public partial class Employee : UserControl
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        private string Sql { get; set; }

        public Employee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.GenerateEmployeeId();
        }

        private void PopulateGridView(string Sql = "select * from staff;")
        {
            this.Ds = this.Da.ExecuteQuery(Sql);
            this.dgvStaff.AutoGenerateColumns = false;
            this.dgvStaff.DataSource = this.Ds.Tables[0];
        }

        private void GenerateEmployeeId()
        {
            this.Sql = "select * from staff order by staffId desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            string staffId = Dt.Rows[0]["staffId"].ToString();
            string[] str = staffId.Split('S');
            int n = Convert.ToInt32(str[1]);
            string newStaffId = "S" + (++n).ToString("d3");
            this.txtStaffId.Text = newStaffId;
        }

        private void ClearAll()
        {
            this.txtStaffId.Clear();
            this.txtStaffName.Clear();
            this.txtPassword.Clear();
            this.txtMobile.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.cmbType.SelectedIndex = -1;
            this.txtSearch.Clear();
            this.GenerateEmployeeId();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.txtSearch.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from staff where staffId = '" + this.txtStaffId.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update staff
                        set staffName = '" + this.txtStaffName.Text + @"',
                        password = '" + this.txtPassword.Text + @"',
                        mobile = '" + this.txtMobile.Text + @"',
                        type = '" + this.cmbType.Text + @"',
                        gender = '" + this.cmbGender.Text + @"'
                        where staffId = '" + this.txtStaffId.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Staff information updated..");
                    }
                    else
                    {
                        MessageBox.Show("Information update failed..");
                    }
                }
                else
                {
                    this.Sql = @"insert into staff
                    values ('" + this.txtStaffId.Text + "', '" + this.txtStaffName.Text + "','" + this.txtPassword.Text + "','" + this.txtMobile.Text + "', '" + this.cmbType.Text + "', '" + this.cmbGender.Text + "');";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("New staff information added..");
                    }
                    else
                    {
                        MessageBox.Show("New staff information insertion failed..");
                    }
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during the process\n\n" + exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string staffId = this.dgvStaff.CurrentRow.Cells["staffId"].Value.ToString();
                string staffName = this.dgvStaff.CurrentRow.Cells["staffName"].Value.ToString();

                this.Sql = @"delete from staff
                        where staffId = '" + staffId + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(staffName + " has been deleted..");
                }
                else
                {
                    MessageBox.Show("Staff information deletion failed..");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from staff where staffName like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void dgvStaff_DoubleClick(object sender, EventArgs e)
        {
            this.txtStaffId.Text = this.dgvStaff.CurrentRow.Cells["staffId"].Value.ToString();
            this.txtStaffName.Text = this.dgvStaff.CurrentRow.Cells["staffName"].Value.ToString();
            this.txtPassword.Text = this.dgvStaff.CurrentRow.Cells["password"].Value.ToString();
            this.txtMobile.Text = this.dgvStaff.CurrentRow.Cells["mobile"].Value.ToString();
            this.cmbType.Text = this.dgvStaff.CurrentRow.Cells["type"].Value.ToString();
            this.cmbGender.Text = this.dgvStaff.CurrentRow.Cells["gender"].Value.ToString();
        }
    }
}


//sakimul_karim_adan..

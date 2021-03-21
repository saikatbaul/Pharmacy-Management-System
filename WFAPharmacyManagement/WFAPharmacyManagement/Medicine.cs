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
    public partial class Medicine : UserControl
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        private string Sql { get; set; }

        public Medicine()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.GenerateMedicineId();
        }

        private void PopulateGridView(string Sql = "select * from medicine;")
        {
            this.Ds = this.Da.ExecuteQuery(Sql);
            this.dgvMedicine.AutoGenerateColumns = false;
            this.dgvMedicine.DataSource = this.Ds.Tables[0];
        }

        private void GenerateMedicineId()
        {
            this.Sql = "select * from medicine order by medicineId desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            string medicineId = Dt.Rows[0]["medicineId"].ToString();
            string[] str = medicineId.Split('M');
            int n = Convert.ToInt32(str[1]);
            string newMedicineId = "M" + (++n).ToString("d4");
            this.txtMedicineId.Text = newMedicineId;
        }

        private void ClearAll()
        {
            this.txtMedicineId.Clear();
            this.txtMedicineName.Clear();
            this.txtPricePerPiece.Clear();
            this.txtSearch.Clear();
            this.GenerateMedicineId();
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
                this.Sql = "select * from medicine where medicineId = '" + this.txtMedicineId.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update medicine
                               set medicineName = '" + this.txtMedicineName.Text + @"',
                               pricePerPiece = " + this.txtPricePerPiece.Text + @"
                               where medicineId = '" + this.txtMedicineId.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Medicine information updated..");
                    }
                    else
                    {
                        MessageBox.Show("Medicine information update failed..");
                    }
                }
                else
                {
                    this.Sql = @"insert into medicine
                    values ('" + this.txtMedicineId.Text + "', '" + this.txtMedicineName.Text + "'," + this.txtPricePerPiece.Text + ");";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Medicine information added..");
                    }
                    else
                    {
                        MessageBox.Show("Medicine information insertion failed..");
                    }
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during saving the data\n\n" + exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string medicineId = this.dgvMedicine.CurrentRow.Cells["medicineId"].Value.ToString();
                string medicineName = this.dgvMedicine.CurrentRow.Cells["medicineName"].Value.ToString();

                this.Sql = @"delete from medicine where medicineId = '" + medicineId + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(medicineName + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Medicine information deletion failed");
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
            this.Sql = "select * from medicine where medicineName like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void dgvMedicine_DoubleClick(object sender, EventArgs e)
        {
            this.txtMedicineId.Text = this.dgvMedicine.CurrentRow.Cells["medicineId"].Value.ToString();
            this.txtMedicineName.Text = this.dgvMedicine.CurrentRow.Cells["medicineName"].Value.ToString();
            this.txtPricePerPiece.Text = this.dgvMedicine.CurrentRow.Cells["pricePerPiece"].Value.ToString();
        }
    }
}


//Md_ratan_rana..
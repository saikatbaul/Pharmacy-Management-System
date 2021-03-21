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
    public partial class Cart : UserControl
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        private string Sql { get; set; }

        public string StaffName
        {
            set { txtStaffName.Text = value; }
        }

        public Cart()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.GenerateOrderId();
        }

        private void PopulateGridView(string sql = "select * from medicine;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvMedicine.AutoGenerateColumns = false;
            this.dgvMedicine.DataSource = this.Ds.Tables[0];
        }

        private void PopulateGridView1(string sql = "select * from cart;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.DataSource = this.Ds.Tables[0];
        }

        private void ClearAll()
        {
            this.txtMedicineName.Clear();
            this.txtPricePerPiece.Clear();
            this.txtQuantity.Clear();
            this.txtTotalPrice.Clear();
            this.txtSearch.Clear();
            this.txtGrandTotal.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from medicine where medicineName like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.txtSearch.Clear();
        }

        private void dgvMedicine_DoubleClick(object sender, EventArgs e)
        {
            this.txtMedicineName.Text = this.dgvMedicine.CurrentRow.Cells["medicineName"].Value.ToString();
            this.txtPricePerPiece.Text = this.dgvMedicine.CurrentRow.Cells["pricePerPiece"].Value.ToString();
            this.txtQuantity.Text = "0";
            this.txtTotalPrice.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from cart where medicineName = '" + this.txtMedicineName.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update cart
                               set quantity = " + this.txtQuantity.Text + @",
                               totalPrice = " + this.txtTotalPrice.Text + @"
                               where medicineName = '" + this.txtMedicineName.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Medicine added in the Cart with updated information..");
                    }
                    else
                    {
                        MessageBox.Show("Update failed..");
                    }
                }
                else
                {
                    this.Sql = @"insert into cart
                    values ('" + this.txtMedicineName.Text + "'," + this.txtPricePerPiece.Text + "," + this.txtQuantity.Text + "," + this.txtTotalPrice.Text + ");";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Medicine added in the Cart..");
                    }
                    else
                    {
                        MessageBox.Show("Insertion failed..");
                    }
                }
                this.PopulateGridView1();
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
                string medicineName = this.dgvCart.CurrentRow.Cells[0].Value.ToString();

                this.Sql = @"delete from cart where medicineName = '" + medicineName + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(medicineName + " has been deleted from the cart..");
                }
                else
                {
                    MessageBox.Show("Deletion failed..");
                }
                this.PopulateGridView1();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n\n" + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnShowDetails1_Click(object sender, EventArgs e)
        {
            this.PopulateGridView1();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            try
            {
                double pricePerPiece = Convert.ToDouble(this.txtPricePerPiece.Text);
                double quantity = Convert.ToDouble(this.txtQuantity.Text);
                double totalPrice = (pricePerPiece * quantity);
                string newTotalPrice = totalPrice.ToString();
                this.txtTotalPrice.Text = newTotalPrice;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during adding quantity\n\n" + exc.Message);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Sql = "delete from cart ;";
            this.Ds = this.Da.ExecuteQuery(this.Sql);
            this.PopulateGridView1();

            try
            {
                this.Sql = @"insert into history
                           values ('" + this.txtOrderId.Text + "','"+this.txtStaffName.Text+"','" + this.txtGrandTotal.Text + "');";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1) { }
                else
                {
                    MessageBox.Show("History data insertion failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during adding history data\n\n" + exc.Message);
            }
            this.GenerateOrderId();
        }

        private void GenerateOrderId()
        {
            this.Sql = "select * from history order by orderId desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            string orderId = Dt.Rows[0]["orderId"].ToString();
            string[] str = orderId.Split('O');
            int n = Convert.ToInt32(str[1]);
            string newOrderId = "O" + (++n).ToString("d4");
            this.txtOrderId.Text = newOrderId;
        }

        private void dgvCart_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal total = 0;
                int m = 0;
                while (m < dgvCart.Rows.Count)
                {
                    total += Convert.ToDecimal(dgvCart.Rows[m].Cells[3].Value);
                    m++;
                }
                this.txtGrandTotal.Text = total.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during calculating grand total\n\n" + exc.Message);
            }
        }
    }
}


//saikat_baul..
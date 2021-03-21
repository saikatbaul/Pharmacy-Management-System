using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace WFAPharmacyManagement
{
    class DataAccess
    {
        private SqlConnection sqlcon;
        private SqlCommand sqlcom;
        private SqlDataAdapter sda;
        private DataSet ds;

        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=abc;Persist Security Info=True;User ID=sa;Password=saikat");
            this.Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return this.Ds;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return this.Ds.Tables[0];
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public int ExecuteUpdateQuery(string sql)
        {
                this.QueryText(sql);
                int u = this.Sqlcom.ExecuteNonQuery();
                return u;
        }
    }
}
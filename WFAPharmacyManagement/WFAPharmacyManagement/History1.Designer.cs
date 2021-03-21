namespace WFAPharmacyManagement
{
    partial class History1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStaffHistory = new System.Windows.Forms.DataGridView();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoggedIn = new System.Windows.Forms.TextBox();
            this.txt00 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStaffHistory);
            this.panel1.Controls.Add(this.btnShowDetails);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 508);
            this.panel1.TabIndex = 42;
            // 
            // dgvStaffHistory
            // 
            this.dgvStaffHistory.AllowUserToAddRows = false;
            this.dgvStaffHistory.AllowUserToDeleteRows = false;
            this.dgvStaffHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.staffName,
            this.sales});
            this.dgvStaffHistory.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvStaffHistory.Location = new System.Drawing.Point(17, 60);
            this.dgvStaffHistory.Name = "dgvStaffHistory";
            this.dgvStaffHistory.ReadOnly = true;
            this.dgvStaffHistory.RowHeadersWidth = 51;
            this.dgvStaffHistory.RowTemplate.Height = 24;
            this.dgvStaffHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffHistory.Size = new System.Drawing.Size(743, 399);
            this.dgvStaffHistory.TabIndex = 38;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.ForeColor = System.Drawing.Color.Black;
            this.btnShowDetails.Location = new System.Drawing.Point(552, 22);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(208, 31);
            this.btnShowDetails.TabIndex = 24;
            this.btnShowDetails.Text = "Show Details >>";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // orderId
            // 
            this.orderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderId.DataPropertyName = "orderId";
            this.orderId.HeaderText = "Order ID";
            this.orderId.MinimumWidth = 6;
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // staffName
            // 
            this.staffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.staffName.DataPropertyName = "staffName";
            this.staffName.HeaderText = "Staff Name";
            this.staffName.MinimumWidth = 6;
            this.staffName.Name = "staffName";
            this.staffName.ReadOnly = true;
            // 
            // sales
            // 
            this.sales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sales.DataPropertyName = "sales";
            this.sales.HeaderText = "Sales";
            this.sales.MinimumWidth = 6;
            this.sales.Name = "sales";
            this.sales.ReadOnly = true;
            // 
            // txtLoggedIn
            // 
            this.txtLoggedIn.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtLoggedIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoggedIn.Enabled = false;
            this.txtLoggedIn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoggedIn.Location = new System.Drawing.Point(391, 470);
            this.txtLoggedIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoggedIn.Name = "txtLoggedIn";
            this.txtLoggedIn.Size = new System.Drawing.Size(372, 21);
            this.txtLoggedIn.TabIndex = 43;
            // 
            // txt00
            // 
            this.txt00.BackColor = System.Drawing.Color.PapayaWhip;
            this.txt00.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt00.Enabled = false;
            this.txt00.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt00.Location = new System.Drawing.Point(20, 470);
            this.txt00.Margin = new System.Windows.Forms.Padding(4);
            this.txt00.Name = "txt00";
            this.txt00.Size = new System.Drawing.Size(360, 21);
            this.txt00.TabIndex = 44;
            this.txt00.Text = "Order processed by";
            this.txt00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // History1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt00);
            this.Controls.Add(this.txtLoggedIn);
            this.Controls.Add(this.panel1);
            this.Name = "History1";
            this.Size = new System.Drawing.Size(780, 515);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStaffHistory;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales;
        private System.Windows.Forms.TextBox txtLoggedIn;
        private System.Windows.Forms.TextBox txt00;
    }
}

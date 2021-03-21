namespace WFAPharmacyManagement
{
    partial class Medicine
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.lblPricePerPiece = new System.Windows.Forms.Label();
            this.txtMedicineId = new System.Windows.Forms.TextBox();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtPricePerPiece = new System.Windows.Forms.TextBox();
            this.lblMedicineId = new System.Windows.Forms.Label();
            this.medicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.dgvMedicine);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.btnShowDetails);
            this.panel1.Controls.Add(this.lblMedicineName);
            this.panel1.Controls.Add(this.lblPricePerPiece);
            this.panel1.Controls.Add(this.txtMedicineId);
            this.panel1.Controls.Add(this.txtMedicineName);
            this.panel1.Controls.Add(this.txtPricePerPiece);
            this.panel1.Controls.Add(this.lblMedicineId);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 461);
            this.panel1.TabIndex = 40;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(180, 193);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 28);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(670, 63);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 60);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.AllowUserToAddRows = false;
            this.dgvMedicine.AllowUserToDeleteRows = false;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineId,
            this.medicineName,
            this.pricePerPiece});
            this.dgvMedicine.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvMedicine.Location = new System.Drawing.Point(17, 235);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            this.dgvMedicine.RowHeadersWidth = 51;
            this.dgvMedicine.RowTemplate.Height = 24;
            this.dgvMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicine.Size = new System.Drawing.Size(743, 211);
            this.dgvMedicine.TabIndex = 38;
            this.dgvMedicine.DoubleClick += new System.EventHandler(this.dgvMedicine_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(572, 63);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 60);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(474, 63);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 60);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(13, 197);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(66, 19);
            this.lblSearch.TabIndex = 34;
            this.lblSearch.Text = "Search";
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.ForeColor = System.Drawing.Color.Black;
            this.btnShowDetails.Location = new System.Drawing.Point(552, 197);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(208, 31);
            this.btnShowDetails.TabIndex = 24;
            this.btnShowDetails.Text = "Show Details >>";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineName.ForeColor = System.Drawing.Color.Black;
            this.lblMedicineName.Location = new System.Drawing.Point(13, 90);
            this.lblMedicineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(142, 19);
            this.lblMedicineName.TabIndex = 28;
            this.lblMedicineName.Text = "Medicine Name";
            // 
            // lblPricePerPiece
            // 
            this.lblPricePerPiece.AutoSize = true;
            this.lblPricePerPiece.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerPiece.ForeColor = System.Drawing.Color.Black;
            this.lblPricePerPiece.Location = new System.Drawing.Point(13, 130);
            this.lblPricePerPiece.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPricePerPiece.Name = "lblPricePerPiece";
            this.lblPricePerPiece.Size = new System.Drawing.Size(133, 19);
            this.lblPricePerPiece.TabIndex = 30;
            this.lblPricePerPiece.Text = "Price Per Piece";
            // 
            // txtMedicineId
            // 
            this.txtMedicineId.Enabled = false;
            this.txtMedicineId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineId.Location = new System.Drawing.Point(180, 54);
            this.txtMedicineId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineId.Name = "txtMedicineId";
            this.txtMedicineId.Size = new System.Drawing.Size(260, 28);
            this.txtMedicineId.TabIndex = 27;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.Location = new System.Drawing.Point(180, 90);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(260, 28);
            this.txtMedicineName.TabIndex = 29;
            // 
            // txtPricePerPiece
            // 
            this.txtPricePerPiece.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerPiece.Location = new System.Drawing.Point(180, 126);
            this.txtPricePerPiece.Margin = new System.Windows.Forms.Padding(4);
            this.txtPricePerPiece.Name = "txtPricePerPiece";
            this.txtPricePerPiece.Size = new System.Drawing.Size(260, 28);
            this.txtPricePerPiece.TabIndex = 31;
            // 
            // lblMedicineId
            // 
            this.lblMedicineId.AutoSize = true;
            this.lblMedicineId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineId.ForeColor = System.Drawing.Color.Black;
            this.lblMedicineId.Location = new System.Drawing.Point(13, 58);
            this.lblMedicineId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicineId.Name = "lblMedicineId";
            this.lblMedicineId.Size = new System.Drawing.Size(108, 19);
            this.lblMedicineId.TabIndex = 26;
            this.lblMedicineId.Text = "Medicine ID";
            // 
            // medicineId
            // 
            this.medicineId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medicineId.DataPropertyName = "medicineId";
            this.medicineId.HeaderText = "Medicine ID";
            this.medicineId.MinimumWidth = 6;
            this.medicineId.Name = "medicineId";
            this.medicineId.ReadOnly = true;
            // 
            // medicineName
            // 
            this.medicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medicineName.DataPropertyName = "medicineName";
            this.medicineName.HeaderText = "Medicine Name";
            this.medicineName.MinimumWidth = 6;
            this.medicineName.Name = "medicineName";
            this.medicineName.ReadOnly = true;
            // 
            // pricePerPiece
            // 
            this.pricePerPiece.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pricePerPiece.DataPropertyName = "pricePerPiece";
            this.pricePerPiece.HeaderText = "Price Per Piece";
            this.pricePerPiece.MinimumWidth = 6;
            this.pricePerPiece.Name = "pricePerPiece";
            this.pricePerPiece.ReadOnly = true;
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Medicine";
            this.Size = new System.Drawing.Size(780, 468);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.Label lblPricePerPiece;
        private System.Windows.Forms.TextBox txtMedicineId;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtPricePerPiece;
        private System.Windows.Forms.Label lblMedicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerPiece;
    }
}

namespace WFAPharmacyManagement
{
    partial class Cart
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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.btnCaculate = new System.Windows.Forms.Button();
            this.btnShowDetails1 = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.lblPricePerPiece = new System.Windows.Forms.Label();
            this.txtPricePerPiece = new System.Windows.Forms.TextBox();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.medicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblProcessedBy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProcessedBy);
            this.panel1.Controls.Add(this.txtStaffName);
            this.panel1.Controls.Add(this.lblOrderId);
            this.panel1.Controls.Add(this.txtOrderId);
            this.panel1.Controls.Add(this.btnCaculate);
            this.panel1.Controls.Add(this.btnShowDetails1);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.lblGrandTotal);
            this.panel1.Controls.Add(this.txtGrandTotal);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dgvCart);
            this.panel1.Controls.Add(this.lblTotalPrice);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.lblMedicineName);
            this.panel1.Controls.Add(this.lblPricePerPiece);
            this.panel1.Controls.Add(this.txtPricePerPiece);
            this.panel1.Controls.Add(this.txtMedicineName);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dgvMedicine);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.btnShowDetails);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 683);
            this.panel1.TabIndex = 42;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.ForeColor = System.Drawing.Color.Black;
            this.lblOrderId.Location = new System.Drawing.Point(13, 267);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(71, 19);
            this.lblOrderId.TabIndex = 57;
            this.lblOrderId.Text = "OrderId";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Location = new System.Drawing.Point(175, 263);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(260, 28);
            this.txtOrderId.TabIndex = 56;
            // 
            // btnCaculate
            // 
            this.btnCaculate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaculate.ForeColor = System.Drawing.Color.Black;
            this.btnCaculate.Location = new System.Drawing.Point(443, 405);
            this.btnCaculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaculate.Name = "btnCaculate";
            this.btnCaculate.Size = new System.Drawing.Size(87, 30);
            this.btnCaculate.TabIndex = 55;
            this.btnCaculate.Text = "Caculate";
            this.btnCaculate.UseVisualStyleBackColor = true;
            this.btnCaculate.Click += new System.EventHandler(this.btnCaculate_Click);
            // 
            // btnShowDetails1
            // 
            this.btnShowDetails1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails1.ForeColor = System.Drawing.Color.Black;
            this.btnShowDetails1.Location = new System.Drawing.Point(552, 404);
            this.btnShowDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDetails1.Name = "btnShowDetails1";
            this.btnShowDetails1.Size = new System.Drawing.Size(208, 31);
            this.btnShowDetails1.TabIndex = 54;
            this.btnShowDetails1.Text = "Show Details >>";
            this.btnShowDetails1.UseVisualStyleBackColor = true;
            this.btnShowDetails1.Click += new System.EventHandler(this.btnShowDetails1_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(627, 632);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 40);
            this.btnConfirm.TabIndex = 53;
            this.btnConfirm.Text = "Confrim";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.lblGrandTotal.Location = new System.Drawing.Point(13, 644);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(102, 19);
            this.lblGrandTotal.TabIndex = 52;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(166, 640);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(260, 28);
            this.txtGrandTotal.TabIndex = 51;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(670, 268);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 60);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(572, 268);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 60);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(474, 268);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 60);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1});
            this.dgvCart.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvCart.Location = new System.Drawing.Point(17, 442);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(743, 183);
            this.dgvCart.TabIndex = 47;
            this.dgvCart.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellEnter);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "medicineName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Medicine Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "pricePerPiece";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price Per Piece";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "totalPrice";
            this.dataGridViewTextBoxColumn1.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(13, 411);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(92, 19);
            this.lblTotalPrice.TabIndex = 46;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(13, 375);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 19);
            this.lblQuantity.TabIndex = 45;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineName.ForeColor = System.Drawing.Color.Black;
            this.lblMedicineName.Location = new System.Drawing.Point(13, 303);
            this.lblMedicineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(142, 19);
            this.lblMedicineName.TabIndex = 44;
            this.lblMedicineName.Text = "Medicine Name";
            // 
            // lblPricePerPiece
            // 
            this.lblPricePerPiece.AutoSize = true;
            this.lblPricePerPiece.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerPiece.ForeColor = System.Drawing.Color.Black;
            this.lblPricePerPiece.Location = new System.Drawing.Point(13, 339);
            this.lblPricePerPiece.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPricePerPiece.Name = "lblPricePerPiece";
            this.lblPricePerPiece.Size = new System.Drawing.Size(133, 19);
            this.lblPricePerPiece.TabIndex = 43;
            this.lblPricePerPiece.Text = "Price Per Piece";
            // 
            // txtPricePerPiece
            // 
            this.txtPricePerPiece.Enabled = false;
            this.txtPricePerPiece.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerPiece.Location = new System.Drawing.Point(175, 335);
            this.txtPricePerPiece.Margin = new System.Windows.Forms.Padding(4);
            this.txtPricePerPiece.Name = "txtPricePerPiece";
            this.txtPricePerPiece.Size = new System.Drawing.Size(260, 28);
            this.txtPricePerPiece.TabIndex = 42;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Enabled = false;
            this.txtMedicineName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.Location = new System.Drawing.Point(175, 299);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(260, 28);
            this.txtMedicineName.TabIndex = 41;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(175, 371);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(260, 28);
            this.txtQuantity.TabIndex = 40;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(175, 407);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(260, 28);
            this.txtTotalPrice.TabIndex = 39;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(98, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 28);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.dgvMedicine.Location = new System.Drawing.Point(17, 60);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            this.dgvMedicine.RowHeadersWidth = 51;
            this.dgvMedicine.RowTemplate.Height = 24;
            this.dgvMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicine.Size = new System.Drawing.Size(743, 160);
            this.dgvMedicine.TabIndex = 38;
            this.dgvMedicine.DoubleClick += new System.EventHandler(this.dgvMedicine_DoubleClick);
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
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(13, 22);
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
            this.btnShowDetails.Location = new System.Drawing.Point(552, 22);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(208, 31);
            this.btnShowDetails.TabIndex = 24;
            this.btnShowDetails.Text = "Show Details >>";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // txtStaffName
            // 
            this.txtStaffName.Enabled = false;
            this.txtStaffName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(175, 227);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(260, 28);
            this.txtStaffName.TabIndex = 58;
            // 
            // lblProcessedBy
            // 
            this.lblProcessedBy.AutoSize = true;
            this.lblProcessedBy.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessedBy.ForeColor = System.Drawing.Color.Black;
            this.lblProcessedBy.Location = new System.Drawing.Point(13, 231);
            this.lblProcessedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcessedBy.Name = "lblProcessedBy";
            this.lblProcessedBy.Size = new System.Drawing.Size(120, 19);
            this.lblProcessedBy.TabIndex = 59;
            this.lblProcessedBy.Text = "Processed By";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(782, 690);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.Label lblPricePerPiece;
        private System.Windows.Forms.TextBox txtPricePerPiece;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnShowDetails1;
        private System.Windows.Forms.Button btnCaculate;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerPiece;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblProcessedBy;
    }
}

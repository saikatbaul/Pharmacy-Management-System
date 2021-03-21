namespace WFAPharmacyManagement
{
    partial class Main1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLoggedPerson = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStaff = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.cart1 = new WFAPharmacyManagement.Cart();
            this.history12 = new WFAPharmacyManagement.History1();
            this.history11 = new WFAPharmacyManagement.History1();
            this.cart2 = new WFAPharmacyManagement.Cart();
            this.history13 = new WFAPharmacyManagement.History1();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.txtLoggedPerson);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 52);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnLogout.Location = new System.Drawing.Point(537, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 33);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnExit.Location = new System.Drawing.Point(683, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLoggedPerson
            // 
            this.txtLoggedPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtLoggedPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoggedPerson.Enabled = false;
            this.txtLoggedPerson.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoggedPerson.ForeColor = System.Drawing.Color.PapayaWhip;
            this.txtLoggedPerson.Location = new System.Drawing.Point(16, 15);
            this.txtLoggedPerson.Name = "txtLoggedPerson";
            this.txtLoggedPerson.Size = new System.Drawing.Size(351, 21);
            this.txtLoggedPerson.TabIndex = 2;
            this.txtLoggedPerson.TextChanged += new System.EventHandler(this.txtLoggedPerson_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.panelSide);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 747);
            this.panel1.TabIndex = 2;
            // 
            // btnStaff
            // 
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.Location = new System.Drawing.Point(0, 0);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(275, 148);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelSide.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSide.Location = new System.Drawing.Point(0, 171);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 156);
            this.panelSide.TabIndex = 2;
            // 
            // btnHistory
            // 
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(12, 333);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(260, 156);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "        History";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnCart
            // 
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(12, 171);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(260, 156);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "  Order Cart";
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // cart1
            // 
            this.cart1.Location = new System.Drawing.Point(304, 53);
            this.cart1.Name = "cart1";
            this.cart1.Size = new System.Drawing.Size(782, 682);
            this.cart1.TabIndex = 9;
            // 
            // history12
            // 
            this.history12.Location = new System.Drawing.Point(304, 73);
            this.history12.Name = "history12";
            this.history12.Size = new System.Drawing.Size(780, 662);
            this.history12.TabIndex = 8;
            // 
            // history11
            // 
            this.history11.Location = new System.Drawing.Point(303, 85);
            this.history11.Name = "history11";
            this.history11.Size = new System.Drawing.Size(780, 609);
            this.history11.TabIndex = 6;
            // 
            // cart2
            // 
            this.cart2.Location = new System.Drawing.Point(304, 57);
            this.cart2.Name = "cart2";
            this.cart2.Size = new System.Drawing.Size(782, 678);
            this.cart2.TabIndex = 6;
            // 
            // history13
            // 
            this.history13.Location = new System.Drawing.Point(304, 72);
            this.history13.Name = "history13";
            this.history13.Size = new System.Drawing.Size(780, 663);
            this.history13.TabIndex = 6;
            // 
            // Main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1110, 747);
            this.Controls.Add(this.history13);
            this.Controls.Add(this.cart2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtLoggedPerson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnCart;
        private History1 history11;
        private History1 history12;
        private Cart cart1;
        private Cart cart2;
        private History1 history13;
    }
}
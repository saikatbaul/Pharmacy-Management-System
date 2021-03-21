namespace WFAPharmacyManagement
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnOfficer = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLoggedPerson = new System.Windows.Forms.TextBox();
            this.medicine1 = new WFAPharmacyManagement.Medicine();
            this.history1 = new WFAPharmacyManagement.History();
            this.employee1 = new WFAPharmacyManagement.Employee();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.btnOfficer);
            this.panel1.Controls.Add(this.panelSide);
            this.panel1.Controls.Add(this.btnMedicine);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 706);
            this.panel1.TabIndex = 0;
            // 
            // btnHistory
            // 
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(12, 478);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(260, 156);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "      History";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnOfficer
            // 
            this.btnOfficer.FlatAppearance.BorderSize = 0;
            this.btnOfficer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfficer.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfficer.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnOfficer.Image = ((System.Drawing.Image)(resources.GetObject("btnOfficer.Image")));
            this.btnOfficer.Location = new System.Drawing.Point(0, 0);
            this.btnOfficer.Name = "btnOfficer";
            this.btnOfficer.Size = new System.Drawing.Size(275, 148);
            this.btnOfficer.TabIndex = 5;
            this.btnOfficer.Text = "Officer";
            this.btnOfficer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOfficer.UseVisualStyleBackColor = true;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelSide.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSide.Location = new System.Drawing.Point(0, 154);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 156);
            this.panelSide.TabIndex = 2;
            // 
            // btnMedicine
            // 
            this.btnMedicine.FlatAppearance.BorderSize = 0;
            this.btnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicine.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicine.Image")));
            this.btnMedicine.Location = new System.Drawing.Point(12, 316);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(260, 156);
            this.btnMedicine.TabIndex = 4;
            this.btnMedicine.Text = "  Medicine";
            this.btnMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicine.UseVisualStyleBackColor = true;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.Location = new System.Drawing.Point(12, 154);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(260, 156);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "  Employee";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
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
            this.panel2.TabIndex = 0;
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
            // 
            // medicine1
            // 
            this.medicine1.Location = new System.Drawing.Point(306, 77);
            this.medicine1.Name = "medicine1";
            this.medicine1.Size = new System.Drawing.Size(792, 557);
            this.medicine1.TabIndex = 9;
            // 
            // history1
            // 
            this.history1.Location = new System.Drawing.Point(306, 77);
            this.history1.Name = "history1";
            this.history1.Size = new System.Drawing.Size(780, 606);
            this.history1.TabIndex = 7;
            // 
            // employee1
            // 
            this.employee1.Location = new System.Drawing.Point(301, 88);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(797, 527);
            this.employee1.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1110, 706);
            this.Controls.Add(this.employee1);
            this.Controls.Add(this.history1);
            this.Controls.Add(this.medicine1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLoggedPerson;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private Medicine medicine1;
        private System.Windows.Forms.Button btnOfficer;
        private System.Windows.Forms.Button btnHistory;
        private History history1;
        private Employee employee1;
    }
}
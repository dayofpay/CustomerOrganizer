namespace CustomerOrganizer
{
    partial class Start
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
            this.customers = new Krypton.Toolkit.KryptonDataGridView();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getCustomers = new Krypton.Toolkit.KryptonButton();
            this.insertCustomers = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.customers)).BeginInit();
            this.SuspendLayout();
            // 
            // customers
            // 
            this.customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fName,
            this.sName,
            this.tName,
            this.pNum,
            this.fax,
            this.email,
            this.Address,
            this.Age,
            this.Sex});
            this.customers.HideOuterBorders = true;
            this.customers.Location = new System.Drawing.Point(12, 132);
            this.customers.Name = "customers";
            this.customers.PaletteMode = Krypton.Toolkit.PaletteMode.Office2013;
            this.customers.Size = new System.Drawing.Size(1018, 241);
            this.customers.TabIndex = 0;
            this.customers.Visible = false;
            // 
            // fName
            // 
            this.fName.HeaderText = "First Name";
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            // 
            // sName
            // 
            this.sName.HeaderText = "Second Name";
            this.sName.Name = "sName";
            this.sName.ReadOnly = true;
            // 
            // tName
            // 
            this.tName.HeaderText = "Third Name";
            this.tName.Name = "tName";
            this.tName.ReadOnly = true;
            // 
            // pNum
            // 
            this.pNum.HeaderText = "Phone Number";
            this.pNum.Name = "pNum";
            this.pNum.ReadOnly = true;
            // 
            // fax
            // 
            this.fax.HeaderText = "FAX";
            this.fax.Name = "fax";
            this.fax.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "E-Mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // getCustomers
            // 
            this.getCustomers.ButtonStyle = Krypton.Toolkit.ButtonStyle.Cluster;
            this.getCustomers.Location = new System.Drawing.Point(12, 12);
            this.getCustomers.Name = "getCustomers";
            this.getCustomers.Size = new System.Drawing.Size(112, 25);
            this.getCustomers.TabIndex = 1;
            this.getCustomers.Values.Text = "Get Customers";
            this.getCustomers.Click += new System.EventHandler(this.getCustomers_Click);
            // 
            // insertCustomers
            // 
            this.insertCustomers.ButtonStyle = Krypton.Toolkit.ButtonStyle.Cluster;
            this.insertCustomers.Location = new System.Drawing.Point(12, 43);
            this.insertCustomers.Name = "insertCustomers";
            this.insertCustomers.Size = new System.Drawing.Size(112, 25);
            this.insertCustomers.TabIndex = 2;
            this.insertCustomers.Values.Text = "Insert Customers";
            this.insertCustomers.Click += new System.EventHandler(this.insertCustomers_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(816, 418);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(202, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Developed by https://v-devs.online";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.insertCustomers);
            this.Controls.Add(this.getCustomers);
            this.Controls.Add(this.customers);
            this.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.FormCustom1;
            this.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormCustom3;
            this.HeaderStyle = Krypton.Toolkit.HeaderStyle.Custom3;
            this.Name = "Start";
            this.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Organizer | 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private Krypton.Toolkit.KryptonButton getCustomers;
        private Krypton.Toolkit.KryptonButton insertCustomers;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}


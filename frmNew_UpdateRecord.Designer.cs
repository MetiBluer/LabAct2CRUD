namespace DB_ACT1_046_Tolentino
{
    partial class frmNew_UpdateRecord
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(33, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(33, 57);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 13);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "MODEL";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(33, 120);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 13);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "YEAR";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(33, 90);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(45, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "BRAND";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(136, 113);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(136, 59);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 6;
            // 
            // cbBrand
            // 
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Items.AddRange(new object[] {
            "Volkswagen",
            "Chevrolet",
            "Mercedes-Benz",
            "Subaru",
            "Mitsubishi",
            "Dodge",
            "Buick",
            "Acura",
            "Honda",
            "Suzuki",
            "Shelby",
            "Hummer",
            "Nissan",
            "Saab",
            "Scion",
            "BMW",
            "Bentley",
            "Toyota",
            "Ford",
            "Kia",
            "Pontiac",
            "Plymouth",
            "Mazda",
            "Saturn",
            "Hyundai",
            "Jeep",
            "Audi",
            "GMC",
            "Mercury",
            "Lotus",
            "Lexus",
            "Ram",
            "Volvo",
            "Chrysler",
            "Geo",
            "Aston Martin",
            "Lincoln",
            "Oldsmobile",
            "Isuzu",
            "Infiniti",
            "Eagle",
            "Porsche",
            "Land Rover",
            "Cadillac",
            "Maserati",
            "Spyker"});
            this.cbBrand.Location = new System.Drawing.Point(136, 90);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(121, 21);
            this.cbBrand.TabIndex = 7;
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(36, 166);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(75, 23);
            this.btnIns.TabIndex = 8;
            this.btnIns.Text = "Insert";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(136, 166);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(75, 23);
            this.btnUpd.TabIndex = 9;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // frmNew_UpdateRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 279);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblId);
            this.Name = "frmNew_UpdateRecord";
            this.Text = "frmNew_UpdateRecord";
            this.Load += new System.EventHandler(this.frmNew_UpdateRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnUpd;
    }
}
namespace DB_ACT1_046_Tolentino
{
    partial class frmDeleteRecord
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
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cbBrand.Location = new System.Drawing.Point(160, 67);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(121, 21);
            this.cbBrand.TabIndex = 11;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(160, 36);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 10;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(57, 67);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(45, 13);
            this.lblBrand.TabIndex = 9;
            this.lblBrand.Text = "BRAND";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(57, 34);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 13);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "MODEL";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(71, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 277);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblModel);
            this.Name = "frmDeleteRecord";
            this.Text = "frmDeleteRecord";
            this.Load += new System.EventHandler(this.frmDeleteRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnDelete;
    }
}
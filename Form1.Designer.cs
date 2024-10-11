namespace DB_ACT1_046_Tolentino
{
    partial class Form1
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
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.grdResult = new System.Windows.Forms.DataGridView();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aDDORUPDATERECORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETERECORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(33, 31);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(100, 20);
            this.txtKeyword.TabIndex = 0;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(33, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(148, 71);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cboBrand
            // 
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Items.AddRange(new object[] {
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
            this.cboBrand.Location = new System.Drawing.Point(177, 31);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(88, 21);
            this.cboBrand.TabIndex = 3;
            // 
            // grdResult
            // 
            this.grdResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Location = new System.Drawing.Point(12, 137);
            this.grdResult.MultiSelect = false;
            this.grdResult.Name = "grdResult";
            this.grdResult.ReadOnly = true;
            this.grdResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResult.Size = new System.Drawing.Size(502, 203);
            this.grdResult.TabIndex = 4;
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDORUPDATERECORDToolStripMenuItem,
            this.dELETERECORDToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(565, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // aDDORUPDATERECORDToolStripMenuItem
            // 
            this.aDDORUPDATERECORDToolStripMenuItem.Name = "aDDORUPDATERECORDToolStripMenuItem";
            this.aDDORUPDATERECORDToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.aDDORUPDATERECORDToolStripMenuItem.Text = "ADD OR UPDATE RECORD";
            this.aDDORUPDATERECORDToolStripMenuItem.Click += new System.EventHandler(this.aDDORUPDATERECORDToolStripMenuItem_Click);
            // 
            // dELETERECORDToolStripMenuItem
            // 
            this.dELETERECORDToolStripMenuItem.Name = "dELETERECORDToolStripMenuItem";
            this.dELETERECORDToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.dELETERECORDToolStripMenuItem.Text = "DELETE RECORD";
            this.dELETERECORDToolStripMenuItem.Click += new System.EventHandler(this.dELETERECORDToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 442);
            this.Controls.Add(this.grdResult);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.DataGridView grdResult;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aDDORUPDATERECORDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETERECORDToolStripMenuItem;
    }
}


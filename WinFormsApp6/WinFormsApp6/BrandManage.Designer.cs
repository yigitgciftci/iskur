namespace WinFormsApp6
{
    partial class BrandManage
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
            this.lstBrand = new System.Windows.Forms.ListBox();
            this.btnEditBrand = new System.Windows.Forms.Button();
            this.btnDeleteBrand = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBrand
            // 
            this.lstBrand.FormattingEnabled = true;
            this.lstBrand.ItemHeight = 15;
            this.lstBrand.Location = new System.Drawing.Point(113, 58);
            this.lstBrand.Name = "lstBrand";
            this.lstBrand.Size = new System.Drawing.Size(324, 334);
            this.lstBrand.TabIndex = 9;
            this.lstBrand.SelectedIndexChanged += new System.EventHandler(this.lstBrand_SelectedIndexChanged);
            // 
            // btnEditBrand
            // 
            this.btnEditBrand.Location = new System.Drawing.Point(550, 236);
            this.btnEditBrand.Name = "btnEditBrand";
            this.btnEditBrand.Size = new System.Drawing.Size(75, 23);
            this.btnEditBrand.TabIndex = 6;
            this.btnEditBrand.Text = "Edit";
            this.btnEditBrand.UseVisualStyleBackColor = true;
            this.btnEditBrand.Click += new System.EventHandler(this.btnEditBrand_Click);
            // 
            // btnDeleteBrand
            // 
            this.btnDeleteBrand.Location = new System.Drawing.Point(613, 198);
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBrand.TabIndex = 7;
            this.btnDeleteBrand.Text = "Delete";
            this.btnDeleteBrand.UseVisualStyleBackColor = true;
            this.btnDeleteBrand.Click += new System.EventHandler(this.btnDeleteBrand_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(498, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "Brand Name";
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Location = new System.Drawing.Point(493, 198);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(75, 23);
            this.btnAddBrand.TabIndex = 8;
            this.btnAddBrand.Text = "Add";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(588, 146);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(100, 23);
            this.txtBrandName.TabIndex = 5;
            // 
            // BrandManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBrand);
            this.Controls.Add(this.btnEditBrand);
            this.Controls.Add(this.btnDeleteBrand);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.txtBrandName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BrandManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrandManage";
            this.Load += new System.EventHandler(this.BrandManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstBrand;
        private Button btnEditBrand;
        private Button btnDeleteBrand;
        private Label label15;
        private Button btnAddBrand;
        private TextBox txtBrandName;
    }
}
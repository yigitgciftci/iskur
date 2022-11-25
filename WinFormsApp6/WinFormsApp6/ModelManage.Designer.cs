namespace WinFormsApp6
{
    partial class ModelManage
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
            this.btnEditModel = new System.Windows.Forms.Button();
            this.btnDeleteModel = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lstModel = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEditModel
            // 
            this.btnEditModel.Location = new System.Drawing.Point(551, 261);
            this.btnEditModel.Name = "btnEditModel";
            this.btnEditModel.Size = new System.Drawing.Size(75, 23);
            this.btnEditModel.TabIndex = 13;
            this.btnEditModel.Text = "Edit";
            this.btnEditModel.UseVisualStyleBackColor = true;
            this.btnEditModel.Click += new System.EventHandler(this.btnEditModel_Click);
            // 
            // btnDeleteModel
            // 
            this.btnDeleteModel.Location = new System.Drawing.Point(618, 215);
            this.btnDeleteModel.Name = "btnDeleteModel";
            this.btnDeleteModel.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteModel.TabIndex = 14;
            this.btnDeleteModel.Text = "Delete";
            this.btnDeleteModel.UseVisualStyleBackColor = true;
            this.btnDeleteModel.Click += new System.EventHandler(this.btnDeleteModel_Click);
            // 
            // btnAddModel
            // 
            this.btnAddModel.Location = new System.Drawing.Point(484, 215);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(75, 23);
            this.btnAddModel.TabIndex = 15;
            this.btnAddModel.Text = "Add";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(577, 159);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(116, 23);
            this.txtModelName.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(486, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "Model Name";
            // 
            // lstModel
            // 
            this.lstModel.FormattingEnabled = true;
            this.lstModel.ItemHeight = 15;
            this.lstModel.Location = new System.Drawing.Point(108, 66);
            this.lstModel.Name = "lstModel";
            this.lstModel.Size = new System.Drawing.Size(310, 319);
            this.lstModel.TabIndex = 10;
            this.lstModel.SelectedIndexChanged += new System.EventHandler(this.lstModel_SelectedIndexChanged);
            // 
            // ModelManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditModel);
            this.Controls.Add(this.btnDeleteModel);
            this.Controls.Add(this.btnAddModel);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lstModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModelManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModelManage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEditModel;
        private Button btnDeleteModel;
        private Button btnAddModel;
        private TextBox txtModelName;
        private Label label16;
        private ListBox lstModel;
    }
}
namespace WinFormsGaleri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstAlbum = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveAlbum = new System.Windows.Forms.Button();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAlbum
            // 
            this.lstAlbum.FormattingEnabled = true;
            this.lstAlbum.ItemHeight = 15;
            this.lstAlbum.Location = new System.Drawing.Point(0, 28);
            this.lstAlbum.Name = "lstAlbum";
            this.lstAlbum.Size = new System.Drawing.Size(200, 274);
            this.lstAlbum.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(137, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddPicture);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.btnSaveAlbum);
            this.groupBox1.Controls.Add(this.btnExcelExport);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtAlbumName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(218, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 320);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Album Info and Pictures";
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(0, 197);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(171, 37);
            this.btnAddPicture.TabIndex = 2;
            this.btnAddPicture.Text = "Add Picture";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(183, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 236);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Location = new System.Drawing.Point(224, 270);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(171, 37);
            this.btnSaveAlbum.TabIndex = 2;
            this.btnSaveAlbum.Text = "Album Save";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(6, 270);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(171, 37);
            this.btnExcelExport.TabIndex = 2;
            this.btnExcelExport.Text = "Album Excel Export";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(0, 99);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(171, 92);
            this.txtDescription.TabIndex = 1;
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(0, 46);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(171, 23);
            this.txtAlbumName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAlbum);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 307);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Albums";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnRestart,
            this.btnClose});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnRestart
            // 
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(110, 22);
            this.btnRestart.Text = "Restart";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 22);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 383);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Album App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox lstAlbum;
        private Button btnDelete;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSaveAlbum;
        private Button btnExcelExport;
        private Button btnAddPicture;
        private TextBox txtDescription;
        private TextBox txtAlbumName;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem btnSave;
        private ToolStripMenuItem btnRestart;
        private ToolStripMenuItem btnClose;
    }
}
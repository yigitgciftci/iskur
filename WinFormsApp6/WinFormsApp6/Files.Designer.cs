namespace WinFormsApp6
{
    partial class Files
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Files));
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteRentList = new System.Windows.Forms.Button();
            this.dtpFinishDate = new System.Windows.Forms.DateTimePicker();
            this.lstRentalList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbModels = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.chkRent = new System.Windows.Forms.CheckBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbBrands = new System.Windows.Forms.ComboBox();
            this.nudDownPayment = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudRentalPrice = new System.Windows.Forms.NumericUpDown();
            this.txtIdentifyNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteBrandModel = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lstBrandModel = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-88, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vehicles";
            // 
            // btnDeleteRentList
            // 
            this.btnDeleteRentList.Location = new System.Drawing.Point(1184, 441);
            this.btnDeleteRentList.Name = "btnDeleteRentList";
            this.btnDeleteRentList.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRentList.TabIndex = 40;
            this.btnDeleteRentList.Text = "Delete";
            this.btnDeleteRentList.UseVisualStyleBackColor = true;
            this.btnDeleteRentList.Click += new System.EventHandler(this.btnDeleteRentList_Click);
            // 
            // dtpFinishDate
            // 
            this.dtpFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinishDate.Location = new System.Drawing.Point(658, 182);
            this.dtpFinishDate.Name = "dtpFinishDate";
            this.dtpFinishDate.Size = new System.Drawing.Size(165, 23);
            this.dtpFinishDate.TabIndex = 43;
            // 
            // lstRentalList
            // 
            this.lstRentalList.FormattingEnabled = true;
            this.lstRentalList.ItemHeight = 15;
            this.lstRentalList.Location = new System.Drawing.Point(843, 56);
            this.lstRentalList.Name = "lstRentalList";
            this.lstRentalList.Size = new System.Drawing.Size(416, 379);
            this.lstRentalList.TabIndex = 26;
            this.lstRentalList.SelectedIndexChanged += new System.EventHandler(this.lstRentalList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Vehicle Info";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(409, 142);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(121, 23);
            this.txtKm.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(843, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Rental List";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(409, 182);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 23);
            this.txtYear.TabIndex = 31;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(658, 142);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(165, 23);
            this.dtpStartDate.TabIndex = 42;
            // 
            // cmbModels
            // 
            this.cmbModels.FormattingEnabled = true;
            this.cmbModels.Location = new System.Drawing.Point(409, 100);
            this.cmbModels.Name = "cmbModels";
            this.cmbModels.Size = new System.Drawing.Size(121, 23);
            this.cmbModels.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Models";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Renter Info";
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.Location = new System.Drawing.Point(409, 420);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(121, 23);
            this.btnChoosePicture.TabIndex = 39;
            this.btnChoosePicture.Text = "Choose Picture";
            this.btnChoosePicture.UseVisualStyleBackColor = true;
            // 
            // chkRent
            // 
            this.chkRent.AutoSize = true;
            this.chkRent.Location = new System.Drawing.Point(409, 226);
            this.chkRent.Name = "chkRent";
            this.chkRent.Size = new System.Drawing.Size(118, 19);
            this.chkRent.TabIndex = 34;
            this.chkRent.Text = "Can it be rented ?";
            this.chkRent.UseVisualStyleBackColor = true;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(748, 260);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 38;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Person Full Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Brands";
            // 
            // cmbBrands
            // 
            this.cmbBrands.FormattingEnabled = true;
            this.cmbBrands.Location = new System.Drawing.Point(409, 56);
            this.cmbBrands.Name = "cmbBrands";
            this.cmbBrands.Size = new System.Drawing.Size(121, 23);
            this.cmbBrands.TabIndex = 29;
            // 
            // nudDownPayment
            // 
            this.nudDownPayment.Location = new System.Drawing.Point(658, 222);
            this.nudDownPayment.Name = "nudDownPayment";
            this.nudDownPayment.Size = new System.Drawing.Size(165, 23);
            this.nudDownPayment.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Identify Number";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(479, 449);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudRentalPrice
            // 
            this.nudRentalPrice.Location = new System.Drawing.Point(434, 258);
            this.nudRentalPrice.Name = "nudRentalPrice";
            this.nudRentalPrice.Size = new System.Drawing.Size(96, 23);
            this.nudRentalPrice.TabIndex = 35;
            // 
            // txtIdentifyNumber
            // 
            this.txtIdentifyNumber.Location = new System.Drawing.Point(658, 100);
            this.txtIdentifyNumber.Name = "txtIdentifyNumber";
            this.txtIdentifyNumber.Size = new System.Drawing.Size(165, 23);
            this.txtIdentifyNumber.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Start Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(331, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "KM";
            // 
            // btnDeleteBrandModel
            // 
            this.btnDeleteBrandModel.Location = new System.Drawing.Point(213, 441);
            this.btnDeleteBrandModel.Name = "btnDeleteBrandModel";
            this.btnDeleteBrandModel.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBrandModel.TabIndex = 27;
            this.btnDeleteBrandModel.Text = "Delete";
            this.btnDeleteBrandModel.UseVisualStyleBackColor = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(658, 56);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(165, 23);
            this.txtFullName.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Finish Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Year";
            // 
            // lstBrandModel
            // 
            this.lstBrandModel.FormattingEnabled = true;
            this.lstBrandModel.ItemHeight = 15;
            this.lstBrandModel.Location = new System.Drawing.Point(7, 56);
            this.lstBrandModel.Name = "lstBrandModel";
            this.lstBrandModel.Size = new System.Drawing.Size(281, 379);
            this.lstBrandModel.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(330, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Daily Rental Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Down Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinFormsApp6.Properties.Resources.image_128;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(409, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 44;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WinFormsApp6.Properties.Resources.file_16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WinFormsApp6.Properties.Resources.brand_16;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::WinFormsApp6.Properties.Resources.model_16;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 474);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteRentList);
            this.Controls.Add(this.dtpFinishDate);
            this.Controls.Add(this.lstRentalList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cmbModels);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChoosePicture);
            this.Controls.Add(this.chkRent);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbBrands);
            this.Controls.Add(this.nudDownPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudRentalPrice);
            this.Controls.Add(this.txtIdentifyNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDeleteBrandModel);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lstBrandModel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "File";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File";
            ((System.ComponentModel.ISupportInitialize)(this.nudDownPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Button btnDeleteRentList;
        private DateTimePicker dtpFinishDate;
        private ListBox lstRentalList;
        private Label label1;
        private TextBox txtKm;
        private Label label3;
        private TextBox txtYear;
        private DateTimePicker dtpStartDate;
        private ComboBox cmbModels;
        private Label label10;
        private Label label2;
        private Button btnChoosePicture;
        private CheckBox chkRent;
        private Button btnRent;
        private Label label5;
        private Label label12;
        private ComboBox cmbBrands;
        private NumericUpDown nudDownPayment;
        private Label label6;
        private Button btnAdd;
        private NumericUpDown nudRentalPrice;
        private TextBox txtIdentifyNumber;
        private Label label7;
        private Label label11;
        private Button btnDeleteBrandModel;
        private TextBox txtFullName;
        private Label label8;
        private Label label13;
        private ListBox lstBrandModel;
        private Label label14;
        private Label label9;
        private PictureBox pictureBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
    }
}
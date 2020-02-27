namespace OAHMS
{
    partial class frmResident_Card
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResident_Card));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Deceased = new System.Windows.Forms.TextBox();
            this.residentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oAHMSDataSet1 = new OAHMS.OAHMSDataSet1();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.txt_NOK = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.dtp_DLeft = new System.Windows.Forms.DateTimePicker();
            this.dtp_DEntered = new System.Windows.Forms.DateTimePicker();
            this.dtp_DOD = new System.Windows.Forms.DateTimePicker();
            this.txt_Disability = new System.Windows.Forms.TextBox();
            this.txt_PJob = new System.Windows.Forms.TextBox();
            this.txt_Hobbies = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.txt_Sex = new System.Windows.Forms.TextBox();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.txt_RNum = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_ncard = new System.Windows.Forms.Button();
            this.resident_DetailsTableAdapter = new OAHMS.OAHMSDataSet1TableAdapters.Resident_DetailsTableAdapter();
            this.btn_rcard = new System.Windows.Forms.Button();
            this.btn_rmcard = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.txt_Deceased);
            this.groupBox1.Controls.Add(this.txt_Notes);
            this.groupBox1.Controls.Add(this.txt_NOK);
            this.groupBox1.Controls.Add(this.txt_Status);
            this.groupBox1.Controls.Add(this.dtp_DLeft);
            this.groupBox1.Controls.Add(this.dtp_DEntered);
            this.groupBox1.Controls.Add(this.dtp_DOD);
            this.groupBox1.Controls.Add(this.txt_Disability);
            this.groupBox1.Controls.Add(this.txt_PJob);
            this.groupBox1.Controls.Add(this.txt_Hobbies);
            this.groupBox1.Controls.Add(this.dtp_DOB);
            this.groupBox1.Controls.Add(this.txt_Age);
            this.groupBox1.Controls.Add(this.txt_Sex);
            this.groupBox1.Controls.Add(this.txt_Type);
            this.groupBox1.Controls.Add(this.txt_RNum);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resident Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_Deceased
            // 
            this.txt_Deceased.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_Deceased", true));
            this.txt_Deceased.Location = new System.Drawing.Point(577, 39);
            this.txt_Deceased.Name = "txt_Deceased";
            this.txt_Deceased.Size = new System.Drawing.Size(100, 22);
            this.txt_Deceased.TabIndex = 13;
            // 
            // residentDetailsBindingSource
            // 
            this.residentDetailsBindingSource.DataMember = "Resident_Details";
            this.residentDetailsBindingSource.DataSource = this.oAHMSDataSet1;
            // 
            // oAHMSDataSet1
            // 
            this.oAHMSDataSet1.DataSetName = "OAHMSDataSet1";
            this.oAHMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_Notes
            // 
            this.txt_Notes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_Notes", true));
            this.txt_Notes.Location = new System.Drawing.Point(568, 211);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(155, 61);
            this.txt_Notes.TabIndex = 16;
            // 
            // txt_NOK
            // 
            this.txt_NOK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_NOK", true));
            this.txt_NOK.Location = new System.Drawing.Point(568, 168);
            this.txt_NOK.Name = "txt_NOK";
            this.txt_NOK.Size = new System.Drawing.Size(110, 22);
            this.txt_NOK.TabIndex = 15;
            // 
            // txt_Status
            // 
            this.txt_Status.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_Status", true));
            this.txt_Status.Location = new System.Drawing.Point(365, 218);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(114, 22);
            this.txt_Status.TabIndex = 12;
            // 
            // dtp_DLeft
            // 
            this.dtp_DLeft.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_LeftDate", true));
            this.dtp_DLeft.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DLeft.Location = new System.Drawing.Point(365, 190);
            this.dtp_DLeft.Name = "dtp_DLeft";
            this.dtp_DLeft.ShowCheckBox = true;
            this.dtp_DLeft.Size = new System.Drawing.Size(114, 22);
            this.dtp_DLeft.TabIndex = 11;
            this.dtp_DLeft.ValueChanged += new System.EventHandler(this.dateTimePicker5_ValueChanged);
            // 
            // dtp_DEntered
            // 
            this.dtp_DEntered.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_JoinDate", true));
            this.dtp_DEntered.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DEntered.Location = new System.Drawing.Point(365, 168);
            this.dtp_DEntered.Name = "dtp_DEntered";
            this.dtp_DEntered.ShowCheckBox = true;
            this.dtp_DEntered.Size = new System.Drawing.Size(114, 22);
            this.dtp_DEntered.TabIndex = 10;
            // 
            // dtp_DOD
            // 
            this.dtp_DOD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_DateOfDeath", true));
            this.dtp_DOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DOD.Location = new System.Drawing.Point(577, 69);
            this.dtp_DOD.Name = "dtp_DOD";
            this.dtp_DOD.ShowCheckBox = true;
            this.dtp_DOD.Size = new System.Drawing.Size(114, 22);
            this.dtp_DOD.TabIndex = 14;
            // 
            // txt_Disability
            // 
            this.txt_Disability.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_Disability", true));
            this.txt_Disability.Location = new System.Drawing.Point(311, 67);
            this.txt_Disability.Multiline = true;
            this.txt_Disability.Name = "txt_Disability";
            this.txt_Disability.Size = new System.Drawing.Size(161, 56);
            this.txt_Disability.TabIndex = 9;
            // 
            // txt_PJob
            // 
            this.txt_PJob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_PrevProf", true));
            this.txt_PJob.Location = new System.Drawing.Point(311, 39);
            this.txt_PJob.Name = "txt_PJob";
            this.txt_PJob.Size = new System.Drawing.Size(161, 22);
            this.txt_PJob.TabIndex = 8;
            // 
            // txt_Hobbies
            // 
            this.txt_Hobbies.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_Hobbies", true));
            this.txt_Hobbies.Location = new System.Drawing.Point(129, 253);
            this.txt_Hobbies.Multiline = true;
            this.txt_Hobbies.Name = "txt_Hobbies";
            this.txt_Hobbies.Size = new System.Drawing.Size(162, 40);
            this.txt_Hobbies.TabIndex = 7;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.residentDetailsBindingSource, "R_DateOfBirth", true));
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(129, 213);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.ShowCheckBox = true;
            this.dtp_DOB.Size = new System.Drawing.Size(113, 22);
            this.dtp_DOB.TabIndex = 6;
            // 
            // txt_Age
            // 
            this.txt_Age.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_Age", true));
            this.txt_Age.Location = new System.Drawing.Point(127, 177);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(100, 22);
            this.txt_Age.TabIndex = 5;
            // 
            // txt_Sex
            // 
            this.txt_Sex.AllowDrop = true;
            this.txt_Sex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_Sex", true));
            this.txt_Sex.Location = new System.Drawing.Point(127, 149);
            this.txt_Sex.Name = "txt_Sex";
            this.txt_Sex.Size = new System.Drawing.Size(100, 22);
            this.txt_Sex.TabIndex = 4;
            // 
            // txt_Type
            // 
            this.txt_Type.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "RM_Type", true));
            this.txt_Type.Location = new System.Drawing.Point(127, 121);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(100, 22);
            this.txt_Type.TabIndex = 3;
            // 
            // txt_RNum
            // 
            this.txt_RNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "RM_Number", true));
            this.txt_RNum.Location = new System.Drawing.Point(127, 95);
            this.txt_RNum.Name = "txt_RNum";
            this.txt_RNum.Size = new System.Drawing.Size(49, 22);
            this.txt_RNum.TabIndex = 2;
            // 
            // txt_Name
            // 
            this.txt_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_Name", true));
            this.txt_Name.Location = new System.Drawing.Point(127, 67);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(112, 22);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_ID
            // 
            this.txt_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentDetailsBindingSource, "R_Id", true));
            this.txt_ID.Location = new System.Drawing.Point(127, 37);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_ID.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Honeydew;
            this.label17.Location = new System.Drawing.Point(518, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "Notes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Honeydew;
            this.label16.Location = new System.Drawing.Point(295, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "Date Left";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Honeydew;
            this.label15.Location = new System.Drawing.Point(269, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Date Entered";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Honeydew;
            this.label14.Location = new System.Drawing.Point(492, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Next of Kin";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Honeydew;
            this.label13.Location = new System.Drawing.Point(481, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Date of Death";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Honeydew;
            this.label12.Location = new System.Drawing.Point(499, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Deceased";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Honeydew;
            this.label11.Location = new System.Drawing.Point(245, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Disability";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Honeydew;
            this.label10.Location = new System.Drawing.Point(245, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Prev Job";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(61, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hobbies";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Honeydew;
            this.label8.Location = new System.Drawing.Point(311, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(43, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(88, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(90, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(81, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(25, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(76, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resident ID";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(676, 379);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Previous";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(512, 379);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_ncard
            // 
            this.btn_ncard.Location = new System.Drawing.Point(39, 379);
            this.btn_ncard.Name = "btn_ncard";
            this.btn_ncard.Size = new System.Drawing.Size(77, 23);
            this.btn_ncard.TabIndex = 2;
            this.btn_ncard.Text = "NOK Card";
            this.btn_ncard.UseVisualStyleBackColor = true;
            this.btn_ncard.Click += new System.EventHandler(this.btn_ncard_Click);
            // 
            // resident_DetailsTableAdapter
            // 
            this.resident_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_rcard
            // 
            this.btn_rcard.Location = new System.Drawing.Point(122, 379);
            this.btn_rcard.Name = "btn_rcard";
            this.btn_rcard.Size = new System.Drawing.Size(100, 23);
            this.btn_rcard.TabIndex = 3;
            this.btn_rcard.Text = "Resident Card";
            this.btn_rcard.UseVisualStyleBackColor = true;
            this.btn_rcard.Click += new System.EventHandler(this.btn_rcard_Click);
            // 
            // btn_rmcard
            // 
            this.btn_rmcard.Location = new System.Drawing.Point(228, 379);
            this.btn_rmcard.Name = "btn_rmcard";
            this.btn_rmcard.Size = new System.Drawing.Size(100, 23);
            this.btn_rmcard.TabIndex = 4;
            this.btn_rmcard.Text = "Room Card";
            this.btn_rmcard.UseVisualStyleBackColor = true;
            this.btn_rmcard.Click += new System.EventHandler(this.btn_rmcard_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(596, 379);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // frmResident_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(826, 436);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_rmcard);
            this.Controls.Add(this.btn_rcard);
            this.Controls.Add(this.btn_ncard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResident_Card";
            this.Text = "Resident Details";
            this.Load += new System.EventHandler(this.frmResidents_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dtp_DLeft;
        private System.Windows.Forms.DateTimePicker dtp_DEntered;
        private System.Windows.Forms.DateTimePicker dtp_DOD;
        private System.Windows.Forms.TextBox txt_Disability;
        private System.Windows.Forms.TextBox txt_PJob;
        private System.Windows.Forms.TextBox txt_Hobbies;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.TextBox txt_Sex;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.TextBox txt_RNum;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.TextBox txt_NOK;
        private System.Windows.Forms.TextBox txt_Deceased;
        private System.Windows.Forms.Button btn_ncard;
        private OAHMSDataSet1 oAHMSDataSet1;
        private System.Windows.Forms.BindingSource residentDetailsBindingSource;
        private OAHMSDataSet1TableAdapters.Resident_DetailsTableAdapter resident_DetailsTableAdapter;
        private System.Windows.Forms.Button btn_rcard;
        private System.Windows.Forms.Button btn_rmcard;
        private System.Windows.Forms.Button btn_update;
    }
}
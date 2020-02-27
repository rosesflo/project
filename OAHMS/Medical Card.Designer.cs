namespace OAHMS
{
    partial class frmMedCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedCard));
            this.oAHMSDataSet9 = new OAHMS.OAHMSDataSet9();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_rid = new System.Windows.Forms.TextBox();
            this.txt_rname = new System.Windows.Forms.TextBox();
            this.medRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_physician = new System.Windows.Forms.TextBox();
            this.txt_mcond = new System.Windows.Forms.TextBox();
            this.txt_pcond = new System.Windows.Forms.TextBox();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.med_RecordsTableAdapter = new OAHMS.OAHMSDataSet9TableAdapters.Med_RecordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medRecordsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oAHMSDataSet9
            // 
            this.oAHMSDataSet9.DataSetName = "OAHMSDataSet9";
            this.oAHMSDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resident ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resident Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(62, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Physician";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(395, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(395, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(23, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Medical Condition";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(201, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Physical Condition";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Honeydew;
            this.label8.Location = new System.Drawing.Point(433, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Notes";
            // 
            // txt_rid
            // 
            this.txt_rid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oAHMSDataSet9, "Med_Records.R_Id", true));
            this.txt_rid.Location = new System.Drawing.Point(138, 36);
            this.txt_rid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rid.Name = "txt_rid";
            this.txt_rid.Size = new System.Drawing.Size(132, 22);
            this.txt_rid.TabIndex = 8;
            // 
            // txt_rname
            // 
            this.txt_rname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medRecordsBindingSource, "R_Name", true));
            this.txt_rname.Location = new System.Drawing.Point(138, 66);
            this.txt_rname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rname.Name = "txt_rname";
            this.txt_rname.Size = new System.Drawing.Size(193, 22);
            this.txt_rname.TabIndex = 9;
            // 
            // medRecordsBindingSource
            // 
            this.medRecordsBindingSource.DataMember = "Med_Records";
            this.medRecordsBindingSource.DataSource = this.oAHMSDataSet9;
            // 
            // txt_physician
            // 
            this.txt_physician.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medRecordsBindingSource, "Med_Physician", true));
            this.txt_physician.Location = new System.Drawing.Point(138, 95);
            this.txt_physician.Margin = new System.Windows.Forms.Padding(4);
            this.txt_physician.Name = "txt_physician";
            this.txt_physician.Size = new System.Drawing.Size(193, 22);
            this.txt_physician.TabIndex = 10;
            // 
            // txt_mcond
            // 
            this.txt_mcond.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medRecordsBindingSource, "M_Condition", true));
            this.txt_mcond.Location = new System.Drawing.Point(10, 157);
            this.txt_mcond.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mcond.Multiline = true;
            this.txt_mcond.Name = "txt_mcond";
            this.txt_mcond.Size = new System.Drawing.Size(169, 83);
            this.txt_mcond.TabIndex = 11;
            // 
            // txt_pcond
            // 
            this.txt_pcond.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medRecordsBindingSource, "P_Condition", true));
            this.txt_pcond.Location = new System.Drawing.Point(198, 157);
            this.txt_pcond.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pcond.Multiline = true;
            this.txt_pcond.Name = "txt_pcond";
            this.txt_pcond.Size = new System.Drawing.Size(187, 83);
            this.txt_pcond.TabIndex = 12;
            // 
            // txt_notes
            // 
            this.txt_notes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medRecordsBindingSource, "Notes", true));
            this.txt_notes.Location = new System.Drawing.Point(428, 157);
            this.txt_notes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(169, 82);
            this.txt_notes.TabIndex = 13;
            // 
            // dtp_date
            // 
            this.dtp_date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medRecordsBindingSource, "Date", true));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(450, 17);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.ShowCheckBox = true;
            this.dtp_date.Size = new System.Drawing.Size(122, 22);
            this.dtp_date.TabIndex = 14;
            // 
            // dtp_time
            // 
            this.dtp_time.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medRecordsBindingSource, "Time", true));
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_time.Location = new System.Drawing.Point(450, 47);
            this.dtp_time.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.Size = new System.Drawing.Size(122, 22);
            this.dtp_time.TabIndex = 15;
            this.dtp_time.ValueChanged += new System.EventHandler(this.dtp_time_ValueChanged);
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.BackColor = System.Drawing.Color.Honeydew;
            this.btn_mainMenu.Location = new System.Drawing.Point(518, 289);
            this.btn_mainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(114, 41);
            this.btn_mainMenu.TabIndex = 16;
            this.btn_mainMenu.Text = "Return to Main Menu";
            this.btn_mainMenu.UseVisualStyleBackColor = false;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Honeydew;
            this.btn_save.Location = new System.Drawing.Point(31, 298);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Add";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Honeydew;
            this.btn_update.Location = new System.Drawing.Point(112, 298);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Honeydew;
            this.btn_delete.Location = new System.Drawing.Point(193, 298);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Remove";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.dtp_time);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.txt_notes);
            this.groupBox1.Controls.Add(this.txt_pcond);
            this.groupBox1.Controls.Add(this.txt_mcond);
            this.groupBox1.Controls.Add(this.txt_physician);
            this.groupBox1.Controls.Add(this.txt_rname);
            this.groupBox1.Controls.Add(this.txt_rid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 263);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medical Records";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // med_RecordsTableAdapter
            // 
            this.med_RecordsTableAdapter.ClearBeforeFill = true;
            // 
            // frmMedCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(665, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_mainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMedCard";
            this.Text = "Medical Card";
            this.Load += new System.EventHandler(this.frmMedCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medRecordsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private OAHMSDataSet9 oAHMSDataSet9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_rid;
        private System.Windows.Forms.TextBox txt_rname;
        private System.Windows.Forms.TextBox txt_physician;
        private System.Windows.Forms.TextBox txt_mcond;
        private System.Windows.Forms.TextBox txt_pcond;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource medRecordsBindingSource;
        private OAHMSDataSet9TableAdapters.Med_RecordsTableAdapter med_RecordsTableAdapter;
    }
}
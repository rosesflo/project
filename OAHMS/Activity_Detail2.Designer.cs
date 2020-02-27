namespace OAHMS
{
    partial class frm_ActvDetail2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ActvDetail2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.txt_ResName = new System.Windows.Forms.TextBox();
            this.txt_ActName = new System.Windows.Forms.TextBox();
            this.txt_ActNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oAHMSDataSet13 = new OAHMS.OAHMSDataSet13();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aCTVNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTVNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTVDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oAHMSDataSet13BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCTV_DETAILSTableAdapter = new OAHMS.OAHMSDataSet13TableAdapters.ACTV_DETAILSTableAdapter();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTVDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet13BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.dtp_Time);
            this.groupBox1.Controls.Add(this.dtp_Date);
            this.groupBox1.Controls.Add(this.txt_Notes);
            this.groupBox1.Controls.Add(this.txt_ResName);
            this.groupBox1.Controls.Add(this.txt_ActName);
            this.groupBox1.Controls.Add(this.txt_ActNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity Details";
            // 
            // dtp_Time
            // 
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Time.Location = new System.Drawing.Point(186, 76);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(82, 20);
            this.dtp_Time.TabIndex = 13;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(49, 76);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.ShowCheckBox = true;
            this.dtp_Date.Size = new System.Drawing.Size(95, 20);
            this.dtp_Date.TabIndex = 12;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(511, 39);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(145, 52);
            this.txt_Notes.TabIndex = 11;
            // 
            // txt_ResName
            // 
            this.txt_ResName.Location = new System.Drawing.Point(299, 42);
            this.txt_ResName.Name = "txt_ResName";
            this.txt_ResName.Size = new System.Drawing.Size(159, 20);
            this.txt_ResName.TabIndex = 9;
            // 
            // txt_ActName
            // 
            this.txt_ActName.Location = new System.Drawing.Point(104, 42);
            this.txt_ActName.Name = "txt_ActName";
            this.txt_ActName.Size = new System.Drawing.Size(155, 20);
            this.txt_ActName.TabIndex = 7;
            // 
            // txt_ActNum
            // 
            this.txt_ActNum.Location = new System.Drawing.Point(16, 39);
            this.txt_ActNum.Name = "txt_ActNum";
            this.txt_ActNum.Size = new System.Drawing.Size(53, 20);
            this.txt_ActNum.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Notes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resident Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Activity Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activity Number";
            // 
            // oAHMSDataSet13
            // 
            this.oAHMSDataSet13.DataSetName = "OAHMSDataSet13";
            this.oAHMSDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aCTVNUMDataGridViewTextBoxColumn,
            this.aCTVNAMEDataGridViewTextBoxColumn,
            this.rNAMEDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn,
            this.tIMEDataGridViewTextBoxColumn,
            this.nOTESDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aCTVDETAILSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 117);
            this.dataGridView1.TabIndex = 1;
            // 
            // aCTVNUMDataGridViewTextBoxColumn
            // 
            this.aCTVNUMDataGridViewTextBoxColumn.DataPropertyName = "ACTV_NUM";
            this.aCTVNUMDataGridViewTextBoxColumn.HeaderText = "Activity Number";
            this.aCTVNUMDataGridViewTextBoxColumn.Name = "aCTVNUMDataGridViewTextBoxColumn";
            // 
            // aCTVNAMEDataGridViewTextBoxColumn
            // 
            this.aCTVNAMEDataGridViewTextBoxColumn.DataPropertyName = "ACTV_NAME";
            this.aCTVNAMEDataGridViewTextBoxColumn.HeaderText = "Activity Name";
            this.aCTVNAMEDataGridViewTextBoxColumn.Name = "aCTVNAMEDataGridViewTextBoxColumn";
            // 
            // rNAMEDataGridViewTextBoxColumn
            // 
            this.rNAMEDataGridViewTextBoxColumn.DataPropertyName = "R_NAME";
            this.rNAMEDataGridViewTextBoxColumn.HeaderText = "Resident Name";
            this.rNAMEDataGridViewTextBoxColumn.Name = "rNAMEDataGridViewTextBoxColumn";
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            // 
            // tIMEDataGridViewTextBoxColumn
            // 
            this.tIMEDataGridViewTextBoxColumn.DataPropertyName = "TIME";
            this.tIMEDataGridViewTextBoxColumn.HeaderText = "Time";
            this.tIMEDataGridViewTextBoxColumn.Name = "tIMEDataGridViewTextBoxColumn";
            // 
            // nOTESDataGridViewTextBoxColumn
            // 
            this.nOTESDataGridViewTextBoxColumn.DataPropertyName = "NOTES";
            this.nOTESDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.nOTESDataGridViewTextBoxColumn.Name = "nOTESDataGridViewTextBoxColumn";
            // 
            // aCTVDETAILSBindingSource
            // 
            this.aCTVDETAILSBindingSource.DataMember = "ACTV_DETAILS";
            this.aCTVDETAILSBindingSource.DataSource = this.oAHMSDataSet13BindingSource;
            // 
            // oAHMSDataSet13BindingSource
            // 
            this.oAHMSDataSet13BindingSource.DataSource = this.oAHMSDataSet13;
            this.oAHMSDataSet13BindingSource.Position = 0;
            // 
            // aCTV_DETAILSTableAdapter
            // 
            this.aCTV_DETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(43, 285);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(124, 285);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(205, 285);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.Location = new System.Drawing.Point(364, 285);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(122, 23);
            this.btn_MainMenu.TabIndex = 5;
            this.btn_MainMenu.Text = "Return to Main Menu";
            this.btn_MainMenu.UseVisualStyleBackColor = true;
            // 
            // frm_ActvDetail2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(759, 329);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ActvDetail2";
            this.Text = "Activity Records";
            this.Load += new System.EventHandler(this.frm_ActvDetail2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTVDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet13BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private OAHMSDataSet13 oAHMSDataSet13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oAHMSDataSet13BindingSource;
        private System.Windows.Forms.BindingSource aCTVDETAILSBindingSource;
        private OAHMSDataSet13TableAdapters.ACTV_DETAILSTableAdapter aCTV_DETAILSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTVNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTVNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTESDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.TextBox txt_ResName;
        private System.Windows.Forms.TextBox txt_ActName;
        private System.Windows.Forms.TextBox txt_ActNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.DateTimePicker dtp_Date;
    }
}
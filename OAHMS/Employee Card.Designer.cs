namespace OAHMS
{
    partial class frmEmp_Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmp_Card));
            this.lbl_empID = new System.Windows.Forms.Label();
            this.txt_empID = new System.Windows.Forms.TextBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oAHMSDataSet6 = new OAHMS.OAHMSDataSet6();
            this.txt_empName = new System.Windows.Forms.TextBox();
            this.lbl_empName = new System.Windows.Forms.Label();
            this.txt_empTitle = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_empAddr = new System.Windows.Forms.TextBox();
            this.lbl_empAddr = new System.Windows.Forms.Label();
            this.lbl_volunteer = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.lbl_notes = new System.Windows.Forms.Label();
            this.txt_qual = new System.Windows.Forms.TextBox();
            this.lbl_quali = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_volunteer = new System.Windows.Forms.ComboBox();
            this.employeesTableAdapter = new OAHMS.OAHMSDataSet6TableAdapters.EmployeesTableAdapter();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_empID
            // 
            this.lbl_empID.AutoSize = true;
            this.lbl_empID.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empID.Location = new System.Drawing.Point(36, 30);
            this.lbl_empID.Name = "lbl_empID";
            this.lbl_empID.Size = new System.Drawing.Size(77, 15);
            this.lbl_empID.TabIndex = 0;
            this.lbl_empID.Text = "Employee ID";
            // 
            // txt_empID
            // 
            this.txt_empID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Emp_Id", true));
            this.txt_empID.Location = new System.Drawing.Point(121, 26);
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.ReadOnly = true;
            this.txt_empID.Size = new System.Drawing.Size(80, 21);
            this.txt_empID.TabIndex = 0;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.oAHMSDataSet6;
            // 
            // oAHMSDataSet6
            // 
            this.oAHMSDataSet6.DataSetName = "OAHMSDataSet6";
            this.oAHMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_empName
            // 
            this.txt_empName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Emp_Name", true));
            this.txt_empName.Location = new System.Drawing.Point(121, 56);
            this.txt_empName.Name = "txt_empName";
            this.txt_empName.Size = new System.Drawing.Size(182, 21);
            this.txt_empName.TabIndex = 1;
            // 
            // lbl_empName
            // 
            this.lbl_empName.AutoSize = true;
            this.lbl_empName.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empName.Location = new System.Drawing.Point(16, 60);
            this.lbl_empName.Name = "lbl_empName";
            this.lbl_empName.Size = new System.Drawing.Size(99, 15);
            this.lbl_empName.TabIndex = 2;
            this.lbl_empName.Text = "Employee Name";
            // 
            // txt_empTitle
            // 
            this.txt_empTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Emp_Title", true));
            this.txt_empTitle.Location = new System.Drawing.Point(121, 86);
            this.txt_empTitle.Name = "txt_empTitle";
            this.txt_empTitle.Size = new System.Drawing.Size(182, 21);
            this.txt_empTitle.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(25, 90);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(88, 15);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Employee Title";
            // 
            // txt_empAddr
            // 
            this.txt_empAddr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Emp_Addr", true));
            this.txt_empAddr.Location = new System.Drawing.Point(121, 116);
            this.txt_empAddr.Multiline = true;
            this.txt_empAddr.Name = "txt_empAddr";
            this.txt_empAddr.Size = new System.Drawing.Size(182, 88);
            this.txt_empAddr.TabIndex = 3;
            // 
            // lbl_empAddr
            // 
            this.lbl_empAddr.AutoSize = true;
            this.lbl_empAddr.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_empAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empAddr.Location = new System.Drawing.Point(23, 116);
            this.lbl_empAddr.Name = "lbl_empAddr";
            this.lbl_empAddr.Size = new System.Drawing.Size(90, 15);
            this.lbl_empAddr.TabIndex = 6;
            this.lbl_empAddr.Text = "Employee Addr";
            this.lbl_empAddr.UseWaitCursor = true;
            // 
            // lbl_volunteer
            // 
            this.lbl_volunteer.AutoSize = true;
            this.lbl_volunteer.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_volunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volunteer.Location = new System.Drawing.Point(356, 34);
            this.lbl_volunteer.Name = "lbl_volunteer";
            this.lbl_volunteer.Size = new System.Drawing.Size(59, 15);
            this.lbl_volunteer.TabIndex = 8;
            this.lbl_volunteer.Text = "Volunteer";
            // 
            // txt_notes
            // 
            this.txt_notes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Emp_Notes", true));
            this.txt_notes.Location = new System.Drawing.Point(422, 62);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(182, 65);
            this.txt_notes.TabIndex = 5;
            // 
            // lbl_notes
            // 
            this.lbl_notes.AutoSize = true;
            this.lbl_notes.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notes.Location = new System.Drawing.Point(377, 65);
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.Size = new System.Drawing.Size(39, 15);
            this.lbl_notes.TabIndex = 10;
            this.lbl_notes.Text = "Notes";
            // 
            // txt_qual
            // 
            this.txt_qual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Emp_Qual", true));
            this.txt_qual.Location = new System.Drawing.Point(422, 142);
            this.txt_qual.Multiline = true;
            this.txt_qual.Name = "txt_qual";
            this.txt_qual.Size = new System.Drawing.Size(182, 62);
            this.txt_qual.TabIndex = 6;
            // 
            // lbl_quali
            // 
            this.lbl_quali.AutoSize = true;
            this.lbl_quali.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_quali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quali.Location = new System.Drawing.Point(334, 142);
            this.lbl_quali.Name = "lbl_quali";
            this.lbl_quali.Size = new System.Drawing.Size(81, 15);
            this.lbl_quali.TabIndex = 12;
            this.lbl_quali.Text = "Qualifications";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.cmb_volunteer);
            this.groupBox1.Controls.Add(this.txt_qual);
            this.groupBox1.Controls.Add(this.lbl_quali);
            this.groupBox1.Controls.Add(this.txt_notes);
            this.groupBox1.Controls.Add(this.lbl_notes);
            this.groupBox1.Controls.Add(this.lbl_volunteer);
            this.groupBox1.Controls.Add(this.txt_empAddr);
            this.groupBox1.Controls.Add(this.lbl_empAddr);
            this.groupBox1.Controls.Add(this.txt_empTitle);
            this.groupBox1.Controls.Add(this.lbl_title);
            this.groupBox1.Controls.Add(this.txt_empName);
            this.groupBox1.Controls.Add(this.lbl_empName);
            this.groupBox1.Controls.Add(this.txt_empID);
            this.groupBox1.Controls.Add(this.lbl_empID);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 248);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Card";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmb_volunteer
            // 
            this.cmb_volunteer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "Volunteer", true));
            this.cmb_volunteer.FormattingEnabled = true;
            this.cmb_volunteer.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmb_volunteer.Location = new System.Drawing.Point(422, 31);
            this.cmb_volunteer.Name = "cmb_volunteer";
            this.cmb_volunteer.Size = new System.Drawing.Size(71, 23);
            this.cmb_volunteer.TabIndex = 13;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(64, 297);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(322, 297);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(151, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Return to Main Menu";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(145, 297);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(226, 297);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Remove";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // frmEmp_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(705, 342);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmp_Card";
            this.Text = "Employee_Card";
            this.Load += new System.EventHandler(this.frmEmp_Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_empID;
        private System.Windows.Forms.TextBox txt_empID;
        private System.Windows.Forms.TextBox txt_empName;
        private System.Windows.Forms.Label lbl_empName;
        private System.Windows.Forms.TextBox txt_empTitle;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_empAddr;
        private System.Windows.Forms.Label lbl_empAddr;
        private System.Windows.Forms.Label lbl_volunteer;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label lbl_notes;
        private System.Windows.Forms.TextBox txt_qual;
        private System.Windows.Forms.Label lbl_quali;
        private System.Windows.Forms.GroupBox groupBox1;
        private OAHMSDataSet6 oAHMSDataSet6;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private OAHMSDataSet6TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmb_volunteer;
    }
}
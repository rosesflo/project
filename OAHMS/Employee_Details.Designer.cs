using System;

namespace OAHMS
{
    partial class frm_EmpDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EmpDetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkbox2_Status = new System.Windows.Forms.CheckedListBox();
            this.empDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oAHMSDataSet = new OAHMS.OAHMSDataSet();
            this.chkbox1_Gender = new System.Windows.Forms.CheckedListBox();
            this.dtp_DoB = new System.Windows.Forms.DateTimePicker();
            this.dtp_hireDate = new System.Windows.Forms.DateTimePicker();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_nis = new System.Windows.Forms.TextBox();
            this.txt_homeID = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_jobTitle = new System.Windows.Forms.TextBox();
            this.txt_addr = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_emp_ID = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_homeID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_jobTitle = new System.Windows.Forms.Label();
            this.lbl_addr = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_empCard = new System.Windows.Forms.Button();
            this.emp_DetailsTableAdapter = new OAHMS.OAHMSDataSetTableAdapters.Emp_DetailsTableAdapter();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.chkbox2_Status);
            this.groupBox1.Controls.Add(this.chkbox1_Gender);
            this.groupBox1.Controls.Add(this.dtp_DoB);
            this.groupBox1.Controls.Add(this.dtp_hireDate);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_nis);
            this.groupBox1.Controls.Add(this.txt_homeID);
            this.groupBox1.Controls.Add(this.txt_age);
            this.groupBox1.Controls.Add(this.txt_jobTitle);
            this.groupBox1.Controls.Add(this.txt_addr);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_salary);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_emp_ID);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lbl_homeID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_jobTitle);
            this.groupBox1.Controls.Add(this.lbl_addr);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // chkbox2_Status
            // 
            this.chkbox2_Status.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.empDetailsBindingSource, "Emp_Status", true));
            this.chkbox2_Status.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empDetailsBindingSource, "Emp_Status", true));
            this.chkbox2_Status.FormattingEnabled = true;
            this.chkbox2_Status.Items.AddRange(new object[] {
            "Married",
            "Single",
            "Divorced"});
            this.chkbox2_Status.Location = new System.Drawing.Point(96, 199);
            this.chkbox2_Status.Name = "chkbox2_Status";
            this.chkbox2_Status.Size = new System.Drawing.Size(106, 20);
            this.chkbox2_Status.TabIndex = 12;
            // 
            // empDetailsBindingSource
            // 
            this.empDetailsBindingSource.DataMember = "Emp_Details";
            this.empDetailsBindingSource.DataSource = this.oAHMSDataSet;
            // 
            // oAHMSDataSet
            // 
            this.oAHMSDataSet.DataSetName = "OAHMSDataSet";
            this.oAHMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkbox1_Gender
            // 
            this.chkbox1_Gender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.empDetailsBindingSource, "Emp_Gender", true));
            this.chkbox1_Gender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empDetailsBindingSource, "Emp_Gender", true));
            this.chkbox1_Gender.FormattingEnabled = true;
            this.chkbox1_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.chkbox1_Gender.Location = new System.Drawing.Point(98, 165);
            this.chkbox1_Gender.Name = "chkbox1_Gender";
            this.chkbox1_Gender.Size = new System.Drawing.Size(98, 20);
            this.chkbox1_Gender.TabIndex = 9;
            // 
            // dtp_DoB
            // 
            this.dtp_DoB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDetailsBindingSource, "Emp_DoB", true));
            this.dtp_DoB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.empDetailsBindingSource, "Emp_DoB", true));
            this.dtp_DoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DoB.Location = new System.Drawing.Point(611, 71);
            this.dtp_DoB.Name = "dtp_DoB";
            this.dtp_DoB.ShowCheckBox = true;
            this.dtp_DoB.Size = new System.Drawing.Size(111, 21);
            this.dtp_DoB.TabIndex = 6;
            // 
            // dtp_hireDate
            // 
            this.dtp_hireDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDetailsBindingSource, "Emp_HireDate", true));
            this.dtp_hireDate.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.empDetailsBindingSource, "Emp_HireDate", true));
            this.dtp_hireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hireDate.Location = new System.Drawing.Point(611, 102);
            this.dtp_hireDate.Name = "dtp_hireDate";
            this.dtp_hireDate.ShowCheckBox = true;
            this.dtp_hireDate.Size = new System.Drawing.Size(111, 21);
            this.dtp_hireDate.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDetailsBindingSource, "Emp_Name", true));
            this.txt_name.Location = new System.Drawing.Point(233, 43);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(170, 21);
            this.txt_name.TabIndex = 2;
            // 
            // txt_nis
            // 
            this.txt_nis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDetailsBindingSource, "Emp_NisNmbr", true));
            this.txt_nis.Location = new System.Drawing.Point(476, 167);
            this.txt_nis.Name = "txt_nis";
            this.txt_nis.Size = new System.Drawing.Size(215, 21);
            this.txt_nis.TabIndex = 11;
            // 
            // txt_homeID
            // 
            this.txt_homeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDetailsBindingSource, "Emp_HomeID", true));
            this.txt_homeID.Location = new System.Drawing.Point(487, 44);
            this.txt_homeID.Name = "txt_homeID";
            this.txt_homeID.Size = new System.Drawing.Size(69, 21);
            this.txt_homeID.TabIndex = 5;
            // 
            // txt_age
            // 
            this.txt_age.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDetailsBindingSource, "Emp_Age", true));
            this.txt_age.Location = new System.Drawing.Point(611, 40);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(63, 21);
            this.txt_age.TabIndex = 3;
            // 
            // txt_jobTitle
            // 
            this.txt_jobTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDetailsBindingSource, "Emp_JobTitle", true));
            this.txt_jobTitle.Location = new System.Drawing.Point(96, 132);
            this.txt_jobTitle.Name = "txt_jobTitle";
            this.txt_jobTitle.Size = new System.Drawing.Size(189, 21);
            this.txt_jobTitle.TabIndex = 7;
            // 
            // txt_addr
            // 
            this.txt_addr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDetailsBindingSource, "Emp_Addr", true));
            this.txt_addr.Location = new System.Drawing.Point(96, 76);
            this.txt_addr.Multiline = true;
            this.txt_addr.Name = "txt_addr";
            this.txt_addr.Size = new System.Drawing.Size(189, 45);
            this.txt_addr.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDetailsBindingSource, "Emp_Email", true));
            this.txt_email.Location = new System.Drawing.Point(477, 202);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(215, 21);
            this.txt_email.TabIndex = 14;
            // 
            // txt_salary
            // 
            this.txt_salary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDetailsBindingSource, "Emp_Salary", true));
            this.txt_salary.Location = new System.Drawing.Point(269, 166);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(100, 21);
            this.txt_salary.TabIndex = 10;
            // 
            // txt_phone
            // 
            this.txt_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDetailsBindingSource, "Emp_Phone", true));
            this.txt_phone.Location = new System.Drawing.Point(271, 199);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 21);
            this.txt_phone.TabIndex = 13;
            this.txt_phone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_emp_ID
            // 
            this.txt_emp_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empDetailsBindingSource, "Emp_Id", true));
            this.txt_emp_ID.Location = new System.Drawing.Point(98, 43);
            this.txt_emp_ID.Name = "txt_emp_ID";
            this.txt_emp_ID.Size = new System.Drawing.Size(59, 21);
            this.txt_emp_ID.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(175, 47);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(41, 15);
            this.lbl_name.TabIndex = 14;
            this.lbl_name.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(394, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "NIS Number";
            // 
            // lbl_homeID
            // 
            this.lbl_homeID.AutoSize = true;
            this.lbl_homeID.Location = new System.Drawing.Point(425, 47);
            this.lbl_homeID.Name = "lbl_homeID";
            this.lbl_homeID.Size = new System.Drawing.Size(56, 15);
            this.lbl_homeID.TabIndex = 12;
            this.lbl_homeID.Text = "Home ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hire Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // lbl_jobTitle
            // 
            this.lbl_jobTitle.AutoSize = true;
            this.lbl_jobTitle.Location = new System.Drawing.Point(20, 132);
            this.lbl_jobTitle.Name = "lbl_jobTitle";
            this.lbl_jobTitle.Size = new System.Drawing.Size(53, 15);
            this.lbl_jobTitle.TabIndex = 2;
            this.lbl_jobTitle.Text = "Job Title";
            // 
            // lbl_addr
            // 
            this.lbl_addr.AutoSize = true;
            this.lbl_addr.Location = new System.Drawing.Point(20, 72);
            this.lbl_addr.Name = "lbl_addr";
            this.lbl_addr.Size = new System.Drawing.Size(51, 15);
            this.lbl_addr.TabIndex = 1;
            this.lbl_addr.Text = "Address";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(20, 43);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(80, 15);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Employee ID:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(363, 306);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Save";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(522, 306);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Previous";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_empCard
            // 
            this.btn_empCard.Location = new System.Drawing.Point(67, 306);
            this.btn_empCard.Name = "btn_empCard";
            this.btn_empCard.Size = new System.Drawing.Size(96, 23);
            this.btn_empCard.TabIndex = 3;
            this.btn_empCard.Text = "Employee Card";
            this.btn_empCard.UseVisualStyleBackColor = true;
            this.btn_empCard.Click += new System.EventHandler(this.btn_empCard_Click);
            // 
            // emp_DetailsTableAdapter
            // 
            this.emp_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(444, 306);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // frm_EmpDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(830, 366);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_empCard);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EmpDetails";
            this.Text = "Employee_Details";
            this.Load += new System.EventHandler(this.frm_EmpDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_nis;
        private System.Windows.Forms.TextBox txt_homeID;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_jobTitle;
        private System.Windows.Forms.TextBox txt_addr;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_emp_ID;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_homeID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_jobTitle;
        private System.Windows.Forms.Label lbl_addr;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DateTimePicker dtp_DoB;
        private System.Windows.Forms.DateTimePicker dtp_hireDate;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.CheckedListBox chkbox2_Status;
        private System.Windows.Forms.CheckedListBox chkbox1_Gender;
        private System.Windows.Forms.Button btn_empCard;
       // private EventHandler textBox13_TextChanged;
       // private EventHandler lbl_homeID_Click;
      //  private EventHandler label10_Click;
        private OAHMSDataSet oAHMSDataSet;
        private System.Windows.Forms.BindingSource empDetailsBindingSource;
        private OAHMSDataSetTableAdapters.Emp_DetailsTableAdapter emp_DetailsTableAdapter;
        private System.Windows.Forms.Button btn_update;
    }
}
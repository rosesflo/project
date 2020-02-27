namespace OAHMS
{
    partial class frm_NCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NCard));
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Addr = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_RName = new System.Windows.Forms.TextBox();
            this.oAHMSDataSet = new OAHMS.OAHMSDataSet();
            this.nextofKinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.next_of_KinTableAdapter = new OAHMS.OAHMSDataSetTableAdapters.Next_of_KinTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOKNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOKAddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOKPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOKEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextofKinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oAHMSDataSet11 = new OAHMS.OAHMSDataSet11();
            this.btn_close = new System.Windows.Forms.Button();
            this.next_of_KinTableAdapter1 = new OAHMS.OAHMSDataSet11TableAdapters.Next_of_KinTableAdapter();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextofKinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextofKinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(46, 332);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(54, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Resident Name";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(88, 22);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(109, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(88, 51);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(186, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Addr
            // 
            this.txt_Addr.Location = new System.Drawing.Point(88, 84);
            this.txt_Addr.Multiline = true;
            this.txt_Addr.Name = "txt_Addr";
            this.txt_Addr.Size = new System.Drawing.Size(186, 42);
            this.txt_Addr.TabIndex = 2;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(438, 26);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(194, 20);
            this.txt_Phone.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(438, 56);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(194, 20);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_RName
            // 
            this.txt_RName.Location = new System.Drawing.Point(489, 91);
            this.txt_RName.Multiline = true;
            this.txt_RName.Name = "txt_RName";
            this.txt_RName.Size = new System.Drawing.Size(143, 27);
            this.txt_RName.TabIndex = 6;
            // 
            // oAHMSDataSet
            // 
            this.oAHMSDataSet.DataSetName = "OAHMSDataSet";
            this.oAHMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nextofKinBindingSource
            // 
            this.nextofKinBindingSource.DataMember = "Next_of_Kin";
            this.nextofKinBindingSource.DataSource = this.oAHMSDataSet;
            // 
            // next_of_KinTableAdapter
            // 
            this.next_of_KinTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nOKNameDataGridViewTextBoxColumn,
            this.nOKAddrDataGridViewTextBoxColumn,
            this.nOKPhoneDataGridViewTextBoxColumn,
            this.nOKEmailDataGridViewTextBoxColumn,
            this.rNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nextofKinBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(34, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 35;
            // 
            // nOKNameDataGridViewTextBoxColumn
            // 
            this.nOKNameDataGridViewTextBoxColumn.DataPropertyName = "NOK_Name";
            this.nOKNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nOKNameDataGridViewTextBoxColumn.Name = "nOKNameDataGridViewTextBoxColumn";
            // 
            // nOKAddrDataGridViewTextBoxColumn
            // 
            this.nOKAddrDataGridViewTextBoxColumn.DataPropertyName = "NOK_Addr";
            this.nOKAddrDataGridViewTextBoxColumn.HeaderText = "Address";
            this.nOKAddrDataGridViewTextBoxColumn.Name = "nOKAddrDataGridViewTextBoxColumn";
            // 
            // nOKPhoneDataGridViewTextBoxColumn
            // 
            this.nOKPhoneDataGridViewTextBoxColumn.DataPropertyName = "NOK_Phone";
            this.nOKPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.nOKPhoneDataGridViewTextBoxColumn.Name = "nOKPhoneDataGridViewTextBoxColumn";
            // 
            // nOKEmailDataGridViewTextBoxColumn
            // 
            this.nOKEmailDataGridViewTextBoxColumn.DataPropertyName = "NOK_Email";
            this.nOKEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.nOKEmailDataGridViewTextBoxColumn.Name = "nOKEmailDataGridViewTextBoxColumn";
            // 
            // rNameDataGridViewTextBoxColumn
            // 
            this.rNameDataGridViewTextBoxColumn.DataPropertyName = "R_Name";
            this.rNameDataGridViewTextBoxColumn.HeaderText = "Resident Name";
            this.rNameDataGridViewTextBoxColumn.Name = "rNameDataGridViewTextBoxColumn";
            this.rNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // nextofKinBindingSource1
            // 
            this.nextofKinBindingSource1.DataMember = "Next_of_Kin";
            this.nextofKinBindingSource1.DataSource = this.oAHMSDataSet11;
            // 
            // oAHMSDataSet11
            // 
            this.oAHMSDataSet11.DataSetName = "OAHMSDataSet11";
            this.oAHMSDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(596, 332);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(116, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Return to Main Menu";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // next_of_KinTableAdapter1
            // 
            this.next_of_KinTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(105, 332);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(54, 23);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(165, 332);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(66, 23);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Remove";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.txt_RName);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_Phone);
            this.groupBox1.Controls.Add(this.txt_Addr);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 141);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Next of Kin Card";
            // 
            // frm_NCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(744, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_NCard";
            this.Text = "NOK Card";
            this.Load += new System.EventHandler(this.NOK_Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextofKinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextofKinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Addr;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_RName;
        private OAHMSDataSet oAHMSDataSet;
        private System.Windows.Forms.BindingSource nextofKinBindingSource;
        private OAHMSDataSetTableAdapters.Next_of_KinTableAdapter next_of_KinTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_close;
        private OAHMSDataSet11 oAHMSDataSet11;
        private System.Windows.Forms.BindingSource nextofKinBindingSource1;
        private OAHMSDataSet11TableAdapters.Next_of_KinTableAdapter next_of_KinTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOKNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOKAddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOKPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOKEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
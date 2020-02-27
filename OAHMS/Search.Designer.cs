using System;

namespace OAHMS
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rReligionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAllergiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNextOfKinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oAHMSDataSet14 = new OAHMS.OAHMSDataSet14();
            this.residentTableAdapter = new OAHMS.OAHMSDataSet14TableAdapters.ResidentTableAdapter();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(65, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Name";
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Location = new System.Drawing.Point(157, 32);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(206, 20);
            this.txt_SearchName.TabIndex = 1;
            this.txt_SearchName.TextChanged += new System.EventHandler(this.txt_SearchName_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rIdDataGridViewTextBoxColumn,
            this.rNameDataGridViewTextBoxColumn,
            this.rAddrDataGridViewTextBoxColumn,
            this.rReligionDataGridViewTextBoxColumn,
            this.rAllergiesDataGridViewTextBoxColumn,
            this.rNextOfKinDataGridViewTextBoxColumn,
            this.rNotesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.residentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // rIdDataGridViewTextBoxColumn
            // 
            this.rIdDataGridViewTextBoxColumn.DataPropertyName = "R_Id";
            this.rIdDataGridViewTextBoxColumn.HeaderText = "R_Id";
            this.rIdDataGridViewTextBoxColumn.Name = "rIdDataGridViewTextBoxColumn";
            // 
            // rNameDataGridViewTextBoxColumn
            // 
            this.rNameDataGridViewTextBoxColumn.DataPropertyName = "R_Name";
            this.rNameDataGridViewTextBoxColumn.HeaderText = "R_Name";
            this.rNameDataGridViewTextBoxColumn.Name = "rNameDataGridViewTextBoxColumn";
            // 
            // rAddrDataGridViewTextBoxColumn
            // 
            this.rAddrDataGridViewTextBoxColumn.DataPropertyName = "R_Addr";
            this.rAddrDataGridViewTextBoxColumn.HeaderText = "R_Addr";
            this.rAddrDataGridViewTextBoxColumn.Name = "rAddrDataGridViewTextBoxColumn";
            // 
            // rReligionDataGridViewTextBoxColumn
            // 
            this.rReligionDataGridViewTextBoxColumn.DataPropertyName = "R_Religion";
            this.rReligionDataGridViewTextBoxColumn.HeaderText = "R_Religion";
            this.rReligionDataGridViewTextBoxColumn.Name = "rReligionDataGridViewTextBoxColumn";
            // 
            // rAllergiesDataGridViewTextBoxColumn
            // 
            this.rAllergiesDataGridViewTextBoxColumn.DataPropertyName = "R_Allergies";
            this.rAllergiesDataGridViewTextBoxColumn.HeaderText = "R_Allergies";
            this.rAllergiesDataGridViewTextBoxColumn.Name = "rAllergiesDataGridViewTextBoxColumn";
            // 
            // rNextOfKinDataGridViewTextBoxColumn
            // 
            this.rNextOfKinDataGridViewTextBoxColumn.DataPropertyName = "R_NextOfKin";
            this.rNextOfKinDataGridViewTextBoxColumn.HeaderText = "R_NextOfKin";
            this.rNextOfKinDataGridViewTextBoxColumn.Name = "rNextOfKinDataGridViewTextBoxColumn";
            // 
            // rNotesDataGridViewTextBoxColumn
            // 
            this.rNotesDataGridViewTextBoxColumn.DataPropertyName = "R_Notes";
            this.rNotesDataGridViewTextBoxColumn.HeaderText = "R_Notes";
            this.rNotesDataGridViewTextBoxColumn.Name = "rNotesDataGridViewTextBoxColumn";
            // 
            // residentBindingSource
            // 
            this.residentBindingSource.DataMember = "Resident";
            this.residentBindingSource.DataSource = this.oAHMSDataSet14;
            // 
            // oAHMSDataSet14
            // 
            this.oAHMSDataSet14.DataSetName = "OAHMSDataSet14";
            this.oAHMSDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // residentTableAdapter
            // 
            this.residentTableAdapter.ClearBeforeFill = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(56, 249);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(101, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Return to Main";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(784, 301);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_SearchName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch";
            this.Text = "Search Records";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OAHMSDataSet14 oAHMSDataSet14;
        private System.Windows.Forms.BindingSource residentBindingSource;
        private OAHMSDataSet14TableAdapters.ResidentTableAdapter residentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rReligionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAllergiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNextOfKinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_close;

        public EventHandler label1_Click { get; private set; }
    }
}
using System;

namespace OAHMS
{
    partial class frm_actvCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_actvCard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_actNum = new System.Windows.Forms.TextBox();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oAHMSDataSet8 = new OAHMS.OAHMSDataSet8();
            this.txt_actName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.activityTableAdapter = new OAHMS.OAHMSDataSet8TableAdapters.activityTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aCTVNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTVNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet8)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Activity Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activity Name";
            // 
            // txt_actNum
            // 
            this.txt_actNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ACTV_NUM", true));
            this.txt_actNum.Location = new System.Drawing.Point(123, 21);
            this.txt_actNum.Name = "txt_actNum";
            this.txt_actNum.ReadOnly = true;
            this.txt_actNum.Size = new System.Drawing.Size(100, 22);
            this.txt_actNum.TabIndex = 4;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "activity";
            this.activityBindingSource.DataSource = this.oAHMSDataSet8;
            // 
            // oAHMSDataSet8
            // 
            this.oAHMSDataSet8.DataSetName = "OAHMSDataSet8";
            this.oAHMSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_actName
            // 
            this.txt_actName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ACTV_NAME", true));
            this.txt_actName.Location = new System.Drawing.Point(123, 60);
            this.txt_actName.Name = "txt_actName";
            this.txt_actName.Size = new System.Drawing.Size(100, 22);
            this.txt_actName.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.txt_actName);
            this.groupBox1.Controls.Add(this.txt_actNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity Card";
            // 
            // btn_prev
            // 
            this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.Location = new System.Drawing.Point(312, 256);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(106, 23);
            this.btn_prev.TabIndex = 7;
            this.btn_prev.Text = "Return to Main";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aCTVNUMDataGridViewTextBoxColumn,
            this.aCTVNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.activityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(269, 90);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
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
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(29, 256);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(110, 256);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(191, 256);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 11;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // frm_actvCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(430, 311);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_actvCard";
            this.Text = "Activity_Card";
            this.Load += new System.EventHandler(this.Activity_Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet8)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_actNum;
        private System.Windows.Forms.TextBox txt_actName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_prev;
        private OAHMSDataSet8 oAHMSDataSet8;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private OAHMSDataSet8TableAdapters.activityTableAdapter activityTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTVNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTVNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_remove;

        public EventHandler txt_actNum_TextChanged { get; private set; }
    }
}
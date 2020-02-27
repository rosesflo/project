namespace OAHMS
{
    partial class frmRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoom));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_RM_ID = new System.Windows.Forms.TextBox();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.roomDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oAHMSDataSet7 = new OAHMS.OAHMSDataSet7();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rMNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rMTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_DetailsTableAdapter = new OAHMS.OAHMSDataSet7TableAdapters.Room_DetailsTableAdapter();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.txt_available = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(54, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(35, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(7, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resident Name";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 225);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(102, 225);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(183, 225);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Remove";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 254);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Previous";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_RM_ID
            // 
            this.txt_RM_ID.Location = new System.Drawing.Point(91, 44);
            this.txt_RM_ID.Name = "txt_RM_ID";
            this.txt_RM_ID.ReadOnly = true;
            this.txt_RM_ID.Size = new System.Drawing.Size(86, 20);
            this.txt_RM_ID.TabIndex = 9;
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(91, 88);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(86, 20);
            this.txt_Number.TabIndex = 10;
            this.txt_Number.TextChanged += new System.EventHandler(this.txt_Number_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(91, 195);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(167, 24);
            this.txt_Name.TabIndex = 11;
            // 
            // roomDetailsBindingSource
            // 
            this.roomDetailsBindingSource.DataMember = "Room_Details";
            this.roomDetailsBindingSource.DataSource = this.oAHMSDataSet7;
            // 
            // oAHMSDataSet7
            // 
            this.oAHMSDataSet7.DataSetName = "OAHMSDataSet7";
            this.oAHMSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rMIDDataGridViewTextBoxColumn,
            this.rMNumberDataGridViewTextBoxColumn,
            this.rMTypeDataGridViewTextBoxColumn,
            this.availableDataGridViewTextBoxColumn,
            this.rNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(284, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 175);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // rMIDDataGridViewTextBoxColumn
            // 
            this.rMIDDataGridViewTextBoxColumn.DataPropertyName = "RM_ID";
            this.rMIDDataGridViewTextBoxColumn.HeaderText = "RM_ID";
            this.rMIDDataGridViewTextBoxColumn.Name = "rMIDDataGridViewTextBoxColumn";
            this.rMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rMIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // rMNumberDataGridViewTextBoxColumn
            // 
            this.rMNumberDataGridViewTextBoxColumn.DataPropertyName = "RM_Number";
            this.rMNumberDataGridViewTextBoxColumn.HeaderText = "Room Number";
            this.rMNumberDataGridViewTextBoxColumn.Name = "rMNumberDataGridViewTextBoxColumn";
            this.rMNumberDataGridViewTextBoxColumn.Width = 50;
            // 
            // rMTypeDataGridViewTextBoxColumn
            // 
            this.rMTypeDataGridViewTextBoxColumn.DataPropertyName = "RM_Type";
            this.rMTypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.rMTypeDataGridViewTextBoxColumn.Name = "rMTypeDataGridViewTextBoxColumn";
            this.rMTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rMTypeDataGridViewTextBoxColumn.Width = 50;
            // 
            // availableDataGridViewTextBoxColumn
            // 
            this.availableDataGridViewTextBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewTextBoxColumn.HeaderText = "Available";
            this.availableDataGridViewTextBoxColumn.Name = "availableDataGridViewTextBoxColumn";
            this.availableDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.availableDataGridViewTextBoxColumn.Width = 60;
            // 
            // rNameDataGridViewTextBoxColumn
            // 
            this.rNameDataGridViewTextBoxColumn.DataPropertyName = "R_Name";
            this.rNameDataGridViewTextBoxColumn.HeaderText = "Resident Name";
            this.rNameDataGridViewTextBoxColumn.Name = "rNameDataGridViewTextBoxColumn";
            this.rNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // room_DetailsTableAdapter
            // 
            this.room_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(91, 131);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(86, 20);
            this.txt_type.TabIndex = 15;
            // 
            // txt_available
            // 
            this.txt_available.Location = new System.Drawing.Point(91, 165);
            this.txt_available.Name = "txt_available";
            this.txt_available.Size = new System.Drawing.Size(86, 20);
            this.txt_available.TabIndex = 16;
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(753, 297);
            this.Controls.Add(this.txt_available);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.txt_RM_ID);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRoom";
            this.Text = "Room Details";
            this.Load += new System.EventHandler(this.Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_RM_ID;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OAHMSDataSet7 oAHMSDataSet7;
        private System.Windows.Forms.BindingSource roomDetailsBindingSource;
        private OAHMSDataSet7TableAdapters.Room_DetailsTableAdapter room_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rMNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rMTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.TextBox txt_available;
    }
}
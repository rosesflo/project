namespace OAHMS
{
    partial class frm_actvDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_actvDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_actvNum = new System.Windows.Forms.TextBox();
            this.aCTVDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oAHMSDataSet10 = new OAHMS.OAHMSDataSet10();
            this.txt_actv_Name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_actvCard = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.aCTV_DETAILSTableAdapter = new OAHMS.OAHMSDataSet10TableAdapters.ACTV_DETAILSTableAdapter();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aCTVDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet10)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activity Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resident ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Notes";
            // 
            // txt_actvNum
            // 
            this.txt_actvNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCTVDETAILSBindingSource, "ACTV_NUM", true));
            this.txt_actvNum.Location = new System.Drawing.Point(120, 49);
            this.txt_actvNum.Name = "txt_actvNum";
            this.txt_actvNum.Size = new System.Drawing.Size(75, 22);
            this.txt_actvNum.TabIndex = 7;
            // 
            // aCTVDETAILSBindingSource
            // 
            this.aCTVDETAILSBindingSource.DataMember = "ACTV_DETAILS";
            this.aCTVDETAILSBindingSource.DataSource = this.oAHMSDataSet10;
            // 
            // oAHMSDataSet10
            // 
            this.oAHMSDataSet10.DataSetName = "OAHMSDataSet10";
            this.oAHMSDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_actv_Name
            // 
            this.txt_actv_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCTVDETAILSBindingSource, "ACTV_NAME", true));
            this.txt_actv_Name.Location = new System.Drawing.Point(269, 49);
            this.txt_actv_Name.Name = "txt_actv_Name";
            this.txt_actv_Name.Size = new System.Drawing.Size(149, 22);
            this.txt_actv_Name.TabIndex = 8;
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCTVDETAILSBindingSource, "R_ID", true));
            this.txt_id.Location = new System.Drawing.Point(119, 90);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(76, 22);
            this.txt_id.TabIndex = 9;
            // 
            // txt_name
            // 
            this.txt_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCTVDETAILSBindingSource, "R_NAME", true));
            this.txt_name.Location = new System.Drawing.Point(269, 90);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(149, 22);
            this.txt_name.TabIndex = 10;
            // 
            // txt_notes
            // 
            this.txt_notes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCTVDETAILSBindingSource, "NOTES", true));
            this.txt_notes.Location = new System.Drawing.Point(112, 164);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(246, 63);
            this.txt_notes.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCTVDETAILSBindingSource, "DATE", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCTVDETAILSBindingSource, "TIME", true));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(269, 129);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(89, 22);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_notes);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_actv_Name);
            this.groupBox1.Controls.Add(this.txt_actvNum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 261);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity Details";
            // 
            // btn_actvCard
            // 
            this.btn_actvCard.Location = new System.Drawing.Point(326, 310);
            this.btn_actvCard.Name = "btn_actvCard";
            this.btn_actvCard.Size = new System.Drawing.Size(75, 23);
            this.btn_actvCard.TabIndex = 17;
            this.btn_actvCard.Text = "Activity Card";
            this.btn_actvCard.UseVisualStyleBackColor = true;
            this.btn_actvCard.Click += new System.EventHandler(this.btn_actvCard_Click);
            // 
            // btn_main
            // 
            this.btn_main.Location = new System.Drawing.Point(407, 310);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(75, 23);
            this.btn_main.TabIndex = 18;
            this.btn_main.Text = "Main Menu";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // aCTV_DETAILSTableAdapter
            // 
            this.aCTV_DETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(35, 310);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(62, 23);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(99, 310);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(51, 23);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(154, 310);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(60, 23);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // frm_actvDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(512, 364);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.btn_actvCard);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_actvDetails";
            this.Text = "Activity_Details";
            this.Load += new System.EventHandler(this.Activity_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aCTVDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet10)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_actvNum;
        private System.Windows.Forms.TextBox txt_actv_Name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_actvCard;
        private System.Windows.Forms.Button btn_main;
        private OAHMSDataSet10 oAHMSDataSet10;
        private System.Windows.Forms.BindingSource aCTVDETAILSBindingSource;
        private OAHMSDataSet10TableAdapters.ACTV_DETAILSTableAdapter aCTV_DETAILSTableAdapter;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}
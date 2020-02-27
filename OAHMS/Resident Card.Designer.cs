namespace OAHMS
{
    partial class Resident_Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resident_Card));
            this.oAHMSDataSet2 = new OAHMS.OAHMSDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.residentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Addr = new System.Windows.Forms.TextBox();
            this.txt_Rel = new System.Windows.Forms.TextBox();
            this.txt_Alleg = new System.Windows.Forms.TextBox();
            this.txt_NoK = new System.Windows.Forms.TextBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.residentTableAdapter = new OAHMS.OAHMSDataSet2TableAdapters.ResidentTableAdapter();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oAHMSDataSet2
            // 
            this.oAHMSDataSet2.DataSetName = "OAHMSDataSet2";
            this.oAHMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resident ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Religion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Allergies:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Next of Kin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Honeydew;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Notes:";
            // 
            // txt_ID
            // 
            this.txt_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentBindingSource, "R_Id", true));
            this.txt_ID.Location = new System.Drawing.Point(108, 21);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(64, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // residentBindingSource
            // 
            this.residentBindingSource.DataMember = "Resident";
            this.residentBindingSource.DataSource = this.oAHMSDataSet2;
            // 
            // txt_Name
            // 
            this.txt_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentBindingSource, "R_Name", true));
            this.txt_Name.Location = new System.Drawing.Point(108, 53);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(211, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Addr
            // 
            this.txt_Addr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentBindingSource, "R_Addr", true));
            this.txt_Addr.Location = new System.Drawing.Point(108, 91);
            this.txt_Addr.Multiline = true;
            this.txt_Addr.Name = "txt_Addr";
            this.txt_Addr.Size = new System.Drawing.Size(211, 42);
            this.txt_Addr.TabIndex = 2;
            // 
            // txt_Rel
            // 
            this.txt_Rel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentBindingSource, "R_Religion", true));
            this.txt_Rel.Location = new System.Drawing.Point(108, 139);
            this.txt_Rel.Multiline = true;
            this.txt_Rel.Name = "txt_Rel";
            this.txt_Rel.Size = new System.Drawing.Size(211, 20);
            this.txt_Rel.TabIndex = 3;
            // 
            // txt_Alleg
            // 
            this.txt_Alleg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentBindingSource, "R_Allergies", true));
            this.txt_Alleg.Location = new System.Drawing.Point(108, 167);
            this.txt_Alleg.Multiline = true;
            this.txt_Alleg.Name = "txt_Alleg";
            this.txt_Alleg.Size = new System.Drawing.Size(211, 39);
            this.txt_Alleg.TabIndex = 4;
            // 
            // txt_NoK
            // 
            this.txt_NoK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentBindingSource, "R_NextOfKin", true));
            this.txt_NoK.Location = new System.Drawing.Point(428, 19);
            this.txt_NoK.Multiline = true;
            this.txt_NoK.Name = "txt_NoK";
            this.txt_NoK.Size = new System.Drawing.Size(197, 20);
            this.txt_NoK.TabIndex = 5;
            // 
            // txt_Notes
            // 
            this.txt_Notes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residentBindingSource, "R_Notes", true));
            this.txt_Notes.Location = new System.Drawing.Point(428, 53);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(197, 53);
            this.txt_Notes.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(111, 279);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.txt_Notes);
            this.groupBox1.Controls.Add(this.txt_NoK);
            this.groupBox1.Controls.Add(this.txt_Alleg);
            this.groupBox1.Controls.Add(this.txt_Rel);
            this.groupBox1.Controls.Add(this.txt_Addr);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 228);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resident Card";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(308, 279);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(57, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Previous";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // residentTableAdapter
            // 
            this.residentTableAdapter.ClearBeforeFill = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(173, 279);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(56, 23);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(235, 279);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 23);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Remove";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // Resident_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(708, 323);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resident_Card";
            this.Text = "Resident_Card";
            this.Load += new System.EventHandler(this.Resident_Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oAHMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private OAHMSDataSet2 oAHMSDataSet2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Addr;
        private System.Windows.Forms.TextBox txt_Rel;
        private System.Windows.Forms.TextBox txt_Alleg;
        private System.Windows.Forms.TextBox txt_NoK;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.BindingSource residentBindingSource;
        private OAHMSDataSet2TableAdapters.ResidentTableAdapter residentTableAdapter;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}
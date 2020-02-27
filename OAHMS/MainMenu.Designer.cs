namespace OAHMS
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_Residents = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Employees = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_cards = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_medRecord = new System.Windows.Forms.Button();
            this.btn_inquiry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Residents
            // 
            this.btn_Residents.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Residents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Residents.Location = new System.Drawing.Point(155, 123);
            this.btn_Residents.Name = "btn_Residents";
            this.btn_Residents.Size = new System.Drawing.Size(147, 23);
            this.btn_Residents.TabIndex = 0;
            this.btn_Residents.Text = "Resident Records";
            this.btn_Residents.UseVisualStyleBackColor = true;
            this.btn_Residents.Click += new System.EventHandler(this.btn_Residents_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::OAHMS.Properties.Resources.Untitled1;
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Employees
            // 
            this.btn_Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employees.Location = new System.Drawing.Point(155, 164);
            this.btn_Employees.Name = "btn_Employees";
            this.btn_Employees.Size = new System.Drawing.Size(146, 23);
            this.btn_Employees.TabIndex = 2;
            this.btn_Employees.Text = "Employee Records";
            this.btn_Employees.UseVisualStyleBackColor = true;
            this.btn_Employees.Click += new System.EventHandler(this.btn_Employees_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(447, 241);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Sign Out";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_cards
            // 
            this.btn_cards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cards.Location = new System.Drawing.Point(343, 123);
            this.btn_cards.Name = "btn_cards";
            this.btn_cards.Size = new System.Drawing.Size(103, 23);
            this.btn_cards.TabIndex = 4;
            this.btn_cards.Text = "Cards";
            this.btn_cards.UseVisualStyleBackColor = true;
            this.btn_cards.Click += new System.EventHandler(this.btn_cards_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.Location = new System.Drawing.Point(343, 164);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(103, 23);
            this.btn_reports.TabIndex = 5;
            this.btn_reports.Text = "Reports";
            this.btn_reports.UseVisualStyleBackColor = true;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_medRecord
            // 
            this.btn_medRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medRecord.Location = new System.Drawing.Point(155, 211);
            this.btn_medRecord.Name = "btn_medRecord";
            this.btn_medRecord.Size = new System.Drawing.Size(147, 23);
            this.btn_medRecord.TabIndex = 6;
            this.btn_medRecord.Text = "Medical Records";
            this.btn_medRecord.UseVisualStyleBackColor = true;
            this.btn_medRecord.Click += new System.EventHandler(this.btn_medRecord_Click);
            // 
            // btn_inquiry
            // 
            this.btn_inquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inquiry.Location = new System.Drawing.Point(343, 211);
            this.btn_inquiry.Name = "btn_inquiry";
            this.btn_inquiry.Size = new System.Drawing.Size(103, 23);
            this.btn_inquiry.TabIndex = 7;
            this.btn_inquiry.Text = "Inquiry";
            this.btn_inquiry.UseVisualStyleBackColor = true;
            this.btn_inquiry.Click += new System.EventHandler(this.btn_inquiry_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(603, 294);
            this.Controls.Add(this.btn_inquiry);
            this.Controls.Add(this.btn_medRecord);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.btn_cards);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Employees);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Residents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Residents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Employees;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_cards;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_medRecord;
        private System.Windows.Forms.Button btn_inquiry;
    }
}
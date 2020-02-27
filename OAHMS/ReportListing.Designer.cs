namespace OAHMS
{
    partial class frm_rptList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rptList));
            this.btn_ResList = new System.Windows.Forms.Button();
            this.btn_RoomList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ResList
            // 
            this.btn_ResList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResList.Location = new System.Drawing.Point(45, 68);
            this.btn_ResList.Name = "btn_ResList";
            this.btn_ResList.Size = new System.Drawing.Size(97, 23);
            this.btn_ResList.TabIndex = 0;
            this.btn_ResList.Text = "Resident List";
            this.btn_ResList.UseVisualStyleBackColor = true;
            this.btn_ResList.Click += new System.EventHandler(this.btn_ResList_Click);
            // 
            // btn_RoomList
            // 
            this.btn_RoomList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RoomList.Location = new System.Drawing.Point(45, 97);
            this.btn_RoomList.Name = "btn_RoomList";
            this.btn_RoomList.Size = new System.Drawing.Size(97, 23);
            this.btn_RoomList.TabIndex = 1;
            this.btn_RoomList.Text = "Rooms List";
            this.btn_RoomList.UseVisualStyleBackColor = true;
            this.btn_RoomList.Click += new System.EventHandler(this.btn_RoomList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_rptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(397, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_RoomList);
            this.Controls.Add(this.btn_ResList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_rptList";
            this.Text = "Report Listing";
            this.Load += new System.EventHandler(this.frm_rptList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ResList;
        private System.Windows.Forms.Button btn_RoomList;
        private System.Windows.Forms.Button button1;
    }
}
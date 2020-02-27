namespace OAHMS
{
    partial class DisplayReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ResidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OAHMSDataSet2 = new OAHMS.OAHMSDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OAHMSDataSet12 = new OAHMS.OAHMSDataSet12();
            this.Room_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Room_DetailsTableAdapter = new OAHMS.OAHMSDataSet12TableAdapters.Room_DetailsTableAdapter();
            this.ResidentTableAdapter = new OAHMS.OAHMSDataSet2TableAdapters.ResidentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAHMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAHMSDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room_DetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ResidentBindingSource
            // 
            this.ResidentBindingSource.DataMember = "Resident";
            this.ResidentBindingSource.DataSource = this.OAHMSDataSet2;
            // 
            // OAHMSDataSet2
            // 
            this.OAHMSDataSet2.DataSetName = "OAHMSDataSet2";
            this.OAHMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ResidentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DisplayName = "Room Listing";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OAHMS.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(677, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // OAHMSDataSet12
            // 
            this.OAHMSDataSet12.DataSetName = "OAHMSDataSet12";
            this.OAHMSDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Room_DetailsBindingSource
            // 
            this.Room_DetailsBindingSource.DataMember = "Room_Details";
            this.Room_DetailsBindingSource.DataSource = this.OAHMSDataSet12;
            // 
            // Room_DetailsTableAdapter
            // 
            this.Room_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ResidentTableAdapter
            // 
            this.ResidentTableAdapter.ClearBeforeFill = true;
            // 
            // DisplayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DisplayReport";
            this.Text = "DisplayReport";
            this.Load += new System.EventHandler(this.DisplayReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAHMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAHMSDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room_DetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Room_DetailsBindingSource;
        private OAHMSDataSet12 OAHMSDataSet12;
        private OAHMSDataSet12TableAdapters.Room_DetailsTableAdapter Room_DetailsTableAdapter;
        private System.Windows.Forms.BindingSource ResidentBindingSource;
        private OAHMSDataSet2 OAHMSDataSet2;
        private OAHMSDataSet2TableAdapters.ResidentTableAdapter ResidentTableAdapter;
    }
}
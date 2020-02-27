namespace OAHMS
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.ResidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OAHMSDataSet2 = new OAHMS.OAHMSDataSet2();
            this.rptResdentDetails = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ResidentTableAdapter = new OAHMS.OAHMSDataSet2TableAdapters.ResidentTableAdapter();
            this.OAHMSDataSet = new OAHMS.OAHMSDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAHMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAHMSDataSet)).BeginInit();
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
            // rptResidentList
            // 
            this.rptResdentDetails.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rptResdentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ResidentBindingSource;
            this.rptResdentDetails.LocalReport.DataSources.Add(reportDataSource1);
            this.rptResdentDetails.LocalReport.ReportEmbeddedResource = "OAHMS.Report3.rdlc";
            this.rptResdentDetails.Location = new System.Drawing.Point(0, 0);
            this.rptResdentDetails.Name = "rptResidentList";
            this.rptResdentDetails.Size = new System.Drawing.Size(555, 261);
            this.rptResdentDetails.TabIndex = 0;
            this.rptResdentDetails.Load += new System.EventHandler(this.rptResidentDetails_Load);
            // 
            // ResidentTableAdapter
            // 
            this.ResidentTableAdapter.ClearBeforeFill = true;
            // 
            // OAHMSDataSet
            // 
            this.OAHMSDataSet.DataSetName = "OAHMSDataSet";
            this.OAHMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.rptResdentDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.Text = "Report - Resident Listing";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAHMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAHMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptResdentDetails;
        private System.Windows.Forms.BindingSource ResidentBindingSource;
        private OAHMSDataSet2 OAHMSDataSet2;
        private OAHMSDataSet2TableAdapters.ResidentTableAdapter ResidentTableAdapter;
        private OAHMSDataSet OAHMSDataSet;
    }
}
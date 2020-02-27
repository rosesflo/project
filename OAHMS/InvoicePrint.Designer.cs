namespace OAHMS
{
    partial class frm_InvoicePrint
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new OAHMS.DataSet1();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OAHMSDataSet25 = new OAHMS.OAHMSDataSet25();
            this.Billing_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Billing_DetailsTableAdapter = new OAHMS.OAHMSDataSet25TableAdapters.Billing_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAHMSDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Billing_DetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Billing_DetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OAHMS.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(90, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // OAHMSDataSet25
            // 
            this.OAHMSDataSet25.DataSetName = "OAHMSDataSet25";
            this.OAHMSDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Billing_DetailsBindingSource
            // 
            this.Billing_DetailsBindingSource.DataMember = "Billing_Details";
            this.Billing_DetailsBindingSource.DataSource = this.OAHMSDataSet25;
            // 
            // Billing_DetailsTableAdapter
            // 
            this.Billing_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_InvoicePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_InvoicePrint";
            this.Text = "InvoicePrint";
            this.Load += new System.EventHandler(this.InvoicePrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAHMSDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Billing_DetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource Billing_DetailsBindingSource;
        private OAHMSDataSet25 OAHMSDataSet25;
        private OAHMSDataSet25TableAdapters.Billing_DetailsTableAdapter Billing_DetailsTableAdapter;
    }
}
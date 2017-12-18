namespace SoftWare_Engineering.Report
{
    partial class Bill_Report
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
            this.dormMSDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dorm_MSDataSet3 = new SoftWare_Engineering.Dorm_MSDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dormMSDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorm_MSDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dormMSDataSet3BindingSource
            // 
            this.dormMSDataSet3BindingSource.DataSource = this.dorm_MSDataSet3;
            this.dormMSDataSet3BindingSource.Position = 0;
            // 
            // dorm_MSDataSet3
            // 
            this.dorm_MSDataSet3.DataSetName = "Dorm_MSDataSet3";
            this.dorm_MSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dormMSDataSet3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftWare_Engineering.Report.ReportBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(728, 514);
            this.reportViewer1.TabIndex = 2;
            // 
            // Bill_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 514);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Bill_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill_Report";
            this.Load += new System.EventHandler(this.Bill_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dormMSDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorm_MSDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dormMSDataSet3BindingSource;
        private Dorm_MSDataSet3 dorm_MSDataSet3;
    }
}
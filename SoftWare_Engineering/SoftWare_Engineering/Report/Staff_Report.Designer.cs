namespace SoftWare_Engineering.Report
{
    partial class Staff_Report
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
            this.dorm_MSDataSet1 = new SoftWare_Engineering.Dorm_MSDataSet1();
            this.dormMSDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dorm_MSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormMSDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dormMSDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftWare_Engineering.Report.Report_Staff.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1102, 479);
            this.reportViewer1.TabIndex = 0;
            // 
            // dorm_MSDataSet1
            // 
            this.dorm_MSDataSet1.DataSetName = "Dorm_MSDataSet1";
            this.dorm_MSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dormMSDataSet1BindingSource
            // 
            this.dormMSDataSet1BindingSource.DataSource = this.dorm_MSDataSet1;
            this.dormMSDataSet1BindingSource.Position = 0;
            // 
            // Staff_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 479);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Staff_Report";
            this.Text = "Staff_Report";
            this.Load += new System.EventHandler(this.Staff_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dorm_MSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormMSDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dormMSDataSet1BindingSource;
        private Dorm_MSDataSet1 dorm_MSDataSet1;
    }
}
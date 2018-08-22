namespace JominyPredict
{
    partial class FormDataRpt
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
            this.tbSampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jominyDBDataSet1 = new JominyPredict.jominyDBDataSet1();
            this.tbSampleTableAdapter1 = new JominyPredict.jominyDBDataSet1TableAdapters.tbSampleTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbSampleTableAdapter = new JominyPredict.jominyDBDataSet1TableAdapters.tbSampleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbSampleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jominyDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSampleBindingSource
            // 
            this.tbSampleBindingSource.DataMember = "tbSample";
            this.tbSampleBindingSource.DataSource = this.jominyDBDataSet1;
            // 
            // jominyDBDataSet1
            // 
            this.jominyDBDataSet1.DataSetName = "jominyDBDataSet1";
            this.jominyDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSampleTableAdapter1
            // 
            this.tbSampleTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbSampleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JominyPredict.ReportSample.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1033, 666);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbSampleTableAdapter
            // 
            this.tbSampleTableAdapter.ClearBeforeFill = true;
            // 
            // FormDataRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 666);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormDataRpt";
            this.Text = "数据报表";
            this.Load += new System.EventHandler(this.FormDataRpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSampleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jominyDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private jominyDBDataSet1TableAdapters.tbSampleTableAdapter tbSampleTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbSampleBindingSource;
        private jominyDBDataSet1 jominyDBDataSet1;
        private jominyDBDataSet1TableAdapters.tbSampleTableAdapter tbSampleTableAdapter;
    }
}
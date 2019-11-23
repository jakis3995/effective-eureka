namespace TestingTask
{
    partial class ReportsForm
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
            this.testbaseDataSet = new TestingTask.testbaseDataSet();
            this.WorkersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorkersTableAdapter = new TestingTask.testbaseDataSetTableAdapters.WorkersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.testbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.WorkersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TestingTask.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(701, 406);
            this.reportViewer1.TabIndex = 0;
            // 
            // testbaseDataSet
            // 
            this.testbaseDataSet.DataSetName = "testbaseDataSet";
            this.testbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WorkersBindingSource
            // 
            this.WorkersBindingSource.DataMember = "Workers";
            this.WorkersBindingSource.DataSource = this.testbaseDataSet;
            // 
            // WorkersTableAdapter
            // 
            this.WorkersTableAdapter.ClearBeforeFill = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 406);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource WorkersBindingSource;
        private testbaseDataSet testbaseDataSet;
        private testbaseDataSetTableAdapters.WorkersTableAdapter WorkersTableAdapter;
    }
}
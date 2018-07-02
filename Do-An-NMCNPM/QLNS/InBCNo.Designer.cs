namespace QLNS
{
    partial class InBCNo
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
            this.DataSetBC = new QLNS.DataSetBC();
            this.THONGTINNOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.THONGTINNOTableAdapter = new QLNS.DataSetBCTableAdapters.THONGTINNOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THONGTINNOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.THONGTINNOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS.RPNo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetBC
            // 
            this.DataSetBC.DataSetName = "DataSetBC";
            this.DataSetBC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // THONGTINNOBindingSource
            // 
            this.THONGTINNOBindingSource.DataMember = "THONGTINNO";
            this.THONGTINNOBindingSource.DataSource = this.DataSetBC;
            // 
            // THONGTINNOTableAdapter
            // 
            this.THONGTINNOTableAdapter.ClearBeforeFill = true;
            // 
            // InBCNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InBCNo";
            this.Text = "InBCNo";
            this.Load += new System.EventHandler(this.InBCNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THONGTINNOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource THONGTINNOBindingSource;
        private DataSetBC DataSetBC;
        private DataSetBCTableAdapters.THONGTINNOTableAdapter THONGTINNOTableAdapter;
    }
}
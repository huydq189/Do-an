namespace QLNS
{
    partial class InTTTon
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
            this.THONGTINTONKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.THONGTINTONKHOTableAdapter = new QLNS.DataSetBCTableAdapters.THONGTINTONKHOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THONGTINTONKHOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.THONGTINTONKHOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS.BCTon.rdlc";
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
            // THONGTINTONKHOBindingSource
            // 
            this.THONGTINTONKHOBindingSource.DataMember = "THONGTINTONKHO";
            this.THONGTINTONKHOBindingSource.DataSource = this.DataSetBC;
            // 
            // THONGTINTONKHOTableAdapter
            // 
            this.THONGTINTONKHOTableAdapter.ClearBeforeFill = true;
            // 
            // InTTTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InTTTon";
            this.Text = "InTTTon";
            this.Load += new System.EventHandler(this.InTTTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THONGTINTONKHOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource THONGTINTONKHOBindingSource;
        private DataSetBC DataSetBC;
        private DataSetBCTableAdapters.THONGTINTONKHOTableAdapter THONGTINTONKHOTableAdapter;
    }
}
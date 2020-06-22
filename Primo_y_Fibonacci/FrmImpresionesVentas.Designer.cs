namespace Primo_y_Fibonacci
{
    partial class FrmImpresionesVentas
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
            this.ControlDataSet = new Primo_y_Fibonacci.ControlDataSet();
            this.ReportVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportVentasTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.ReportVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ControlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportVentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetRptVentas";
            reportDataSource1.Value = this.ReportVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Primo_y_Fibonacci.RptVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(880, 654);
            this.reportViewer1.TabIndex = 0;
            // 
            // ControlDataSet
            // 
            this.ControlDataSet.DataSetName = "ControlDataSet";
            this.ControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportVentasBindingSource
            // 
            this.ReportVentasBindingSource.DataMember = "ReportVentas";
            this.ReportVentasBindingSource.DataSource = this.ControlDataSet;
            // 
            // ReportVentasTableAdapter
            // 
            this.ReportVentasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmImpresionesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 657);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmImpresionesVentas";
            this.Text = "FrmImpresionesVentas";
            this.Load += new System.EventHandler(this.FrmImpresionesVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportVentasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportVentasBindingSource;
        private ControlDataSet ControlDataSet;
        private ControlDataSetTableAdapters.ReportVentasTableAdapter ReportVentasTableAdapter;
    }
}
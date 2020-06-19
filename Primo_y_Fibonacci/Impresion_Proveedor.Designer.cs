namespace Primo_y_Fibonacci
{
    partial class Impresion_Proveedor
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impresion_Proveedor));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ControlDataSet = new Primo_y_Fibonacci.ControlDataSet();
            this.ReportProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportProveedorTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.ReportProveedorTableAdapter();
            this.btnsalir = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ControlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportProveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetReportProveedor";
            reportDataSource1.Value = this.ReportProveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Primo_y_Fibonacci.ReportProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 71);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(670, 336);
            this.reportViewer1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(142, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(433, 38);
            label2.TabIndex = 37;
            label2.Text = "IMPRESION PROVEEDOR";
            // 
            // ControlDataSet
            // 
            this.ControlDataSet.DataSetName = "ControlDataSet";
            this.ControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportProveedorBindingSource
            // 
            this.ReportProveedorBindingSource.DataMember = "ReportProveedor";
            this.ReportProveedorBindingSource.DataSource = this.ControlDataSet;
            // 
            // ReportProveedorTableAdapter
            // 
            this.ReportProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(646, 2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(37, 37);
            this.btnsalir.TabIndex = 38;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Impresion_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 432);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(label2);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Impresion_Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Impresion_Proveedor";
            this.Load += new System.EventHandler(this.Impresion_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportProveedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportProveedorBindingSource;
        private ControlDataSet ControlDataSet;
        private ControlDataSetTableAdapters.ReportProveedorTableAdapter ReportProveedorTableAdapter;
        private System.Windows.Forms.Button btnsalir;
    }
}
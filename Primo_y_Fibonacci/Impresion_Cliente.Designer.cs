namespace Primo_y_Fibonacci
{
    partial class Impresion_Cliente
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
            System.Windows.Forms.Label label2;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impresion_Cliente));
            this.ReportClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ControlDataSet = new Primo_y_Fibonacci.ControlDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportClienteTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.ReportClienteTableAdapter();
            this.btnsalir = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportClienteBindingSource
            // 
            this.ReportClienteBindingSource.DataMember = "ReportCliente";
            this.ReportClienteBindingSource.DataSource = this.ControlDataSet;
            // 
            // ControlDataSet
            // 
            this.ControlDataSet.DataSetName = "ControlDataSet";
            this.ControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(128, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(398, 38);
            label2.TabIndex = 38;
            label2.Text = "IMPRESION CLIENTES";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "RptCliente";
            reportDataSource1.Value = this.ReportClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Primo_y_Fibonacci.RptCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(8, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(670, 336);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportClienteTableAdapter
            // 
            this.ReportClienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(648, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(33, 31);
            this.btnsalir.TabIndex = 39;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Impresion_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(686, 432);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(label2);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Impresion_Cliente";
            this.Text = "Impresion_Cliente";
            this.Load += new System.EventHandler(this.Impresion_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportClienteBindingSource;
        private ControlDataSet ControlDataSet;
        private ControlDataSetTableAdapters.ReportClienteTableAdapter ReportClienteTableAdapter;
        private System.Windows.Forms.Button btnsalir;
    }
}
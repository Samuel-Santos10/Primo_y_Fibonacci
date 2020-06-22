namespace Primo_y_Fibonacci
{
    partial class Impresion_Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impresion_Pedidos));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ControlDataSet = new Primo_y_Fibonacci.ControlDataSet();
            this.btnsalir = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportPedidoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.ReportPedidoTableAdapter();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(103, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(388, 38);
            label2.TabIndex = 39;
            label2.Text = "IMPRESION PEDIDOS";
            // 
            // ReportPedidoBindingSource
            // 
            this.ReportPedidoBindingSource.DataMember = "ReportPedido";
            this.ReportPedidoBindingSource.DataSource = this.ControlDataSet;
            // 
            // ControlDataSet
            // 
            this.ControlDataSet.DataSetName = "ControlDataSet";
            this.ControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(655, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(26, 28);
            this.btnsalir.TabIndex = 40;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dtReportPedido";
            reportDataSource1.Value = this.ReportPedidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Primo_y_Fibonacci.RptPedido.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(8, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(673, 342);
            this.reportViewer1.TabIndex = 41;
            // 
            // ReportPedidoTableAdapter
            // 
            this.ReportPedidoTableAdapter.ClearBeforeFill = true;
            // 
            // Impresion_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(686, 432);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Impresion_Pedidos";
            this.Text = "Impresion_Pedidos";
            this.Load += new System.EventHandler(this.Impresion_Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportPedidoBindingSource;
        private ControlDataSet ControlDataSet;
        private ControlDataSetTableAdapters.ReportPedidoTableAdapter ReportPedidoTableAdapter;
    }
}
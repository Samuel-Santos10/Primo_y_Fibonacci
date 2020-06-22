namespace Primo_y_Fibonacci
{
    partial class Impresion_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impresion_Categoria));
            System.Windows.Forms.Label label2;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnsalir = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ControlDataSet = new Primo_y_Fibonacci.ControlDataSet();
            this.ReportCategoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportCategoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.ReportCategoTableAdapter();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ControlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportCategoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(641, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(26, 28);
            this.btnsalir.TabIndex = 40;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(89, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(435, 38);
            label2.TabIndex = 39;
            label2.Text = "IMPRESION CATEGORIA";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "RptCatego";
            reportDataSource2.Value = this.ReportCategoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Primo_y_Fibonacci.ReportCatego.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(646, 266);
            this.reportViewer1.TabIndex = 41;
            // 
            // ControlDataSet
            // 
            this.ControlDataSet.DataSetName = "ControlDataSet";
            this.ControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportCategoBindingSource
            // 
            this.ReportCategoBindingSource.DataMember = "ReportCatego";
            this.ReportCategoBindingSource.DataSource = this.ControlDataSet;
            // 
            // ReportCategoTableAdapter
            // 
            this.ReportCategoTableAdapter.ClearBeforeFill = true;
            // 
            // Impresion_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(670, 378);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Impresion_Categoria";
            this.Text = "Impresion_Categoria";
            this.Load += new System.EventHandler(this.Impresion_Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportCategoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportCategoBindingSource;
        private ControlDataSet ControlDataSet;
        private ControlDataSetTableAdapters.ReportCategoTableAdapter ReportCategoTableAdapter;
    }
}
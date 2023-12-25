namespace Bay.Rep
{
    partial class sales_reprt_frm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet7 = new Bay.DataSet7();
            this.sale1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectdetalessalesreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.salesTableAdapter = new Bay.DataSet7TableAdapters.salesTableAdapter();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sale_1TableAdapter = new Bay.DataSet7TableAdapters.sale_1TableAdapter();
            this.select_detales_sales_reportTableAdapter = new Bay.DataSet7TableAdapters.select_detales_sales_reportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectdetalessalesreportBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.dataSet7;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sale1BindingSource
            // 
            this.sale1BindingSource.DataMember = "sale_1";
            this.sale1BindingSource.DataSource = this.dataSet7;
            // 
            // selectdetalessalesreportBindingSource
            // 
            this.selectdetalessalesreportBindingSource.DataMember = "select_detales_sales_report";
            this.selectdetalessalesreportBindingSource.DataSource = this.dataSet7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 69);
            this.panel1.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(94, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 36);
            this.button6.TabIndex = 48;
            this.button6.Text = "تحديث";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "البحث";
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsearch.Enabled = false;
            this.txtsearch.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(212, 13);
            this.txtsearch.MaxLength = 50;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(320, 33);
            this.txtsearch.TabIndex = 46;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.salesBindingSource;
            reportDataSource5.Name = "DataSet2";
            reportDataSource5.Value = this.sale1BindingSource;
            reportDataSource6.Name = "DataSet3";
            reportDataSource6.Value = this.selectdetalessalesreportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bay.Rep.sales_report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(663, 384);
            this.reportViewer1.TabIndex = 4;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "sales";
            this.salesBindingSource1.DataSource = this.dataSet7;
            // 
            // sale_1TableAdapter
            // 
            this.sale_1TableAdapter.ClearBeforeFill = true;
            // 
            // select_detales_sales_reportTableAdapter
            // 
            this.select_detales_sales_reportTableAdapter.ClearBeforeFill = true;
            // 
            // sales_reprt_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 461);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.Name = "sales_reprt_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير المشتريات";
            this.Load += new System.EventHandler(this.sales_reprt_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectdetalessalesreportBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtsearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource sale1BindingSource;
        private System.Windows.Forms.BindingSource selectdetalessalesreportBindingSource;
        private DataSet7TableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private DataSet7TableAdapters.sale_1TableAdapter sale_1TableAdapter;
        private DataSet7TableAdapters.select_detales_sales_reportTableAdapter select_detales_sales_reportTableAdapter;
    }
}
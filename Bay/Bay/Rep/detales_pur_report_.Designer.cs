namespace Bay.Rep
{
    partial class detales_pur_report_
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
            this.purchesesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Bay.DataSet2();
            this.purcheses1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectdetalespruncherreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.purchesesTableAdapter = new Bay.DataSet2TableAdapters.PurchesesTableAdapter();
            this.purcheses1TableAdapter = new Bay.DataSet2TableAdapters.Purcheses1TableAdapter();
            this.select_detales_pruncher_reportTableAdapter = new Bay.DataSet2TableAdapters.select_detales_pruncher_reportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.purchesesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purcheses1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectdetalespruncherreportBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // purchesesBindingSource
            // 
            this.purchesesBindingSource.DataMember = "Purcheses";
            this.purchesesBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purcheses1BindingSource
            // 
            this.purcheses1BindingSource.DataMember = "Purcheses1";
            this.purcheses1BindingSource.DataSource = this.dataSet2;
            // 
            // selectdetalespruncherreportBindingSource
            // 
            this.selectdetalespruncherreportBindingSource.DataMember = "select_detales_pruncher_report";
            this.selectdetalespruncherreportBindingSource.DataSource = this.dataSet2;
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.purchesesBindingSource;
            reportDataSource5.Name = "DataSet2";
            reportDataSource5.Value = this.purcheses1BindingSource;
            reportDataSource6.Name = "DataSet3";
            reportDataSource6.Value = this.selectdetalespruncherreportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bay.Rep.detales_pur.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(688, 467);
            this.reportViewer1.TabIndex = 0;
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
            this.panel1.Size = new System.Drawing.Size(688, 69);
            this.panel1.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(105, 13);
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
            this.label3.Location = new System.Drawing.Point(552, 16);
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
            this.txtsearch.Location = new System.Drawing.Point(223, 13);
            this.txtsearch.MaxLength = 50;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(320, 33);
            this.txtsearch.TabIndex = 46;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // purchesesTableAdapter
            // 
            this.purchesesTableAdapter.ClearBeforeFill = true;
            // 
            // purcheses1TableAdapter
            // 
            this.purcheses1TableAdapter.ClearBeforeFill = true;
            // 
            // select_detales_pruncher_reportTableAdapter
            // 
            this.select_detales_pruncher_reportTableAdapter.ClearBeforeFill = true;
            // 
            // detales_pur_report_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "detales_pur_report_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير الخالص";
            this.Load += new System.EventHandler(this.detales_pur_report__Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchesesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purcheses1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectdetalespruncherreportBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtsearch;
        //private DataSet2TableAdapters.select_detales_pruncher_reportTableAdapter select_detales_pruncher_reportTableAdapter;
        
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.BindingSource selectdetalespruncherreportBindingSource1;
        private System.Windows.Forms.BindingSource purchesesBindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource purcheses1BindingSource;
        private System.Windows.Forms.BindingSource selectdetalespruncherreportBindingSource;
        private DataSet2TableAdapters.PurchesesTableAdapter purchesesTableAdapter;
        private DataSet2TableAdapters.Purcheses1TableAdapter purcheses1TableAdapter;
        private DataSet2TableAdapters.select_detales_pruncher_reportTableAdapter select_detales_pruncher_reportTableAdapter;
    }
}
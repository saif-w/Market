namespace Bay.Rep
{
    partial class date_foater_report
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
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet4 = new Bay.DataSet4();
            this.foterdateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foter_dateTableAdapter = new Bay.DataSet4TableAdapters.foter_dateTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foterdateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateend
            // 
            this.dateend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateend.Font = new System.Drawing.Font("Tahoma", 13F);
            this.dateend.Location = new System.Drawing.Point(169, 18);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(200, 28);
            this.dateend.TabIndex = 0;
            // 
            // datestart
            // 
            this.datestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datestart.Font = new System.Drawing.Font("Tahoma", 13F);
            this.datestart.Location = new System.Drawing.Point(460, 18);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(200, 28);
            this.datestart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(672, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "البداية";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(387, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "النهاية";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(45, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateend);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.datestart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 69);
            this.panel1.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.foterdateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bay.Rep.foater_date.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(759, 427);
            this.reportViewer1.TabIndex = 6;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foterdateBindingSource
            // 
            this.foterdateBindingSource.DataMember = "foter_date";
            this.foterdateBindingSource.DataSource = this.dataSet4;
            // 
            // foter_dateTableAdapter
            // 
            this.foter_dateTableAdapter.ClearBeforeFill = true;
            // 
            // date_foater_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 496);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "date_foater_report";
            this.Text = "تقرير الفواتير";
            this.Load += new System.EventHandler(this.date_foater_report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foterdateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource foterdateBindingSource;
        private DataSet4 dataSet4;
        private DataSet4TableAdapters.foter_dateTableAdapter foter_dateTableAdapter;
    }
}
namespace QLBanHangQuanAo
{
    partial class BaoCao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetQuanAo = new QLBanHangQuanAo.datasetQuanAo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.MatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MatHangTableAdapter = new QLBanHangQuanAo.datasetQuanAoTableAdapters.MatHangTableAdapter();
            this.NhanVienTableAdapter = new QLBanHangQuanAo.datasetQuanAoTableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetQuanAo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this.datasetQuanAo;
            // 
            // datasetQuanAo
            // 
            this.datasetQuanAo.DataSetName = "datasetQuanAo";
            this.datasetQuanAo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.NhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLBanHangQuanAo.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(679, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(228, 7);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Go Report";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(54, 7);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(168, 22);
            this.txtTenHang.TabIndex = 2;
            // 
            // MatHangBindingSource
            // 
            this.MatHangBindingSource.DataMember = "MatHang";
            this.MatHangBindingSource.DataSource = this.datasetQuanAo;
            // 
            // MatHangTableAdapter
            // 
            this.MatHangTableAdapter.ClearBeforeFill = true;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 421);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BaoCao";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetQuanAo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MatHangBindingSource;
        private datasetQuanAo datasetQuanAo;
        private datasetQuanAoTableAdapters.MatHangTableAdapter MatHangTableAdapter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private datasetQuanAoTableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
    }
}
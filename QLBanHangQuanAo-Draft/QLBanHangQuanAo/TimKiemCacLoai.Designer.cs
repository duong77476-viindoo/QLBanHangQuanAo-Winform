namespace QLBanHangQuanAo
{
    partial class TimKiemCacLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemCacLoai));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDonDatHang = new System.Windows.Forms.TextBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtQuanAo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbDonDatHang = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbKhachHang = new System.Windows.Forms.RadioButton();
            this.rdbQuanAo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDonDatHang);
            this.groupBox1.Controls.Add(this.txtKhachHang);
            this.groupBox1.Controls.Add(this.txtQuanAo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdbDonDatHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbKhachHang);
            this.groupBox1.Controls.Add(this.rdbQuanAo);
            this.groupBox1.Location = new System.Drawing.Point(39, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn muốn tim kiếm?";
            // 
            // txtDonDatHang
            // 
            this.txtDonDatHang.Location = new System.Drawing.Point(319, 118);
            this.txtDonDatHang.Name = "txtDonDatHang";
            this.txtDonDatHang.Size = new System.Drawing.Size(100, 22);
            this.txtDonDatHang.TabIndex = 2;
            this.txtDonDatHang.TextChanged += new System.EventHandler(this.txtDonDatHang_TextChanged);
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(319, 82);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(100, 22);
            this.txtKhachHang.TabIndex = 1;
            this.txtKhachHang.TextChanged += new System.EventHandler(this.txtKhachHang_TextChanged);
            // 
            // txtQuanAo
            // 
            this.txtQuanAo.Location = new System.Drawing.Point(319, 52);
            this.txtQuanAo.Name = "txtQuanAo";
            this.txtQuanAo.Size = new System.Drawing.Size(100, 22);
            this.txtQuanAo.TabIndex = 0;
            this.txtQuanAo.TextChanged += new System.EventHandler(this.txtQuanAo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập đơn đặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập tên khách hàng";
            // 
            // rdbDonDatHang
            // 
            this.rdbDonDatHang.AutoSize = true;
            this.rdbDonDatHang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDonDatHang.Location = new System.Drawing.Point(31, 121);
            this.rdbDonDatHang.Name = "rdbDonDatHang";
            this.rdbDonDatHang.Size = new System.Drawing.Size(97, 17);
            this.rdbDonDatHang.TabIndex = 0;
            this.rdbDonDatHang.TabStop = true;
            this.rdbDonDatHang.Text = "Đơn đặt hàng";
            this.rdbDonDatHang.UseVisualStyleBackColor = true;
            this.rdbDonDatHang.CheckedChanged += new System.EventHandler(this.rdbDonDatHang_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập mặt hàng quần áo";
            // 
            // rdbKhachHang
            // 
            this.rdbKhachHang.AutoSize = true;
            this.rdbKhachHang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKhachHang.Location = new System.Drawing.Point(32, 82);
            this.rdbKhachHang.Name = "rdbKhachHang";
            this.rdbKhachHang.Size = new System.Drawing.Size(142, 17);
            this.rdbKhachHang.TabIndex = 0;
            this.rdbKhachHang.TabStop = true;
            this.rdbKhachHang.Text = "Danh mục khách hàng";
            this.rdbKhachHang.UseVisualStyleBackColor = true;
            this.rdbKhachHang.CheckedChanged += new System.EventHandler(this.rdbKhachHang_CheckedChanged);
            // 
            // rdbQuanAo
            // 
            this.rdbQuanAo.AutoSize = true;
            this.rdbQuanAo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbQuanAo.Location = new System.Drawing.Point(31, 48);
            this.rdbQuanAo.Name = "rdbQuanAo";
            this.rdbQuanAo.Size = new System.Drawing.Size(124, 17);
            this.rdbQuanAo.TabIndex = 0;
            this.rdbQuanAo.TabStop = true;
            this.rdbQuanAo.Text = "Danh mục quần áo";
            this.rdbQuanAo.UseVisualStyleBackColor = true;
            this.rdbQuanAo.CheckedChanged += new System.EventHandler(this.rdbQuanAo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(39, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 347);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tìm kiếm";
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimKiem.Location = new System.Drawing.Point(3, 18);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.Size = new System.Drawing.Size(665, 326);
            this.dgvTimKiem.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Location = new System.Drawing.Point(488, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 160);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nút";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(48, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 55);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(49, 96);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 55);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "TÌM KIẾM ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TimKiemCacLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimKiemCacLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TimKiemCacLoai";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDonDatHang;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtQuanAo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbDonDatHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbKhachHang;
        private System.Windows.Forms.RadioButton rdbQuanAo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.Label label4;
    }
}
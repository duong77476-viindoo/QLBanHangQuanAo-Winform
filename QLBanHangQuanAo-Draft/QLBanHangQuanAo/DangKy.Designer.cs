namespace QLBanHangQuanAo
{
    partial class DangKy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapTK = new System.Windows.Forms.TextBox();
            this.txtNhapMK = new System.Windows.Forms.TextBox();
            this.btnXacNhanDangKy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mật khẩu";
            // 
            // txtNhapTK
            // 
            this.txtNhapTK.Location = new System.Drawing.Point(105, 44);
            this.txtNhapTK.Name = "txtNhapTK";
            this.txtNhapTK.Size = new System.Drawing.Size(165, 22);
            this.txtNhapTK.TabIndex = 2;
            // 
            // txtNhapMK
            // 
            this.txtNhapMK.Location = new System.Drawing.Point(105, 106);
            this.txtNhapMK.Name = "txtNhapMK";
            this.txtNhapMK.Size = new System.Drawing.Size(165, 22);
            this.txtNhapMK.TabIndex = 2;
            // 
            // btnXacNhanDangKy
            // 
            this.btnXacNhanDangKy.Location = new System.Drawing.Point(40, 172);
            this.btnXacNhanDangKy.Name = "btnXacNhanDangKy";
            this.btnXacNhanDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhanDangKy.TabIndex = 3;
            this.btnXacNhanDangKy.Text = "Xác nhận";
            this.btnXacNhanDangKy.UseVisualStyleBackColor = true;
            this.btnXacNhanDangKy.Click += new System.EventHandler(this.btnXacNhanDangKy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "ĐĂNG KÝ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(151, 172);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 225);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXacNhanDangKy);
            this.Controls.Add(this.txtNhapMK);
            this.Controls.Add(this.txtNhapTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapTK;
        private System.Windows.Forms.TextBox txtNhapMK;
        private System.Windows.Forms.Button btnXacNhanDangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
    }
}
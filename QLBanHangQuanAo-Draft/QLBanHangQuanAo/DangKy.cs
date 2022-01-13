using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLBanHangQuanAo
{
    public partial class DangKy : DevExpress.XtraEditors.XtraForm
    {
        public DangKy()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69GQ9P6\DUONG135;Initial Catalog=TaiKhoan;Integrated Security=True");
        KetNoi cn = new KetNoi();

        private void btnXacNhanDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNhapMK.Text == "" || txtNhapTK.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                    return;
                }
                cn.ketNoi();
                string sql = "insert into Tai_Khoan values(@taikhoan,@matkhau,null,null)";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("taikhoan", txtNhapTK.Text);
                cmd.Parameters.AddWithValue("matkhau", txtNhapMK.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng ký thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                cn.dongKetnoi();
            }
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
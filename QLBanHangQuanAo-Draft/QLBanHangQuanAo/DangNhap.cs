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
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69GQ9P6\DUONG135;Initial Catalog=TaiKhoan;Integrated Security=True");
        KetNoi cn = new KetNoi();
        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ketNoi();
                string sql = "select * from Tai_Khoan where taikhoan = @taikhoan and matkhau = @matkhau";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("taikhoan", txtTaiKhoan.Text);
                cmd.Parameters.AddWithValue("matkhau", txtMatKhau.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    this.Hide();
                    Menu mn = new Menu();
                    mn.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi xảy ra khi đăng nhập");
            }
            finally
            {
                cn.dongKetnoi();
            }
            
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    }
}
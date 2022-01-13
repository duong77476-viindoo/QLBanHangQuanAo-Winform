using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBanHangQuanAo
{
    public partial class DonHangChiTiet : Form
    {
        public DonHangChiTiet()
        {
            InitializeComponent();
        }
        KetNoi cn = new KetNoi();
        private void tai_dl()
        {
            cn.ketNoi();
            string sql = "select sohoadon as N'Số hóa đơn', mahang as N'Mã Hàng', giaban as N'Giá bán', soluong as N'Số lượng', " +
                "mucgiamgia as N'Mức giảm giá' from ChiTietDatHang";
            cn.taiDL_DataGrid(sql, dgvDonHangChiTiet);
            cn.dongKetnoi();
        }
        private void XoaDulieu()
        {
            txtSoDonHang.Text = "";
            txtMaHang.Text = "";
            txtMucGiamGia.Text = "";
            mtbSoLuong.Text = "";
            mtbDonGia.Text = "";
            txtSoDonHang.Focus();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi form ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ketNoi();
                string sql = "delete from ChiTietDatHang where sohoadon = @sohoadon";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("sohoadon", txtSoDonHang.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi khi xoá");
            }
            finally
            {
                cn.dongKetnoi();
                tai_dl();
                XoaDulieu();
            }

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            XoaDulieu();
        }

        private void DonHangChiTiet_Load(object sender, EventArgs e)
        {
            tai_dl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ketNoi();
                string sql = "insert into ChiTietDatHang values(@sohoadon,@mahang,@giaban,@soluong,@mucgiamgia)";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("sohoadon", txtSoDonHang.Text);
                cmd.Parameters.AddWithValue("mahang", txtMaHang.Text);
                cmd.Parameters.AddWithValue("giaban", float.Parse(mtbDonGia.Text));
                cmd.Parameters.AddWithValue("soluong", int.Parse(mtbSoLuong.Text));
                cmd.Parameters.AddWithValue("mucgiamgia", int.Parse(txtMucGiamGia.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm");
            }
            finally
            {
                cn.dongKetnoi();
                tai_dl();
                
            }
        }

        private void dgvDonHangChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoDonHang.Text = dgvDonHangChiTiet.CurrentRow.Cells[0].Value.ToString();
            txtMaHang.Text = dgvDonHangChiTiet.CurrentRow.Cells[1].Value.ToString();
            mtbDonGia.Text = dgvDonHangChiTiet.CurrentRow.Cells[2].Value.ToString();
            mtbSoLuong.Text = dgvDonHangChiTiet.CurrentRow.Cells[3].Value.ToString();
            txtMucGiamGia.Text = dgvDonHangChiTiet.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ketNoi();
                string sql = "update ChiTietDatHang set mahang=@mahang,giaban=@giaban,soluong=@soluong,mucgiamgia=@mucgiamgia where sohoadon = @sohoadon";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("sohoadon", txtSoDonHang.Text);
                cmd.Parameters.AddWithValue("mahang", txtMaHang.Text);
                cmd.Parameters.AddWithValue("giaban", float.Parse(mtbDonGia.Text));
                cmd.Parameters.AddWithValue("soluong", int.Parse(mtbSoLuong.Text));
                cmd.Parameters.AddWithValue("mucgiamgia", int.Parse(txtMucGiamGia.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi khi sửa");
            }
            finally
            {
                cn.dongKetnoi();
                tai_dl();
                XoaDulieu();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

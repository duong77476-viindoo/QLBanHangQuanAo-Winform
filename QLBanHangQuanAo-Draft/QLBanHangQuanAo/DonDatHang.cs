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
    public partial class DonDatHang : DevExpress.XtraEditors.XtraForm
    {
        public DonDatHang()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69GQ9P6\DUONG135;Initial Catalog=QLBanHang;Integrated Security=True");
        KetNoi cn = new KetNoi();
        private void taiDL()
        {
            cn.ketNoi();
            string sql = "select dh.sohoadon,tenhang,tenkh,ten,ngaydathang,ngaygiaohang,ngaychuyenhang,noigiaohang " +
                " from DonDatHang dh inner join KhachHang kh on dh.makh = kh.makh inner join NhanVien nv on nv.manv = dh.manv "+
                "inner join ChiTietDatHang ctdh on ctdh.sohoadon = dh.sohoadon "
                +"inner join MatHang mh on mh.mahang = ctdh.mahang";
            cn.taiDL_DataGrid(sql, dgvDonDatHang);

            cn.dongKetnoi();
        }

        private void loadCBKhachHang()
        {
            cn.ketNoi();
            string sql = "select * from KhachHang";
            cn.taiDL_ComBoBox(sql, cbKhachHang);
            cbKhachHang.ValueMember = "makh";
            cbKhachHang.DisplayMember = "tenkh";
            cn.dongKetnoi();
        }

        private void loadCBNhanVien()
        {
            cn.ketNoi();
            string sql = "select * from NhanVien";
            cn.taiDL_ComBoBox(sql, cbNhanVien);
            cbNhanVien.ValueMember = "manv";
            cbNhanVien.DisplayMember = "ten";
            cn.dongKetnoi();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DonDatHang_Load(object sender, EventArgs e)
        {
            taiDL();
            loadCBKhachHang();
            loadCBNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ketNoi();
                string sql = "insert into DonDatHang values(@sohoadon,@makh,@manv,@ngaydathang,@ngaygiaohang,@ngaychuyenhang,@noigiaohang)";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("sohoadon", txtSoDonHang.Text);
                cmd.Parameters.AddWithValue("makh", cbKhachHang.SelectedValue);
                cmd.Parameters.AddWithValue("manv", cbNhanVien.SelectedValue);
                cmd.Parameters.AddWithValue("ngaydathang", dtpNgayDat.Value);
                cmd.Parameters.AddWithValue("ngaygiaohang", dtpNgayGiao.Value);
                cmd.Parameters.AddWithValue("ngaychuyenhang", dtpNgayChuyen.Value);
                cmd.Parameters.AddWithValue("noigiaohang", txtNoiGiao.Text);
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
                taiDL();
                XoaDuLieu();
            }
        }

        private void XoaDuLieu()
        {
            txtNoiGiao.Text = "";
            txtSoDonHang.Text = "";
            cbKhachHang.Text = "";
            cbNhanVien.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ketNoi();
                string sql = "update DonDatHang set makh = @makh, manv = @manv, ngaydathang = @ngaydathang,ngaygiaohang = @ngaygiaohang,ngaychuyenhang = @ngaychuyenhang,noigiaohang = @noigiaohang where sohoadon = @sohoadon";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("sohoadon", txtSoDonHang.Text);
                cmd.Parameters.AddWithValue("makh", cbKhachHang.SelectedValue);
                cmd.Parameters.AddWithValue("manv", cbNhanVien.SelectedValue);
                cmd.Parameters.AddWithValue("ngaydathang", dtpNgayDat.Value);
                cmd.Parameters.AddWithValue("ngaygiaohang", dtpNgayGiao.Value);
                cmd.Parameters.AddWithValue("ngaychuyenhang", dtpNgayChuyen.Value);
                cmd.Parameters.AddWithValue("noigiaohang", txtNoiGiao.Text);
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
                taiDL();
                XoaDuLieu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ketNoi();
                string sql = "delete from DonDatHang where sohoadon = @sohoadon";
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
                taiDL();
                XoaDuLieu();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            XoaDuLieu();
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

        private void dgvDonDatHang_SelectionChanged(object sender, EventArgs e)
        {
            txtSoDonHang.Text = dgvDonDatHang.CurrentRow.Cells[0].Value.ToString();
            txtMatHang.Text = dgvDonDatHang.CurrentRow.Cells[1].Value.ToString();
            cbKhachHang.Text = dgvDonDatHang.CurrentRow.Cells[2].Value.ToString();
            cbNhanVien.Text = dgvDonDatHang.CurrentRow.Cells[3].Value.ToString();
            dtpNgayDat.Text = dgvDonDatHang.CurrentRow.Cells[4].Value.ToString();
            dtpNgayGiao.Text = dgvDonDatHang.CurrentRow.Cells[5].Value.ToString();
            dtpNgayChuyen.Text = dgvDonDatHang.CurrentRow.Cells[6].Value.ToString();
            txtNoiGiao.Text = dgvDonDatHang.CurrentRow.Cells[7].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
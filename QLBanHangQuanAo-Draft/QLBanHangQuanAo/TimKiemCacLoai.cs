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
    public partial class TimKiemCacLoai : DevExpress.XtraEditors.XtraForm
    {
        public TimKiemCacLoai()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69GQ9P6\DUONG135;Initial Catalog=QLBanHang;Integrated Security=True");

        KetNoi cn = new KetNoi();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HienThiQuanAo()
        {
            cn.ketNoi();
            string sql = "SELECT mahang as N'Mà hàng',tenhang as N'Tên hàng',chatlieu N'Chất liệu',mausac as N'Màu sắc',size as N'Size',tenncc as N'Nhà cung cấp',soluong as N'Số lượng',dongia as N'Đơn giá',donvitinh as N'Đơn vị tính',tenloaihang as N'Loại hàng',img as N'Ảnh sản phẩm'"
                + " from MatHang mh inner join NhaCungCap ncc on mh.mancc = ncc.mancc inner join LoaiHang lh on mh.maloaihang = lh.maloaihang where tenhang like N'%"+txtQuanAo.Text+"%' ";
            cn.taiDL_DataGrid(sql, dgvTimKiem);

            cn.dongKetnoi();
        }

        private void HienThiKhachHang()
        {
            cn.ketNoi();
            string sql = "SELECT makh as N'Mã khách hàng',tenkh as N'Tên khách hàng',diachi as N'Địa chỉ',sdt as N'SĐT',email as N'Email', case gioitinh when 1 then N'Nam' when 0 then 'Nữ' end as N'Giới tính' from KhachHang where tenkh like N'%"+txtKhachHang.Text+"%'";
            cn.taiDL_DataGrid(sql,dgvTimKiem);

            cn.dongKetnoi();
        }

        private void HienThiDonDatHang()
        {
            cn.ketNoi();
            string sql = "select sohoadon,tenkh,ten,ngaydathang,ngaygiaohang,ngaychuyenhang,noigiaohang " +
                " from DonDatHang dh inner join KhachHang kh on dh.makh = kh.makh inner join NhanVien nv on nv.manv = dh.manv where tenkh like N'"+txtDonDatHang.Text+"'";
            cn.taiDL_DataGrid(sql, dgvTimKiem);

            cn.dongKetnoi();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdbQuanAo.Checked)
            {
                HienThiQuanAo();
            }
            else if (rdbKhachHang.Checked)
                HienThiKhachHang();
            else
                HienThiDonDatHang();
        }

        private void rdbQuanAo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbQuanAo.Checked == true)
            {
                txtKhachHang.Text = "";
                txtDonDatHang.Text = "";
                txtQuanAo.Enabled = true;
                txtDonDatHang.Enabled = false;
                txtKhachHang.Enabled = false;
            }
            else
            {
                txtQuanAo.Enabled = false;
            }
        }

        private void rdbKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbKhachHang.Checked == true)
            {
                txtDonDatHang.Text = "";
                txtQuanAo.Text = "";
                txtQuanAo.Enabled = false;
                txtDonDatHang.Enabled = false;
                txtKhachHang.Enabled = true;
            }
        }

        private void rdbDonDatHang_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbDonDatHang.Checked == true)
            {
                txtQuanAo.Text = "";
                txtKhachHang.Text = "";
                txtQuanAo.Enabled = false;
                txtDonDatHang.Enabled = true;
                txtKhachHang.Enabled = false;
            }
        }

        private void txtQuanAo_TextChanged(object sender, EventArgs e)
        {
            HienThiQuanAo();
        }

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {
            HienThiKhachHang();
        }

        private void txtDonDatHang_TextChanged(object sender, EventArgs e)
        {
            HienThiDonDatHang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }
    }
}
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
    public partial class KhachHang : DevExpress.XtraEditors.XtraForm
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69GQ9P6\DUONG135;Initial Catalog=QLBanHang;Integrated Security=True");
        KetNoi cn = new KetNoi();

        private void taiDL()
        {
            cn.ketNoi();
            string sql = "SELECT makh as N'Mã khách hàng',tenkh as N'Tên khách hàng',diachi as N'Địa chỉ',sdt as N'SĐT',email as N'Email', case gioitinh when 1 then N'Nam' when 0 then 'Nữ' end as N'Giới tính' from KhachHang";
            SqlCommand cmd = new SqlCommand(sql, cn.con);
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            dgvKhachHang.DataSource = dt;

            cn.dongKetnoi();
        }

        private void XoaDuLieu()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            mtbSDT.Text = "";
        }

        private byte SelectGioiTinh()
        {
            if (rdbNam.Checked)
            {
                return 1;
            }
            else
                return 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ketNoi();
                string sql = "insert into KhachHang values(@makh,@tenkh,@diachi,@sdt,@email,@gioitinh)";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("makh", txtMaKH.Text);
                cmd.Parameters.AddWithValue("tenkh", txtTenKH.Text);
                cmd.Parameters.AddWithValue("diachi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("sdt", mtbSDT.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("gioitinh", SelectGioiTinh());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
            }
            catch(Exception ex)
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ketNoi();
                string sql = "update KhachHang set tenkh = @tenkh,diachi = @diachi, sdt = @sdt, email = @email, gioitinh = @gioitinh where makh = @makh";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("makh", txtMaKH.Text);
                cmd.Parameters.AddWithValue("tenkh", txtTenKH.Text);
                cmd.Parameters.AddWithValue("diachi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("sdt", mtbSDT.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("gioitinh", SelectGioiTinh());
                cmd.ExecuteNonQuery();
                MessageBox.Show("sửa thành công");
            }
            catch (Exception ex)
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

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {

            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            mtbSDT.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            if (dgvKhachHang.CurrentRow.Cells[5].Value.ToString() == "Nam")
            {
                rdbNam.Checked = true;
            }
            else
                rdbNu.Checked = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ketNoi();
                string sql = "delete from KhachHang where makh = @makh";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("makh", txtMaKH.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá thành công");
            }
            catch (Exception ex)
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

        private void KhachHang_Load(object sender, EventArgs e)
        {
            taiDL();
        }
    }
}
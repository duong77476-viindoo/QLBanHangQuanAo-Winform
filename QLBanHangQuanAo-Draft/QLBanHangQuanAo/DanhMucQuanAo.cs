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
using System.IO;

namespace QLBanHangQuanAo
{
    public partial class DanhMucQuanAo : DevExpress.XtraEditors.XtraForm
    {
        public DanhMucQuanAo()
        {
            InitializeComponent();
        }

        KetNoi cn = new KetNoi();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void loadCBLoaiHang()
        {
            cn.ketNoi();
            string sql = "select * from LoaiHang";
            cn.taiDL_ComBoBox(sql,cbLoaiHang);
            cbLoaiHang.ValueMember = "maloaihang";
            cbLoaiHang.DisplayMember = "tenloaihang";
            cn.dongKetnoi();
        }

        private void loadCBNhaCungCap()
        {
            cn.ketNoi();
            string sql = "select * from NhaCungCap";
            cn.taiDL_ComBoBox(sql, cbNhaCungCap);
            cbNhaCungCap.ValueMember = "mancc";
            cbNhaCungCap.DisplayMember = "tenncc";
            cn.dongKetnoi();
        }

        private void loadCBsize()
        {
            cn.ketNoi();
            string sql = "select * from size";
            cn.taiDL_ComBoBox(sql, cbsize);
            cbsize.ValueMember = "id";
            cbsize.DisplayMember = "tensize";
            cn.dongKetnoi();
        }
        private void XoaDuLieu()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtChatLieu.Text = "";
            txtDonViTinh.Text = "";
            txtMauSac.Text = "";
            mtbDonGia.Text = "";
            mtbSoLuong.Text = "";
            picAnhSanPham.Image = null;
        }

        private void taiDL()
        {
            cn.ketNoi();
            string sql = "SELECT mahang as N'Mà hàng',tenhang as N'Tên hàng',chatlieu N'Chất liệu',mausac as N'Màu sắc',"
            +"size as N'Size',tenncc as N'Nhà cung cấp',soluong as N'Số lượng',dongia as N'Đơn giá',"
            +"donvitinh as N'Đơn vị tính',tenloaihang as N'Loại hàng',img as N'Ảnh sản phẩm'"
            +" from MatHang mh inner join NhaCungCap ncc on mh.mancc = ncc.mancc" 
            +" inner join LoaiHang lh on mh.maloaihang = lh.maloaihang ";
            cn.taiDL_DataGrid(sql, dgvQuanAo);
            cn.dongKetnoi();
         }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi form ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            XoaDuLieu();
        }

        private void dgvQuanAo_SelectionChanged(object sender, EventArgs e)
        {
            txtMaHang.Text = dgvQuanAo.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvQuanAo.CurrentRow.Cells[1].Value.ToString();
            txtChatLieu.Text = dgvQuanAo.CurrentRow.Cells[2].Value.ToString();
            txtMauSac.Text = dgvQuanAo.CurrentRow.Cells[3].Value.ToString();
            cbsize.Text = dgvQuanAo.CurrentRow.Cells[4].Value.ToString();
            cbNhaCungCap.Text = dgvQuanAo.CurrentRow.Cells[5].Value.ToString();
            mtbSoLuong.Text = dgvQuanAo.CurrentRow.Cells[6].Value.ToString();
            mtbDonGia.Text = dgvQuanAo.CurrentRow.Cells[7].Value.ToString();
            txtDonViTinh.Text = dgvQuanAo.CurrentRow.Cells[8].Value.ToString();
            cbLoaiHang.Text = dgvQuanAo.CurrentRow.Cells[9].Value.ToString();
            byte[] b = (byte[])dgvQuanAo.CurrentRow.Cells[10].Value;
            picAnhSanPham.Image = ByteArrayToImage(b);
        }

        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);// tạo một luồng có kho lưu trữ là bộ nhớ
            return Image.FromStream(m);//tạo ra một ảnh từ một data stream
        }

        private void DanhMucQuanAo_Load(object sender, EventArgs e)
        {
            taiDL();
            loadCBLoaiHang();
            loadCBNhaCungCap();
            loadCBsize();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHang.Text == "" || txtTenHang.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }
               
                if(picAnhSanPham.Image == null)
                {
                    MessageBox.Show("Bắt buộc phải có ảnh sản phẩm nhoé!");
                    return;
                }
                byte[] b = ImageToByteArray(picAnhSanPham.Image);
                cn.ketNoi();
                string sql = "insert into MatHang values(@mahang,@tenhang,@chatlieu,@mausac,@size,@mancc,@soluong,@dongia,@donvitinh,@maloaihang,@img)";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("mahang", txtMaHang.Text);
                cmd.Parameters.AddWithValue("tenhang", txtTenHang.Text);
                cmd.Parameters.AddWithValue("chatlieu", txtChatLieu.Text);
                cmd.Parameters.AddWithValue("mausac", txtMauSac.Text);
                cmd.Parameters.AddWithValue("size", cbsize.Text);
                cmd.Parameters.AddWithValue("mancc", cbNhaCungCap.SelectedValue);
                cmd.Parameters.AddWithValue("soluong", int.Parse(mtbSoLuong.Text));
                cmd.Parameters.AddWithValue("dongia", float.Parse(mtbDonGia.Text));
                cmd.Parameters.AddWithValue("donvitinh", txtDonViTinh.Text);
                cmd.Parameters.AddWithValue("maloaihang", cbLoaiHang.SelectedValue);
                cmd.Parameters.AddWithValue("img", b);
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

        //c1: chuyển image sang byte[]
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();//tạo 1 luồng để lưu trữ ảnh
            img.Save(m, System.Drawing.Imaging.ImageFormat.Bmp);//save ảnh vào 1 luồng theo một format nhất định
            return m.ToArray();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ketNoi();
                byte[] b = ImageToByteArray(picAnhSanPham.Image);
                string sql = "update MatHang set  tenhang=@tenhang, chatlieu=@chatlieu,mausac=@mausac,size=@size,mancc=@mancc,soluong=@soluong,dongia=@dongia,donvitinh=@donvitinh,maloaihang=@maloaihang, img = @img where mahang = @mahang";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("mahang", txtMaHang.Text);
                cmd.Parameters.AddWithValue("tenhang", txtTenHang.Text);
                cmd.Parameters.AddWithValue("chatlieu", txtChatLieu.Text);
                cmd.Parameters.AddWithValue("mausac", txtMauSac.Text);
                cmd.Parameters.AddWithValue("size", cbsize.Text);
                cmd.Parameters.AddWithValue("mancc", cbNhaCungCap.SelectedValue);
                cmd.Parameters.AddWithValue("soluong", int.Parse(mtbSoLuong.Text));
                cmd.Parameters.AddWithValue("dongia", float.Parse(mtbDonGia.Text));
                cmd.Parameters.AddWithValue("donvitinh", txtDonViTinh.Text);
                cmd.Parameters.AddWithValue("maloaihang", cbLoaiHang.SelectedValue);
                cmd.Parameters.AddWithValue("img", b);
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa",ex.ToString());
            }
            finally
            {
                cn.ketNoi();
                taiDL();
                XoaDuLieu();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ketNoi();
                string sql = "delete from MatHang where mahang = @mahang";
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.Parameters.AddWithValue("mahang", txtMaHang.Text);
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
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

        private void picAnhSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                //var filesize = new FileInfo(open.FileName).Length;
                //if(filesize > 100)
                //{
                //    MessageBox.Show("Dung lượng ảnh quá lớn");
                //    return;
                //}
                if (open.ShowDialog() == DialogResult.OK)
                {
                    picAnhSanPham.Image = Image.FromFile(open.FileName);
                    long filesize = new FileInfo(open.FileName).Length;//lấy dung lượng(byte) của ảnh
                    if (filesize > 1000000)                         //so sánh, nếu vượt quá giới hạn cho phép thì thông báo tới người dùng
                    {
                        MessageBox.Show("Dung lượng ảnh quá lớn");
                        picAnhSanPham.Image = null;
                        return;
                    }
                    this.Text = open.FileName;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi mở file", ex.ToString());
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvQuanAo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
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

namespace QLBanHangQuanAo
{
    public partial class Menu : DevExpress.XtraEditors.XtraForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quầnÁoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucQuanAo dmquanao = new DanhMucQuanAo();
            
            dmquanao.MdiParent = this;
            //dmquanao.Dock = DockStyle.Fill;
            //dmquanao.Size = MaximumSize;
            dmquanao.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
           
            kh.MdiParent = this;
            //kh.Dock = DockStyle.Fill;
            kh.Show();
        }

        private void hoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonDatHang hd = new DonDatHang();
            hd.MdiParent = this;
            //hd.Dock = DockStyle.Fill;
            hd.Show();
        }

        private void TimKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemCacLoai timkiem = new TimKiemCacLoai();
            timkiem.MdiParent = this;
            //timkiem.Dock = DockStyle.Fill;
            timkiem.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn chắc chắn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void chiTiếtĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonHangChiTiet dhct = new DonHangChiTiet();
            dhct.MdiParent = this;
            //dhct.Dock = DockStyle.Fill;
            dhct.Show();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCao bc = new BaoCao();
            bc.MdiParent = this;
            //bc.Dock = DockStyle.Fill;
            bc.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
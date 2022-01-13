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
    public partial class BaoCao : DevExpress.XtraEditors.XtraForm
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetQuanAo.MatHang' table. You can move, or remove it, as needed.

            //this.reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.MatHangTableAdapter.Fill(this.datasetQuanAo.MatHang,txtTenHang.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
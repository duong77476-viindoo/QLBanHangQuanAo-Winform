using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangQuanAo
{
    class KetNoi
    {
        public string ChuoiKetNoi = @"Data Source=DESKTOP-69GQ9P6\DUONG135;Initial Catalog=QLBanHang;Integrated Security=True";

        public SqlConnection con = new SqlConnection();

      
        public bool ketNoi()
        {
            try
            {
                con = new SqlConnection(ChuoiKetNoi);
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết trong class clsKetNoi " + ex.ToString());
            }
            return false;
        }

        public void taiDL_DataGrid(string sql, DataGridView dgv)
        {
            KetNoi cn = new KetNoi();
            cn.ketNoi();
            SqlCommand cmd = new SqlCommand(sql, cn.con);
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            cn.dongKetnoi();
            dgv.DataSource = dt;
        }

        public void taiDL_ComBoBox(string sql, ComboBox cb)
        {
            KetNoi cn = new KetNoi();
            cn.ketNoi();
            SqlCommand cmd = new SqlCommand(sql, cn.con);
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            cn.dongKetnoi();
            cb.DataSource = dt;
        }

        public void dongKetnoi()
        {
            con.Close();
        }
    }
}

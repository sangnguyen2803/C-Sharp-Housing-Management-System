using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaDat
{
    public partial class LichSuKH : Form
    {
        public LichSuKH()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = null;
        private void button2_Click(object sender, EventArgs e)
        {
            new KhachHang().Show();
            this.Hide();
        }

        private void LichSuKH_Load(object sender, EventArgs e)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=KhachHang;Password=A";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM MUA_NHA Where MaKH = N'KH001'";
            string sqlSelect_t = "SELECT * FROM THUE_NHA Where MaKH = 'KH001'";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            SqlCommand cmd_ = new SqlCommand(sqlSelect_t, sqlCon);
            SqlDataReader dr_ = cmd_.ExecuteReader();
            DataTable dt_ = new DataTable();
            dt_.Load(dr_);
            dataGridView2.DataSource = dt_;

            sqlCon.Close();
        }
    }
}

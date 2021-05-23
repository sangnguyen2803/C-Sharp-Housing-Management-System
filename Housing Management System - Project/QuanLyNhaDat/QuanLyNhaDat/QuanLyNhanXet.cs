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
    public partial class QuanLyNhanXet : Form
    {
        public QuanLyNhanXet()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = null;
        string MaNhanXet = "";
        public void getAll()
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM LICH_SU_XEM_NHA";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaXemNha"].Visible = false;


            sqlCon.Close();
        }

        private Boolean check_exist_MaLN(String MaLN)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM LOAI_NHA";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToString(dr["MaLN"]).Equals(MaLN))
                {
                    return true;
                }
            }

            sqlCon.Close();
            return false;
        }

        private Boolean check_exist_MaKH(String MaKH)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM KHACH_HANG";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToString(dr["MaKH"]).Equals(MaKH))
                {
                    return true;
                }
            }

            sqlCon.Close();
            return false;
        }

        private Boolean check_exist_MaNV(String MaNV)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM NHAN_VIEN";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToString(dr["MaNV"]).Equals(MaNV))
                {
                    return true;
                }
            }

            sqlCon.Close();
            return false;
        }

        private Boolean check_exist_MaNha(String MaNha)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM NHA";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToString(dr["MaNha"]).Equals(MaNha))
                {
                    return true;
                }
            }

            sqlCon.Close();
            return false;
        }

        private void QuanLyNhanXet_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtMaLoaiNha.Enabled = false;
            txtMaNha.Enabled = false;
            txtMaNV.Enabled = false;
            txtNgayXem.Enabled = false;
            txtNhanXet.Enabled = false;
            buttonHuy.Visible = false;
            buttonSave.Visible = false;
            this.getAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaiNha.Text = dataGridView1.Rows[e.RowIndex].Cells["MaLN"].FormattedValue.ToString();
            txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].FormattedValue.ToString();
            txtMaNha.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString();
            txtMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].FormattedValue.ToString();
            txtNgayXem.Text = dataGridView1.Rows[e.RowIndex].Cells["NgayXem"].FormattedValue.ToString();
            txtNhanXet.Text = dataGridView1.Rows[e.RowIndex].Cells["NhanXet"].FormattedValue.ToString();
            this.MaNhanXet = dataGridView1.Rows[e.RowIndex].Cells["MaXemNha"].FormattedValue.ToString();
            //////
            ///

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Ban muon xoa nhan xet nay?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
                {
                    if (this.MaNhanXet.Length > 0)
                    {
                        String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;";
                        sqlCon = new SqlConnection(strConnect);
                        sqlCon.Open();
                        string sqldelete = "DELETE FROM LICH_SU_XEM_NHA WHERE MaXemNha = N'" + this.MaNhanXet + "'";
                        SqlCommand cmd = new SqlCommand(sqldelete, sqlCon);
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();
                        MessageBox.Show("Xoa nhan xet thanh cong");
                        this.getAll();
                    }
                    else
                    {
                        MessageBox.Show("Xoa nhan xet that bai");
                    }

                }
            }
        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            buttonChinhSua.Visible = false;
            buttonThem.Visible = false;
            buttonHuy.Visible = true;
            buttonSave.Visible = true;

            txtMaKH.Enabled = true;
            txtMaLoaiNha.Enabled = true;
            txtMaNha.Enabled = true;
            txtMaNV.Enabled = true;
            txtNgayXem.Enabled = true;
            txtNhanXet.Enabled = true;

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtMaLoaiNha.Enabled = false;
            txtMaNha.Enabled = false;
            txtMaNV.Enabled = false;
            txtNgayXem.Enabled = false;
            txtNhanXet.Enabled = false;


            txtMaKH.Text = "";
            txtMaLoaiNha.Text = "";
            txtMaNha.Text = "";
            txtMaNV.Text = "";
            txtNgayXem.Text = "";
            txtNhanXet.Text = "";


            buttonChinhSua.Visible = true;
            buttonThem.Visible = true;
            buttonHuy.Visible = false;
            buttonSave.Visible = false;
            this.getAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.getAll();
        }


        private void SaveThongTin(String MaXemNha)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();


            string sqlUpdate = "UPDATE LICH_SU_XEM_NHA SET MaKH=N'" + txtMaKH.Text + "', MaNha = N'" + txtMaNha.Text + "', MaLN = N'" +
                txtMaLoaiNha.Text + "', MaNV = N'" + txtMaNV.Text +"', NgayXem = N'" + txtNgayXem.Text + "', NhanXet = N'" + txtNhanXet.Text + 
                "' Where " + "MaXemNha = N'" + MaXemNha + "'";
            SqlCommand cmd = new SqlCommand(sqlUpdate, sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show("Cap nhat thong tin thanh cong");
            this.getAll();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text.Length > 0 && txtMaLoaiNha.Text.Length > 0 && txtMaNha.Text.Length > 0 &&
                txtMaNV.Text.Length > 0 && txtNgayXem.Text.Length > 0 && txtNhanXet.Text.Length > 0){
                if (this.check_exist_MaKH(txtMaKH.Text) && this.check_exist_MaLN(txtMaLoaiNha.Text) && this.check_exist_MaNha(txtMaNha.Text)
                    && this.check_exist_MaNV(txtMaNV.Text))
                {
                    this.SaveThongTin(this.MaNhanXet);
                    txtMaKH.Enabled = false;
                    txtMaLoaiNha.Enabled = false;
                    txtMaNha.Enabled = false;
                    txtMaNV.Enabled = false;
                    txtNgayXem.Enabled = false;
                    txtNhanXet.Enabled = false;


                    txtMaKH.Text = "";
                    txtMaLoaiNha.Text = "";
                    txtMaNha.Text = "";
                    txtMaNV.Text = "";
                    txtNgayXem.Text = "";
                    txtNhanXet.Text = "";


                    buttonChinhSua.Visible = true;
                    buttonThem.Visible = true;
                    buttonHuy.Visible = false;
                    buttonSave.Visible = false;
                    this.getAll();
                }
                else
                {
                    MessageBox.Show("Thong tin chua chinh xac");
                }
            }
            else{
                MessageBox.Show("Thieu thong tin");
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {


                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();

                string sqlSelect = "SELECT * FROM LICH_SU_XEM_NHA";
                SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                List<int> index = new List<int>();
                int k = 0;
                while (dr.Read())
                {
                    if (!Convert.ToString(dr["MaKH"]).Equals(txtTimKiem.Text))
                    {
                        index.Add(k);
                        Console.Out.WriteLine(Convert.ToString(dr["MaKH"]));
                        Console.Out.WriteLine(txtTimKiem.Text);
                        Console.Out.WriteLine(k);
                    }
                    k++;
                }
                this.getAll();

                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                currencyManager1.SuspendBinding();
                for (var i = 0; i < index.Count; i++)
                {
                    dataGridView1.Rows[index[i]].Visible = false;
                }
                currencyManager1.ResumeBinding();

                sqlCon.Close();


            }
            else
            {
                this.getAll();
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ThemNhanXet().Show();
        }
    }
}

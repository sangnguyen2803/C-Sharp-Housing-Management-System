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
    public partial class QuanLyMuaNha : Form
    {
        public QuanLyMuaNha()
        {
            InitializeComponent();
        }
        String MaMua = "";
        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            buttonChinhSua.Visible = false;
            buttonHuy.Visible = true;
            buttonSave.Visible = true;
           
            txtMaKH.Enabled = true;
            txtMaNha.Enabled = true;
            txtGiaBan.Enabled = true;
            txtNgayMua.Enabled = true;
            txtDieuKien.Enabled = true;

        }
        SqlConnection sqlCon = null;
        public void getAll()
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM MUA_NHA";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
          

            sqlCon.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMua.Text = dataGridView1.Rows[e.RowIndex].Cells["MaMua"].FormattedValue.ToString();
            txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].FormattedValue.ToString();
            txtMaNha.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString();
            txtGiaBan.Text = dataGridView1.Rows[e.RowIndex].Cells["GiaBan"].FormattedValue.ToString();
            txtNgayMua.Text = dataGridView1.Rows[e.RowIndex].Cells["NgayMua"].FormattedValue.ToString();
            txtDieuKien.Text = dataGridView1.Rows[e.RowIndex].Cells["DieuKien"].FormattedValue.ToString();
           


            /////////////////////
            

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Ban muon xoa mua nha nay?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
                {
                    if (txtMaMua.Text.Length > 0)
                    {
                        String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;";
                        sqlCon = new SqlConnection(strConnect);
                        sqlCon.Open();
                        string sqldelete = "DELETE FROM MUA_NHA WHERE MaMua = N'" + txtMaMua.Text + "'";
                        SqlCommand cmd = new SqlCommand(sqldelete, sqlCon);
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();
                        MessageBox.Show("Xoa mua nha thanh cong");
                        this.getAll();
                    }
                    else
                    {
                        MessageBox.Show("Xoa mua nha that bai");
                    }

                }
            }

        }

        private void QuanLyMuaNha_Load(object sender, EventArgs e)
        {
            txtMaMua.Enabled = false;
            txtMaKH.Enabled = false;
            txtMaNha.Enabled = false;
            txtGiaBan.Enabled = false;
            txtNgayMua.Enabled = false;
            txtDieuKien.Enabled = false;
            buttonHuy.Visible = false;
            buttonSave.Visible = false;

            this.getAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.getAll();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            txtMaMua.Enabled = false;
            txtMaKH.Enabled = false;
            txtMaNha.Enabled = false;
            txtGiaBan.Enabled = false;
            txtNgayMua.Enabled = false;
            txtDieuKien.Enabled = false;
            buttonHuy.Visible = false;
            buttonSave.Visible = false;
            buttonChinhSua.Visible = true;
            this.getAll();
            txtMaMua.Text = "";
            txtMaKH.Text = "";
            txtMaNha.Text = "";
            txtGiaBan.Text = "";
            txtNgayMua.Text = "";
            txtDieuKien.Text = "";

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
        private void SaveThongTin()
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();
           
           
            string sqlUpdate = "UPDATE MUA_NHA SET MaKH=N'" + txtMaKH.Text + "', MaNha = N'" + txtMaNha.Text + "', GiaBan = N'" +
                txtGiaBan.Text + "', NgayMua = N'" + txtNgayMua.Text + "', DieuKien = N'" + txtDieuKien.Text  + "' Where " +
                "MaMua = N'" + txtMaMua.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlUpdate, sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show("Cap nhat thong tin thanh cong");
            this.getAll();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(txtDieuKien.Text.Length > 0 && txtGiaBan.Text.Length > 0 && txtMaKH.Text.Length > 0 && txtMaNha.Text.Length > 0
                && txtNgayMua.Text.Length > 0)
            {
                if(this.check_exist_MaKH(txtMaKH.Text) && this.check_exist_MaNha(txtMaNha.Text))
                {
                    this.SaveThongTin();
                    txtMaMua.Enabled = false;
                    txtMaKH.Enabled = false;
                    txtMaNha.Enabled = false;
                    txtGiaBan.Enabled = false;
                    txtNgayMua.Enabled = false;
                    txtDieuKien.Enabled = false;
                    buttonHuy.Visible = false;
                    buttonSave.Visible = false;
                    buttonChinhSua.Visible = true;
                  
                    txtMaMua.Text = "";
                    txtMaKH.Text = "";
                    txtMaNha.Text = "";
                    txtGiaBan.Text = "";
                    txtNgayMua.Text = "";
                    txtDieuKien.Text = "";
                }
                else
                {
                    MessageBox.Show("Thong tin sai");
                }
            }
            else
            {
                MessageBox.Show("Thieu thong tin");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Length > 0)
            {
               

                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();

                string sqlSelect = "SELECT * FROM MUA_NHA";
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
    }
}

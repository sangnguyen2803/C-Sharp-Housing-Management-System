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
    public partial class BaiDang : Form
    {
        public BaiDang()
        {
            InitializeComponent();
            ThongTin.Visible = false;
            FormBaiDang.Visible = false;
            DataLoad.Visible = false;
        }
        SqlConnection sqlCon = null;
        private void button1_Click(object sender, EventArgs e)
        {
            DataLoad.Visible = false;
            FormBaiDang.Visible = false;
            ThongTin.Visible = true;
            button6.Visible = true;
            this.getInfo();
            
        }

        public void getInfo()
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=ChuNha;Password=B";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM CHU_NHA WHERE MaChuNha = N'MCN001'";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            string hoten = "", diachi ="", sdt = "", macn = "";
            Boolean b = true;
            while (dr.Read())
            {
                macn = Convert.ToString(dr["MaChuNha"]);
                hoten = Convert.ToString(dr["HoTen"]);
                sdt = Convert.ToString(dr["Sdt"]);
                diachi = Convert.ToString(dr["DiaChi"]);
            }
            txtHoTen.Text = hoten;
            txtMaChuNha.Text = macn;
            txtSdt.Text = sdt;
            txtAdress.Text = diachi;
            sqlCon.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataLoad.Visible = false;
            ThongTin.Visible = false;
            FormBaiDang.Visible = true;
           
        }

        private void BaiDang_Load(object sender, EventArgs e)
        {
            txtMaChuNha.Enabled = false;
            txtHoTen.Enabled = false;
            txtSdt.Enabled = false;
            txtAdress.Enabled = false;
            buttonHuy.Visible = false;
            buttonSave.Visible = false;
            button6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThongTin.Visible = false;
            FormBaiDang.Visible = false;
            DataLoad.Visible = false;
            button6.Visible = false;
            buttonHuy.Visible = false;
            buttonSave.Visible = false;
            txtDate.Clear();
            txtMaChuNha.Clear();
            txtMaNha.Clear();
            
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(txtMCN.Text != "" && txtMaNha.Text != "" && txtDate.Text != "" && (radioButton1.Checked || radioButton2.Checked))
            {
                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=ChuNha;Password=B";

                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();

                string sqlInsert = "INSERT INTO BAI_DANG VALUES (@Loai, @MaNha, @MaChuNha, @NgayDang)";
                SqlCommand cmd = new SqlCommand(sqlInsert, sqlCon);
                if (radioButton2.Checked)
                {
                    cmd.Parameters.AddWithValue("Loai", false);
                }
                else
                {
                    cmd.Parameters.AddWithValue("Loai", true);
                }
                cmd.Parameters.AddWithValue("MaNha", txtMaNha.Text);
                cmd.Parameters.AddWithValue("MaChuNha", txtMCN.Text);
                cmd.Parameters.AddWithValue("NgayDang", txtDate.Text);
                txtDate.Clear();
                txtMaChuNha.Clear();
                txtMaNha.Clear();
               
                MessageBox.Show("Tao bai dang thanh cong");
                cmd.ExecuteNonQuery();

                sqlCon.Close();
            }
            else
            {
                if(txtDate.Text == "")
                {
                    ErrorDate.Text =  "Ngay dang ki trong";
                }
                else
                {
                    ErrorDate.Clear();
                }

                if (txtMaNha.Text == "")
                {
                    ErrorMaNha.Text = "Ma nha trong";
                }
                else
                {
                    String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=ChuNha;Password=B";

                    sqlCon = new SqlConnection(strConnect);
                    sqlCon.Open();

                    string sqlSelect = "SELECT * FROM BAI_DANG";
                    SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    Boolean b = true;
                    while(dr.Read())
                    {

                        if (Convert.ToString(dr["MaNha"]).Equals(txtMaNha.Text))
                        {
                            b = false;
                        }
                    }
                    if(b)
                    {
                        ErrorMaNha.Clear();
                    }
                    else
                    {
                        ErrorMaNha.Text = "Ma nha da ton tai";
                    }
                    sqlCon.Close();

                }
                if (txtMaChuNha.Text == "")
                {
                    ErrorMCN.Text = "Ma chu nha trong";
                }
                else
                {
                    ErrorMCN.Clear();
                }
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    ErrorDate.Text = "Loai bai dang chua duoc chon";
                }
                else
                {
                    ErrorLoai.Clear();
                }
            }
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            
            ThongTin.Visible = false;
            FormBaiDang.Visible = false;
            DataLoad.Visible = true;
            txtDate.Clear();
            txtMaChuNha.Clear();
            txtMaNha.Clear();

            
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=ChuNha;Password=B";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM BAI_DANG";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonHuy.Visible = true;
            buttonSave.Visible = true;
            button6.Visible = false;
   
            txtHoTen.Enabled = true;
            txtSdt.Enabled = true;
            txtAdress.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        public void getAll()
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=ChuNha;Password=B";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM BAI_DANG";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Ban muon mua xoa bai viet nay?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                   
                    String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=ChuNha;Password=B";

                    sqlCon = new SqlConnection(strConnect);
                    sqlCon.Open();
                    string mabd = dataGridView1.Rows[e.RowIndex].Cells["MaBaiDang"].FormattedValue.ToString();
                    string sqlDelete = "Delete from BAI_DANG where MaBaiDang = N'" + mabd + "'";
                    SqlCommand cmd = new SqlCommand(sqlDelete, sqlCon);
                    SqlDataReader dr = cmd.ExecuteReader();
              
                   
                    sqlCon.Close();

                    MessageBox.Show("Xoa bai dang thanh cong");

                    this.getAll();

                }
              

            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            buttonHuy.Visible = false;
            buttonSave.Visible = false;
            this.getInfo();
            txtMaChuNha.Enabled = false;
            txtHoTen.Enabled = false;
            txtSdt.Enabled = false;
            txtAdress.Enabled = false;
        }

      

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text.Length > 0 && txtAdress.Text.Length > 0  && txtSdt.Text.Length > 0)
            {
                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=ChuNha;Password=B";

                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
                
                string sqlUpdate = "Update CHU_NHA SET HoTen = N'" + txtHoTen.Text + "', Sdt = N'" + txtSdt.Text + "', DiaChi = " +
                    "N'" + txtAdress.Text + "' Where MaChuNha = N'MCN001'";
                SqlCommand cmd = new SqlCommand(sqlUpdate, sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();


                sqlCon.Close();

                MessageBox.Show("Lua thong tin thanh cong");

             
                buttonHuy.Visible = false;
                buttonSave.Visible = false;
                this.getInfo();
                txtMaChuNha.Enabled = false;
                txtHoTen.Enabled = false;
                txtSdt.Enabled = false;
                txtAdress.Enabled = false;
            }
            else
            {
                MessageBox.Show("Dien thieu thong tin");

            }
        }
    }
}

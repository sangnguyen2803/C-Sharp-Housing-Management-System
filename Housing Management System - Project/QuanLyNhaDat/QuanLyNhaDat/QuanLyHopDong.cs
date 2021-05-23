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
    public partial class QuanLyHopDong : Form
    {
        public QuanLyHopDong()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = null;
        string MaHopDong = "";

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
        public void getAll()
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM HOP_DONG";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaHD"].Visible = false;


            sqlCon.Close();
        }
        private void QuanLyHopDong_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtMaLoaiNha.Enabled = false;
            txtMaNha.Enabled = false;
            txtMaNV.Enabled = false;
            txtNgayLap.Enabled = false;
            checkMua.Enabled = false;
            CheckThue.Enabled = false;
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
            txtNgayLap.Text = dataGridView1.Rows[e.RowIndex].Cells["NgayLap"].FormattedValue.ToString();
            if(Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["Loai"].FormattedValue.ToString()))
            {
                checkMua.Checked = true;
                CheckThue.Checked = false;
            }
            else
            {
                checkMua.Checked = false;
                CheckThue.Checked = true;

            }
            this.MaHopDong = dataGridView1.Rows[e.RowIndex].Cells["MaHD"].FormattedValue.ToString();
            //////
            ///

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Ban muon xoa hop dong nay?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
                {
                    if (this.MaHopDong.Length > 0)
                    {
                        String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;";
                        sqlCon = new SqlConnection(strConnect);
                        sqlCon.Open();
                        string sqldelete = "DELETE FROM HOP_DONG WHERE MaHD = N'" + this.MaHopDong + "'";
                        SqlCommand cmd = new SqlCommand(sqldelete, sqlCon);
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();
                        MessageBox.Show("Xoa hop dong thanh cong");
                        this.getAll();
                    }
                    else
                    {
                        MessageBox.Show("Xoa hop dong that bai");
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
            txtNgayLap.Enabled = true;
            checkMua.Enabled = true;
            CheckThue.Enabled = true;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtMaLoaiNha.Enabled = false;
            txtMaNha.Enabled = false;
            txtMaNV.Enabled = false;
            txtNgayLap.Enabled = false;
            checkMua.Enabled = false;
            CheckThue.Enabled = false;

            txtMaKH.Text = "";
            txtMaLoaiNha.Text = "";
            txtMaNha.Text = "";
            txtMaNV.Text = "";
            txtNgayLap.Text = "";
            checkMua.Checked = false;
            CheckThue.Checked = false;


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


        public void SaveThongTin(string maHD)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string loai = "";
            if (checkMua.Checked)
            {
                loai = "1";
            }
            else
            {
                loai = "0";
            }
            string sqlUpdate = "UPDATE HOP_DONG SET MaKH=N'" + txtMaKH.Text + "', MaNha = N'" + txtMaNha.Text + "', MaLN = N'" +
                txtMaLoaiNha.Text + "', MaNV = N'" + txtMaNV.Text + "', NgayLap = N'" + txtNgayLap.Text + "', Loai = " + loai +
                " Where " + "MaHD = N'" + maHD + "'";
            SqlCommand cmd = new SqlCommand(sqlUpdate, sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show("Cap nhat thong tin thanh cong");
            this.getAll();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length > 0 && txtMaLoaiNha.Text.Length > 0 && txtMaNha.Text.Length > 0 &&
                txtMaNV.Text.Length > 0 && txtNgayLap.Text.Length > 0 && (checkMua.Checked || CheckThue.Checked))
            {
                if (this.check_exist_MaKH(txtMaKH.Text) && this.check_exist_MaLN(txtMaLoaiNha.Text) && this.check_exist_MaNha(txtMaNha.Text)
                    && this.check_exist_MaNV(txtMaNV.Text))
                {
                    this.SaveThongTin(this.MaHopDong);
                    txtMaKH.Enabled = false;
                    txtMaLoaiNha.Enabled = false;
                    txtMaNha.Enabled = false;
                    txtMaNV.Enabled = false;
                    txtNgayLap.Enabled = false;
                    checkMua.Enabled = false;
                    CheckThue.Enabled = false;

                    txtMaKH.Text = "";
                    txtMaLoaiNha.Text = "";
                    txtMaNha.Text = "";
                    txtMaNV.Text = "";
                    txtNgayLap.Text = "";
                    checkMua.Checked = false;
                    CheckThue.Checked = false;


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
            else
            {
                MessageBox.Show("Thieu thong tin");
            }
        }

        private void CheckThue_Click(object sender, EventArgs e)
        {
            checkMua.Checked = false;
            CheckThue.Checked = true;
        }

        private void checkMua_Click(object sender, EventArgs e)
        {
            checkMua.Checked = true;
            CheckThue.Checked = false;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {


                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();

                string sqlSelect = "SELECT * FROM HOP_DONG";
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
            new ThemHopDong().Show();
        }
    }
}

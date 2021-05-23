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
    public partial class QuanLyKH : Form
    {
        public QuanLyKH()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = null;
        String maKh = "";
        public void getAllClient()
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM KHACH_HANG";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaKH"].Visible = false;

            sqlCon.Close();

        }

        private Boolean check_exist_MaChiNhanh(String MaChiNhanh)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM CHI_NHANH";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToString(dr["MaCN"]).Equals(MaChiNhanh))
                {
                    return true;
                }
            }

            sqlCon.Close();
            return false;
        }

        private Boolean check_exist_MaNhanVien(String MaNhanVien)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM NHAN_VIEN";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToString(dr["MaNV"]).Equals(MaNhanVien))
                {
                    return true;
                }
            }

            sqlCon.Close();
            return false;
        }
        private void QuanLyKH_Load(object sender, EventArgs e)
        {
            buttonHuy.Visible = false;
            buttonSave.Visible = false;

            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtMaChiNhanh.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtSdt.Enabled = false;
            txtThongTinYC.Enabled = false;
            txtTieuChi.Enabled = false;
            checkNam.Enabled = false;
            checkNu.Enabled = false;


            this.getAllClient();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].FormattedValue.ToString();
            txtHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells["HoTen"].FormattedValue.ToString();
            txtSdt.Text = dataGridView1.Rows[e.RowIndex].Cells["Sdt"].FormattedValue.ToString();
            txtTieuChi.Text = dataGridView1.Rows[e.RowIndex].Cells["TieuChi"].FormattedValue.ToString();
            txtThongTinYC.Text = dataGridView1.Rows[e.RowIndex].Cells["ThongTinYC"].FormattedValue.ToString();
            txtMaChiNhanh.Text = dataGridView1.Rows[e.RowIndex].Cells["MaCN"].FormattedValue.ToString();
            txtMaNhanVien.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].FormattedValue.ToString();

            this.maKh = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].FormattedValue.ToString();

            if (dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].FormattedValue.ToString().Equals("nam")){
                checkNam.Checked = true;
                checkNu.Checked = false;
            }
            else
            {
                checkNu.Checked = true;
                checkNam.Checked = false;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Ban muon xoa khach hang nay?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
                {
                    if (this.maKh.Length > 0)
                    {
                        String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;";
                        sqlCon = new SqlConnection(strConnect);
                        sqlCon.Open();
                        string sqldelete = "DELETE FROM KHACH_HANG WHERE MaKH = N'" + this.maKh + "'";
                        SqlCommand cmd = new SqlCommand(sqldelete, sqlCon);
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();
                        MessageBox.Show("Xoa khach hang thanh cong");
                        this.getAllClient();
                    }
                    else
                    {
                        MessageBox.Show("Xoa khach hang that bai");
                    }

                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "SoNhaSoHuu")
            {
                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;";
                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand("DemNha_KH_T1", sqlCon);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = this.maKh;
                cmd.Parameters.Add("@nb", SqlDbType.Int).Direction = ParameterDirection.Output;
               cmd.Parameters.Add("@nb1", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
            //    cmd.Parameters.Add("@nb2", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                int nb = Convert.ToInt32(cmd.Parameters["@nb"].Value);
                MessageBox.Show("So nha so huu: " + cmd.Parameters["@nb1"].Value + " (" + nb + " ngoi nha)");
               
                
                sqlCon.Close();
            }    


        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            buttonHuy.Visible = true;
            buttonSave.Visible = true;

            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMaChiNhanh.Enabled = true;
            txtMaNhanVien.Enabled = true;
            txtSdt.Enabled = true;
            txtThongTinYC.Enabled = true;
            txtTieuChi.Enabled = true;
            checkNam.Enabled = true;
            checkNu.Enabled = true;

            buttonChinhSua.Visible = false;
            buttonThemKhachHang.Visible = false;

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            buttonHuy.Visible = false;
            buttonSave.Visible = false;

            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtMaChiNhanh.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtSdt.Enabled = false;
            txtThongTinYC.Enabled = false;
            txtTieuChi.Enabled = false;
            checkNam.Enabled = false;
            checkNu.Enabled = false;

            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtMaChiNhanh.Text = "";
            txtMaNhanVien.Text = "";
            txtSdt.Text = "";
            txtThongTinYC.Text = "";
            txtTieuChi.Text = "";
            checkNam.Checked = false;
            checkNu.Checked = false;

            buttonChinhSua.Visible = true;
            buttonThemKhachHang.Visible = true;

            this.getAllClient();
        }
        private void SaveThongTin(String _maKH)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();
            string tinhtrang = "";
            if (checkNam.Checked)
            {
                tinhtrang = "nam";
            }
            else
            {
                tinhtrang = "nu";
            }
            string sqlUpdate = "UPDATE KHACH_HANG SET HoTen=N'" + txtHoTen.Text + "', Sdt = N'" + txtSdt.Text + "', DiaChi = N'" + 
                txtDiaChi.Text + "', GioiTinh = N'" + tinhtrang + "', ThongTinYC = N'" + txtThongTinYC.Text + "', TieuChi = N'" + 
                txtTieuChi.Text + "', MaCN = N'" + txtMaChiNhanh.Text + "', MaNV = N'" + txtMaNhanVien.Text + "' Where " +
                "MaKH = N'" + _maKH + "'"; 
            SqlCommand cmd = new SqlCommand(sqlUpdate, sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show("Cap nhat thong tin thanh cong");
            this.getAllClient();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(txtDiaChi.Text.Length > 0 && txtHoTen.Text.Length > 0 && txtMaChiNhanh.Text.Length > 0 && txtMaNhanVien.Text.Length > 0
                && txtSdt.Text.Length > 0 && txtThongTinYC.Text.Length > 0 && txtTieuChi.Text.Length > 0 && (checkNam.Checked ||
                checkNu.Checked))
            {
                if(this.check_exist_MaChiNhanh(txtMaChiNhanh.Text) && this.check_exist_MaNhanVien(txtMaNhanVien.Text))
                {
                    this.SaveThongTin(this.maKh);

                    buttonHuy.Visible = false;
                    buttonSave.Visible = false;

                    txtHoTen.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtMaChiNhanh.Enabled = false;
                    txtMaNhanVien.Enabled = false;
                    txtSdt.Enabled = false;
                    txtThongTinYC.Enabled = false;
                    txtTieuChi.Enabled = false;
                    checkNam.Enabled = false;
                    checkNu.Enabled = false;

                    txtHoTen.Text = "";
                    txtDiaChi.Text = "";
                    txtMaChiNhanh.Text = "";
                    txtMaNhanVien.Text = "";
                    txtSdt.Text = "";
                    txtThongTinYC.Text = "";
                    txtTieuChi.Text = "";
                    checkNam.Checked = false;
                    checkNu.Checked = false;

                    buttonChinhSua.Visible = true;
                    buttonThemKhachHang.Visible = true;
                }
                else
                {
                    MessageBox.Show("Ma chi nhanh hay ma nhan vien khong ton tai");
                }
            }
            else
            {
                MessageBox.Show("Thieu thong tin");
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Length > 0)
            {
                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();

                string sqlSelect = "SELECT * FROM KHACH_HANG";
                SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                

                List<int> index = new List<int>();
                int k = 0;
                this.getAllClient();
                while (dr.Read())
                {
                    if (!Convert.ToString(dr["HoTen"]).ToUpper().Contains(txtTimKiem.Text.ToUpper()))
                    {
                        index.Add(k);
                        
                    }
                    k++;
                }

                sqlCon.Close();


                this.getAllClient();
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                currencyManager1.SuspendBinding();
                for (var i = 0; i < index.Count; i++)
                {
                    dataGridView1.Rows[index[i]].Visible = false;
                }
                currencyManager1.ResumeBinding();


                txtTimKiem.Text = "";
            }
            else
            {
                this.getAllClient();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.getAllClient();
        }

        private void buttonThemKhachHang_Click(object sender, EventArgs e)
        {
            new ThemKH().Show();
            this.Hide();
        }

        private void checkNu_Click(object sender, EventArgs e)
        {
            checkNu.Checked = true;
            checkNam.Checked = false;
        }

        private void checkNam_Click(object sender, EventArgs e)
        {
            checkNam.Checked = true;
            checkNu.Checked = false;
        }
    }
}

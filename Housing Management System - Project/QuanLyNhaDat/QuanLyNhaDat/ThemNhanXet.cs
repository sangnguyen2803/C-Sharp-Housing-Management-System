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
    public partial class ThemNhanXet : Form
    {
        public ThemNhanXet()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;

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

        public Boolean Save()
        {
            int dem = 0;
            if(txtMaKhachHang.Text.Length > 0)
            {
                if (this.check_exist_MaKH(txtMaKhachHang.Text))
                {
                    dem += 1;
                    ErrorMaKhachHang.Text = "";
                }
                else
                {
                    ErrorMaKhachHang.Text = "Ma khach hang khong ton tai";
                }
            }
            else
            {
                ErrorMaKhachHang.Text = "Ma khach hang rong";
            }

            if(txtMaLoaiNha.Text.Length > 0)
            {
                if (this.check_exist_MaLN(txtMaLoaiNha.Text))
                {
                    dem += 1;
                    ErrorMaLoaiNha.Text = "";
                }
                else
                {
                    ErrorMaLoaiNha.Text = "Ma loai nha khong ton tai";
                }

            }
            else
            {
                ErrorMaLoaiNha.Text = "Ma loai nha rong";
            }
            if (txtMaNha.Text.Length > 0)
            {
                if (this.check_exist_MaNha(txtMaNha.Text))
                {
                    dem += 1;
                    ErrorMaNha.Text = "";
                }
                else
                {
                    ErrorMaNha.Text = "Ma nha khong ton tai";
                }
            }
            else
            {
                ErrorMaNha.Text = "Ma nha rong";
            }

            if(txtMaNhanVien.Text.Length > 0)
            {
                if (this.check_exist_MaNV(txtMaNhanVien.Text))
                {
                    dem += 1;
                    ErrorMaNhanVien.Text = "";
                }
                else
                {
                    ErrorMaNhanVien.Text = "Ma nhan vien khong ton tai";
                }
            }
            else
            {
                ErrorMaNhanVien.Text = "Ma nhan vien rong";
            }

            if(txtNgayXem.Text.Length > 0)
            {
                dem += 1;
                ErrorNgayXem.Text = "";
            }
            else
            {
                ErrorNgayXem.Text = "Ngay xem rong";
            }
            if(txtNhanXet.Text.Length > 0)
            {
                dem += 1;
                ErrorNhanXet.Text = "";
            }
            else
            {
                ErrorNhanXet.Text = "Nhan xet rong";
            }
            
            if(dem < 6)
            {
                return false;
            }

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.Save())
            {
                string strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";
                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();

                string sqlInsert = "INSERT INTO LICH_SU_XEM_NHA VALUES (@MaNha, @MaLN, @MaNV, @MaKH, @NgayXem, @NhanXet)";
                SqlCommand cmd = new SqlCommand(sqlInsert, sqlCon);

                
                cmd.Parameters.AddWithValue("MaNha", txtMaNha.Text);
                cmd.Parameters.AddWithValue("MaLN", txtMaLoaiNha.Text);
                cmd.Parameters.AddWithValue("MaNV", txtMaNhanVien.Text);
                cmd.Parameters.AddWithValue("MaKH", txtMaKhachHang.Text);
                cmd.Parameters.AddWithValue("NgayXem", txtNgayXem.Text);
                cmd.Parameters.AddWithValue("NhanXet", txtNhanXet.Text);
                

                txtMaKhachHang.Text = "";
                txtMaLoaiNha.Text = "";
                txtMaNha.Text = "";
                txtMaNhanVien.Text = "";
                txtNgayXem.Text = "";
                txtNhanXet.Text = "";
               

                MessageBox.Show("Them nhan xet thanh cong");
                cmd.ExecuteNonQuery();

                sqlCon.Close();
            }
        }

        private void buttonThemNha_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QuanLyNhanXet().Show();
        }
    }
}

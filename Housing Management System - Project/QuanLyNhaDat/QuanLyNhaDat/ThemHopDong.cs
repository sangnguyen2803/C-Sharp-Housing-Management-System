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
    public partial class ThemHopDong : Form
    {
        public ThemHopDong()
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
            if (txtMaKhachHang.Text.Length > 0)
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

            if (txtMaLoaiNha.Text.Length > 0)
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

            if (txtMaNhanVien.Text.Length > 0)
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

            if (txtNgayLap.Text.Length > 0)
            {
                dem += 1;
                ErrorNgayLap.Text = "";
            }
            else
            {
                ErrorNgayLap.Text = "Ngay lap rong";
            }
            if (checkMua.Checked || CheckThue.Checked)
            {
                dem += 1;
                ErrorLoai.Text = "";
            }
            else
            {
                ErrorLoai.Text = "Chua chon loai hop dong";
            }

            if (dem < 6)
            {
                return false;
            }

            return true;
        }

        private string findSum(string str1, string str2)
        {

            if (str1.Length > str2.Length)
            {
                string t = str1;
                str1 = str2;
                str2 = t;
            }


            string str = "";


            int n1 = str1.Length, n2 = str2.Length;


            char[] ch = str1.ToCharArray();
            Array.Reverse(ch);
            str1 = new string(ch);
            char[] ch1 = str2.ToCharArray();
            Array.Reverse(ch1);
            str2 = new string(ch1);

            int carry = 0;
            for (int i = 0; i < n1; i++)
            {

                int sum = ((int)(str1[i] - '0') +
                        (int)(str2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');


                carry = sum / 10;
            }


            for (int i = n1; i < n2; i++)
            {
                int sum = ((int)(str2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }


            if (carry > 0)
                str += (char)(carry + '0');


            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            str = new string(ch2);

            return str;
        }

        public void addHD(string MaHD)
        {
            string strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";
            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlInsert = "INSERT INTO HOP_DONG VALUES (@MaHD, @MaNV, @MaKH, @NgayLap, @Loai, @MaLN, @MaNha)";
            SqlCommand cmd = new SqlCommand(sqlInsert, sqlCon);

            cmd.Parameters.AddWithValue("MaHD", MaHD);
            cmd.Parameters.AddWithValue("MaNha", txtMaNha.Text);
            cmd.Parameters.AddWithValue("MaLN", txtMaLoaiNha.Text);
            cmd.Parameters.AddWithValue("MaNV", txtMaNhanVien.Text);
            cmd.Parameters.AddWithValue("MaKH", txtMaKhachHang.Text);
            cmd.Parameters.AddWithValue("NgayLap", txtNgayLap.Text);
            int loai;
            if (checkMua.Checked)
            {
                loai = 1;
            }
            else
            {
                loai = 0;
            }
            cmd.Parameters.AddWithValue("Loai", loai);


            txtMaKhachHang.Text = "";
            txtMaLoaiNha.Text = "";
            txtMaNha.Text = "";
            txtMaNhanVien.Text = "";
            txtNgayLap.Text = "";
            checkMua.Checked = false;
            CheckThue.Checked = false;


            MessageBox.Show("Them hop dong thanh cong");
            cmd.ExecuteNonQuery();

            sqlCon.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.Save())
            {
                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
                string MaHD = "";
                string sqlSelect = "SELECT * FROM HOP_DONG";
                SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MaHD = Convert.ToString(dr["MaHD"]);
                }
                String str = null;
                for (int i = MaHD.Length - 3; i < MaHD.Length; i++)
                {
                    str += MaHD[i];
                }

                sqlCon.Close();
                string new_MaHD = "MHD" + this.findSum(str, "1");
                this.addHD(new_MaHD);

                
            }
        }

        private void buttonThemNha_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QuanLyHopDong().Show();
        }
    }
}

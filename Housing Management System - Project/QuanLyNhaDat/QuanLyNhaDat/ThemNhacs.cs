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
    public partial class ThemNhacs : Form
    {
        public ThemNhacs()
        {
            InitializeComponent();
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

        SqlConnection sqlCon = null;


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

        private Boolean check_exist_MaLoaiNha(String MaLoaiNha)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM LOAI_NHA";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToString(dr["MaLN"]).Equals(MaLoaiNha))
                {
                    return true;
                }
            }

            sqlCon.Close();
            return false;
        }

        private Boolean check_exist_MaChuNha(String MaChuNha)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM CHU_NHA";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToString(dr["MaChuNha"]).Equals(MaChuNha))
                {
                    return true;
                }
            }

            sqlCon.Close();
            return false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();
            string MaNha = "";
            string sqlSelect = "SELECT * FROM NHA";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MaNha = Convert.ToString(dr["MaNha"]);
            }
            String str = null;
            for (int i = MaNha.Length - 3; i < MaNha.Length; i++)
            {
                str += MaNha[i];
            }
            Console.Out.WriteLine(str);
            sqlCon.Close();
            string new_MaNha = "MN" + this.findSum(str, "1");
            Console.Out.WriteLine(new_MaNha);

            int check = 0;

            if(txtDiaChi.Text.Length <= 0)
            {
                ErrorDiaChi.Text = "Dia chi rong";
            }
            else
            {
                ErrorDiaChi.Text = "";
                check += 1;
            }

            if(txtMaChiNhanh.Text.Length <= 0)
            {
                ErrorMaChiNhanh.Text = "Ma chi nhanh rong";
            }
            else
            {
                if (this.check_exist_MaChiNhanh(txtMaChiNhanh.Text))
                {
                    check += 1;
                    ErrorMaChiNhanh.Text = "";
                }
                else
                {
                    ErrorMaChiNhanh.Text = "Ma CN khong ton tai";
                }
            }

            if (txtThongTin.Text.Length <= 0)
            {
                ErrorThongTin.Text = "Thong tin rong";
            }
            else
            {
                ErrorThongTin.Text = "";
                check += 1;
            }

            if (txtTienThue.Text.Length <= 0)
            {
                ErrorTienThue.Text = "Thong tin rong";
            }
            else
            {
                Boolean check_convert = false;
                try
                {
                    Convert.ToDouble(txtTienThue.Text);
                    ErrorTienThue.Text = "";
                    check += 1;
                }
                catch(Exception exc)
                {
                    ErrorTienThue.Text = "Gia tien thue loi";
             
                }
               
            }

            if (txtNgayDangKy.Text.Length <= 0)
            {
                ErrorNgayDangKy.Text = "Ngay dang ky rong";
            }
            else
            {
                ErrorNgayDangKy.Text = "";
                check += 1;
            }
            if (txtNgayHetHan.Text.Length <= 0)
            {
                ErrorNgayHetHan.Text = "Thong tin rong";
            }
            else
            {
                ErrorNgayHetHan.Text = "";
                check += 1;
            }

            if(numericSoPhong.Value <= 0)
            {
                ErrorSoPhong.Text = "So phong bang 0";
            }
            else
            {
                ErrorSoPhong.Text = "";
                check += 1;
            }

            if (txtMaLoaiNha.Text.Length <= 0)
            {
                ErrorMaLoaiNha.Text = "Ma loai nha rong";
            }
            else
            {
                if (this.check_exist_MaLoaiNha(txtMaLoaiNha.Text))
                {
                    check += 1;
                    ErrorMaLoaiNha.Text = "";
                }
                else
                {
                    ErrorMaLoaiNha.Text = "Ma loai nha khong ton tai";
                }
            }

            if (txtMaChuNha.Text.Length <= 0)
            {
                ErrorMaChuNha.Text = "Ma chu nha rong";
            }
            else
            {
                if (this.check_exist_MaChuNha(txtMaChuNha.Text))
                {
                    check += 1;
                    ErrorMaChuNha.Text = "";
                }
                else
                {
                    ErrorMaChuNha.Text = "Ma chu nha khong ton tai";
                }
            }

            if (txtMaNhanVien.Text.Length <= 0)
            {
                ErrorMaNhanVien.Text = "Ma nhan vien rong";
            }
            else
            {
                if (this.check_exist_MaNhanVien(txtMaNhanVien.Text))
                {
                    check += 1;
                    ErrorMaNhanVien.Text = "";
                }
                else
                {
                    ErrorMaNhanVien.Text = "Ma NV khong ton tai";
                }
            }

            if(check == 10)
            {
                Console.Out.WriteLine("Tao thanh cong");
                strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();

                string sqlInsert = "INSERT INTO NHA VALUES (@MaNha, @DiaChi, @ThongTin, @TinhTrang, @TienThue, @MaLN, @NgayDangKy," +
                    "@NgayHetHan, @SoPhong, @MaChuNha, @MaNV, @MaCN)";
                SqlCommand cmd_ = new SqlCommand(sqlInsert, sqlCon);

                cmd_.Parameters.AddWithValue("MaNha", new_MaNha);
                cmd_.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
                cmd_.Parameters.AddWithValue("ThongTin", txtThongTin.Text);
                cmd_.Parameters.AddWithValue("TinhTrang", 0);
                cmd_.Parameters.AddWithValue("TienThue", Convert.ToDouble(txtTienThue.Text));
                cmd_.Parameters.AddWithValue("MaLN", txtMaLoaiNha.Text);
                cmd_.Parameters.AddWithValue("NgayDangKy", txtNgayDangKy.Text);
                cmd_.Parameters.AddWithValue("NgayHetHan", txtNgayHetHan.Text);
                cmd_.Parameters.AddWithValue("SoPhong", numericSoPhong.Value);
                cmd_.Parameters.AddWithValue("MaChuNha", txtMaChuNha.Text);
                cmd_.Parameters.AddWithValue("MaNV", txtMaNhanVien.Text);
                cmd_.Parameters.AddWithValue("MaCN", txtMaChiNhanh.Text);
                txtDiaChi.Text = "";
                txtThongTin.Text = "";
                txtTienThue.Text = "";
                txtMaLoaiNha.Text = "";
                txtNgayDangKy.Text = "";
                txtNgayHetHan.Text = "";
                numericSoPhong.Value = 0;
                txtMaChuNha.Text = "";
                txtMaNhanVien.Text = "";
                txtMaChiNhanh.Text = "";
                MessageBox.Show("Them nha thanh cong");
                cmd_.ExecuteNonQuery();

                sqlCon.Close();
            }




            
        }

        private void txtMaChiNhanh_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonThemNha_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NhanVien_QuanLyNha().Show();
        }
    }
}

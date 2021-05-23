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
    public partial class ThemKH : Form
    {
        public ThemKH()
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


        public Boolean Check()
        {
            int dem = 0;
            if(txtHoTen.Text.Length > 0)
            {
                ErrorHoTen.Text = "";
                dem += 1;
            }
            else
            {
                ErrorHoTen.Text = "Ho ten rong";
            }
            if(txtDiaChi.Text.Length > 0)
            {
                ErrorDiaChi.Text = "";
                dem += 1;
            }
            else
            {
                ErrorDiaChi.Text = "Dia chi rong";
            }
            if(txtSdt.Text.Length > 0)
            {
                ErrorSdt.Text = "";
                dem += 1;
            }
            else
            {
                ErrorSdt.Text = "So dien thoai rong";
            }
            if(checkNam.Checked || checkNu.Checked)
            {
                ErrorGioiTinh.Text = "";
                dem += 1;
            }
            else
            {
                ErrorGioiTinh.Text = "Chua chon gioi tinh";
            }
            if(txtThongTinYC.Text.Length > 0)
            {
                ErrorThongTinYC.Text = "";
                dem += 1;
            }
            else
            {
                ErrorThongTinYC.Text = "Thong tin yeu cau rong";
            }
            if(txtTieuChi.Text.Length > 0)
            {
                ErrorTieuChi.Text = "";
                dem += 1;
            }
            else
            {
                ErrorTieuChi.Text = "Tieu chi rong";
            }
            if(txtMaChiNhanh.Text.Length > 0)
            {
                if (this.check_exist_MaChiNhanh(txtMaChiNhanh.Text))
                {
                    ErrorMaChiNhanh.Text = "";
                    dem += 1;
                }
                else
                {
                    ErrorMaChiNhanh.Text = "Ma chi nhanh khong ton tai";
                }
            }
            else
            {
                ErrorMaChiNhanh.Text = "Ma chi nhanh rong";
            }

            if(txtMaNhanVien.Text.Length > 0)
            {
                if (this.check_exist_MaNhanVien(txtMaNhanVien.Text))
                {
                    ErrorMaNhanVien.Text = "";
                    dem += 1;
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
            if(dem != 8)
            {
                return false;
            }

            return true;
        }

        public void add_Client(string maKH)
        {
            string strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            string gioitinh = "";
            if (checkNam.Checked)
            {
                gioitinh = "nam";
            }
            else
            {
                gioitinh = "nu";
            }

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlInsert = "INSERT INTO KHACH_HANG VALUES (@MaKH, @HoTen, @Sdt, @DiaChi, @GioiTinh, @ThongTinYC, @TieuChi," +
                "@MaCN, @MaNV)";
            SqlCommand cmd_ = new SqlCommand(sqlInsert, sqlCon);

            cmd_.Parameters.AddWithValue("MaKH", maKH);
            cmd_.Parameters.AddWithValue("HoTen", txtHoTen.Text);
            cmd_.Parameters.AddWithValue("Sdt", txtSdt.Text);
            cmd_.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd_.Parameters.AddWithValue("GioiTinh", gioitinh);
            cmd_.Parameters.AddWithValue("ThongTinYC", txtThongTinYC.Text);
            cmd_.Parameters.AddWithValue("TieuChi", txtTieuChi.Text);
            cmd_.Parameters.AddWithValue("MaCN", txtMaChiNhanh.Text);
            cmd_.Parameters.AddWithValue("MaNV", txtMaNhanVien.Text);
          
            txtDiaChi.Text = "";
            txtHoTen.Text = "";
            txtMaChiNhanh.Text = "";
            txtMaNhanVien.Text = "";
            txtSdt.Text = "";
            txtThongTinYC.Text = "";
            txtTieuChi.Text = "";

            checkNam.Checked = false;
            checkNu.Checked = false;
            MessageBox.Show("Them khach hang thanh cong");
            cmd_.ExecuteNonQuery();

            sqlCon.Close();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.Check())
            {
                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
                string MaKH = "";
                string sqlSelect = "SELECT * FROM KHACH_HANG";
                SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MaKH = Convert.ToString(dr["MaKH"]);
                }
                String str = null;
                for (int i = MaKH.Length - 3; i < MaKH.Length; i++)
                {
                    str += MaKH[i];
                }
                
                sqlCon.Close();
                string new_MaKH = "KH" + this.findSum(str, "1");
                this.add_Client(new_MaKH);

            }
        }

        private void checkNu_Click(object sender, EventArgs e)
        {
            checkNam.Checked = false;
            checkNu.Checked = true;
        }

        private void checkNam_Click(object sender, EventArgs e)
        {
            checkNam.Checked = true;
            checkNu.Checked = false;
        }

        private void buttonThemNha_Click(object sender, EventArgs e)
        {
            new QuanLyKH().Show();
            this.Hide();
        }
    }
}

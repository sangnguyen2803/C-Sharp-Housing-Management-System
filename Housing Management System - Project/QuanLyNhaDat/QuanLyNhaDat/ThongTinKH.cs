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
    public partial class ThongTinKH : Form
    {
        public ThongTinKH()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = null;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadThongTin()
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM KHACH_HANG Where MaKH = N'KH001'";

            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtHoten.Text = Convert.ToString(dr["HoTen"]);
                txtDiaChi.Text = Convert.ToString(dr["DiaChi"]);
                txtSdt.Text = Convert.ToString(dr["Sdt"]);
                txtYeucau.Text = Convert.ToString(dr["ThongTinYC"]);
                txtTieuChi.Text = Convert.ToString(dr["TieuChi"]);
                if (Convert.ToString(dr["GioiTinh"]).Equals("nam"))
                {
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                }
                else
                {
                    checkBox1.Checked = false;
                    checkBox2.Checked = true;
                }
            }
           


            sqlCon.Close();
        }

        private void SaveThongTin()
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();
            string gioitinh = "";
            if (checkBox1.Checked)
            {
                gioitinh = "nam";
            }
            else
            {
                gioitinh = "nu";
            }
            string sqlUpdate = "UPDATE KHACH_HANG SET HoTen=N'" + txtHoten.Text +"', Sdt = N'" + txtSdt.Text
                + "', DiaChi = N'" + txtDiaChi.Text + "', GioiTinh = N'" + gioitinh +"', ThongTinYC = N'" +
                txtYeucau.Text + "', TieuChi = N'" + txtTieuChi.Text + "' Where MaKH = N'KH001'";
            SqlCommand cmd = new SqlCommand(sqlUpdate, sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            
        }
        private void ThongTinKH_Load(object sender, EventArgs e)
        {
            txtHoten.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSdt.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            txtYeucau.Enabled = false;
            txtTieuChi.Enabled = false;
            buttonSave.Visible = false;
            this.LoadThongTin();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHoten.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSdt.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            txtYeucau.Enabled = true;
            txtTieuChi.Enabled = true;
            button1.Visible = false;
            buttonSave.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(txtHoten.Text != "" && txtDiaChi.Text != "" && txtSdt.Text != "" && txtTieuChi.Text != "" && txtYeucau.Text != "" &&
                (checkBox1.Checked || checkBox2.Checked))
            {

                if (MessageBox.Show("Ban muon thay doi thong tin?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    txtHoten.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtSdt.Enabled = false;
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    txtYeucau.Enabled = false;
                    txtTieuChi.Enabled = false;
                    buttonSave.Visible = false;
                    button1.Visible = true;
                    this.SaveThongTin();
                    MessageBox.Show("Cap nhat thong tin thanh cong");
                    this.LoadThongTin();
                }


            }
            else
            {
                if(txtHoten.Text == "")
                {
                    ErrorHoTen.Text = "Ho ten rong";
                }
                else
                {
                    ErrorHoTen.Text = "";
                }


                if(txtDiaChi.Text == "")
                {
                    ErrorDiaChi.Text = "Dia chi rong";
                }
                else
                {
                    ErrorDiaChi.Text = "";
                }

                if(txtSdt.Text == "")
                {
                    ErrorSdt.Text = "So dien thoai rong";

                }
                else
                {
                    ErrorSdt.Text = "";
                }
                if(!checkBox1.Checked && !checkBox2.Checked)
                {
                    ErrorGioiTinh.Text = "Gioi tinh chua duoc chon";
                }
                else
                {
                    ErrorGioiTinh.Text = "";
                }
                if(txtTieuChi.Text == "")
                {
                    ErrorTieuChi.Text = "Tieu chi rong";
                }
                else
                {
                    ErrorTieuChi.Text = "";
                }

                if (txtYeucau.Text == "")
                {
                    ErrorYeuCau.Text = "Tieu chi rong";
                }
                else
                {
                    ErrorYeuCau.Text = "";
                }

            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new KhachHang().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           // checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           // checkBox1.Checked = false;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }
    }
}

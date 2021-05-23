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
using Microsoft.VisualBasic;

namespace QuanLyNhaDat
{
    public partial class NhanVien_QuanLyNha : Form
    {
        public NhanVien_QuanLyNha()
        {
            InitializeComponent();
           
        }
        SqlConnection sqlCon = null;
        String MaNha = "";
        string MaCN = "";
        private void GetAll()
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM NHA";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaNha"].Visible = false;
            dataGridView1.Columns["MaChuNha"].Visible = false;
            dataGridView1.Columns["MaLN"].Visible = false;
            dataGridView1.Columns["MaNV"].Visible = false;
            dataGridView1.Columns["MaCN"].Visible = false;

            sqlCon.Close();
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
        private void button3_Click(object sender, EventArgs e)
        {
            if(this.MaNha.Length > 0)
            {
                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;";
                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("UpdateTienThue_T1_fix", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manha", SqlDbType.NVarChar).Value = this.MaNha;
                
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                this.GetAll();

            }
        }

        private void SaveThongTin(String _MaNha)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();
            int tinhtrang ;
            if (checkTinhTrang0.Checked)
            {
                tinhtrang = 0;
            }
            else
            {
                tinhtrang = 1;
            }
            string sqlUpdate = "UPDATE NHA SET DiaChi=N'" + txtDiaChi.Text + "', ThongTin = N'" + txtThongTin.Text
                + "', NgayDangKy = N'" + txtNgayDangKy.Text + "', TinhTrang = " + tinhtrang + ", NgayHetHan = N'" +
                txtNgayHetHan.Text + "', TienThue = N'" + Convert.ToDouble(txtTienThue.Text) + "' Where MaNha = N'" + _MaNha + "'";
            SqlCommand cmd = new SqlCommand(sqlUpdate, sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();

        }

        private void NhanVien_ThueNha_Load(object sender, EventArgs e)
        {
            buttonSave.Visible = false;
            buttonHuy.Visible = false;
            txtDiaChi.Enabled = false;
            txtThongTin.Enabled = false;
            txtTienThue.Enabled = false;
            checkTinhTrang0.Enabled = false;
            checkTinhTrang1.Enabled = false;
            numericSoPhong.Enabled = false;
            txtNgayDangKy.Enabled = false;
            txtNgayHetHan.Enabled = false;
            this.GetAll();
         
            

        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            buttonSave.Visible = true;
            buttonHuy.Visible = true;
            txtDiaChi.Enabled = true;
            txtThongTin.Enabled = true;
            txtTienThue.Enabled = true;
            checkTinhTrang0.Enabled = true;
            checkTinhTrang1.Enabled = true;
            numericSoPhong.Enabled = true;
            txtNgayDangKy.Enabled = true;
            txtNgayHetHan.Enabled = true;
            buttonChinhSua.Visible = false;
            buttonGiam.Visible = false;
            buttonTang.Visible = false;
            buttonThemNha.Visible = false;
            button1.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDiaChi.Text =  dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].FormattedValue.ToString();
            txtThongTin.Text = dataGridView1.Rows[e.RowIndex].Cells["ThongTin"].FormattedValue.ToString();
            txtTienThue.Text = dataGridView1.Rows[e.RowIndex].Cells["TienThue"].FormattedValue.ToString();
            txtNgayDangKy.Text = dataGridView1.Rows[e.RowIndex].Cells["NgayDangKy"].FormattedValue.ToString();
            txtNgayHetHan.Text = dataGridView1.Rows[e.RowIndex].Cells["NgayHetHan"].FormattedValue.ToString();
            numericSoPhong.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SoPhong"].FormattedValue.ToString());
            this.MaNha = dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString();
            this.MaCN = dataGridView1.Rows[e.RowIndex].Cells["MaChuNha"].FormattedValue.ToString();

            if (dataGridView1.Rows[e.RowIndex].Cells["TinhTrang"].FormattedValue.ToString() == "False")
            {
                checkTinhTrang0.Checked = true;
                checkTinhTrang1.Checked = false;
            }
            else
            {
                checkTinhTrang0.Checked = false;
                checkTinhTrang1.Checked = true;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Xoa")
            {
                if (MessageBox.Show("Ban muon xoa ngoi nha nay?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if(this.MaNha.Length > 0)
                    {
                        String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;";
                        sqlCon = new SqlConnection(strConnect);
                        sqlCon.Open();
                        string sqldelete = "DELETE FROM NHA WHERE MaNha = N'" + this.MaNha + "'";
                        SqlCommand cmd = new SqlCommand(sqldelete, sqlCon);
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();
                        MessageBox.Show("Xoa nha thanh cong");
                        this.GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Xoa nha that bai");
                    }
                    
                }

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "XemTinhTrang")
            {
                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;";
                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
                
                SqlCommand cmd = new SqlCommand("Xem_Tinh_Trang_T2_fix", sqlCon);
             
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manha", SqlDbType.NVarChar).Value = this.MaNha;
                cmd.Parameters.Add("@tinhtrang", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tinh trang(0 chua thue, 1 da thue): " + cmd.Parameters["@tinhtrang"].Value);
                Console.Out.WriteLine(cmd.Parameters["@tinhtrang"].Value);
                Console.Out.WriteLine(this.MaNha);
                sqlCon.Close();
               
            }    
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Boolean check = true;
            if(txtDiaChi.Text.Length <= 0 || txtNgayDangKy.Text.Length <= 0 || txtNgayHetHan.Text.Length <= 0
                || txtThongTin.Text.Length <= 0 || txtTienThue.Text.Length <= 0 || 
                (!checkTinhTrang1.Checked && !checkTinhTrang0.Checked))
            {
                check = false;
             
            }
            if (check)
            {
                Error.Text = "";

                this.SaveThongTin(this.MaNha);
                this.GetAll();
                buttonSave.Visible = false;
                txtDiaChi.Enabled = false;
                txtThongTin.Enabled = false;
                txtTienThue.Enabled = false;
                checkTinhTrang0.Enabled = false;
                checkTinhTrang1.Enabled = false;
                numericSoPhong.Enabled = false;
                txtNgayDangKy.Enabled = false;
                txtNgayHetHan.Enabled = false;
                buttonChinhSua.Visible = false;
                buttonGiam.Visible = true;
                buttonTang.Visible = true;
                buttonThemNha.Visible = true;
                buttonChinhSua.Visible = true;
                button1.Visible = true;
            }
            else
            {
                Error.Text = "Thieu thong tin";
            }
        }

        private void checkTinhTrang0_Click(object sender, EventArgs e)
        {
           
            checkTinhTrang1.Checked = false;
          
        }
        

        private void checkTinhTrang1_Click_1(object sender, EventArgs e)
        {
            checkTinhTrang0.Checked = false;
           
        }

        private void buttonThemNha_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new ThemNhacs().Show();
        }

        private void buttonGiam_Click(object sender, EventArgs e)
        {
            if (this.MaNha.Length > 0)
            {
                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True";
                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("UpdateTienThueNha_T2_fix", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manha", SqlDbType.NVarChar).Value = this.MaNha;

                cmd.ExecuteNonQuery();
                sqlCon.Close();
                this.GetAll();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.MaNha.Length > 0)
            {
                String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True";
                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("UpdateTinhTrang_T1_fix", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manha", SqlDbType.NVarChar).Value = this.MaNha;
               
                cmd.ExecuteNonQuery();
                
                sqlCon.Close();
                this.GetAll();

            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.GetAll();
            buttonSave.Visible = false;
            buttonHuy.Visible = false;
            txtDiaChi.Enabled = false;
            txtThongTin.Enabled = false;
            txtTienThue.Enabled = false;
            checkTinhTrang0.Enabled = false;
            checkTinhTrang1.Enabled = false;
            numericSoPhong.Enabled = false;
            txtNgayDangKy.Enabled = false;
            txtNgayHetHan.Enabled = false;


            txtDiaChi.Text = "";
            txtThongTin.Text = "";
            txtTienThue.Text = "";
            checkTinhTrang0.Checked = false;
            checkTinhTrang1.Checked = false;
            numericSoPhong.Value = 0;
            txtNgayDangKy.Text = "";
            txtNgayHetHan.Text = "";

            buttonChinhSua.Visible = false;
            buttonGiam.Visible = true;
            buttonTang.Visible = true;
            buttonThemNha.Visible = true;
            buttonChinhSua.Visible = true;
            button1.Visible = true;
        }

        private void Error_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericSoPhong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayHetHan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayDangKy_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkTinhTrang1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkTinhTrang0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTienThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtThongTin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDoiMCN_Click(object sender, EventArgs e)
        {
            string mess = "Nhap ma chu nha moi", title = "Thay doi ma chu nha";
            if(this.MaCN.Length > 0)
            {
                object value;
                value = Interaction.InputBox(mess,title,this.MaCN);
                if(((string)value).Length > 0)
                {
                    if(this.check_exist_MaChuNha((string)value))
                    {
                        String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True";
                        sqlCon = new SqlConnection(strConnect);
                        sqlCon.Open();
                        SqlCommand cmd = new SqlCommand("UpdateMCN_T2_fix", sqlCon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@manha", SqlDbType.NVarChar).Value = this.MaNha;
                        cmd.Parameters.Add("@machunha", SqlDbType.NVarChar).Value = (string)value;

                        cmd.ExecuteNonQuery();
                        sqlCon.Close();
                        this.GetAll();
                        Microsoft.VisualBasic.Interaction.MsgBox("Thay doi chu nha thanh cong", MsgBoxStyle.OkOnly);
                    }
                    else
                    {
                        Microsoft.VisualBasic.Interaction.MsgBox("Ma chu nha khong ton tai", MsgBoxStyle.OkOnly);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;";
            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand("XemTTNha_T1_fix", sqlCon);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manha", SqlDbType.NVarChar).Value = this.MaNha;
            cmd.Parameters.Add("@tienthue", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tien thue: " + cmd.Parameters["@tienthue"].Value);
          
            sqlCon.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.GetAll();
        }
    }
}

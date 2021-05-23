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
    public partial class TimKiemNha : Form
    {
        public TimKiemNha()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = null;



        public void UpdateTinhTrang(string manha)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();  
            string sqlUpdate = "UPDATE NHA SET TinhTrang=" + 1 + " Where MaNha = N'"+ manha +"'";
            SqlCommand cmd = new SqlCommand(sqlUpdate, sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            this.GetAll();
        }
        private void GetAll()
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=KhachHang;Password=A";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM NHA Where TinhTrang=0";
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
        private void TimKiemNha_Load(object sender, EventArgs e)
        {
            List<string> listprice= new List<string>() {"Duoi 12 tr" ,"Tu 12tr đen 25tr", "Tren 25tr"};
            comboBoxGiaNha.DataSource = listprice;
            List<string> listtype = new List<string>() { "Loai 1", "Loai 2", "Loai 3","Loai 4" };
            comboBoxLoaiNha.DataSource = listtype;
            List<string> address = new List<string>() { "Quan 1", "Quan 2", "Quan 3", "Quan 4" , "Quan 5", "Quan 7", "Quan 8", "Quan 10"};
            comboBoxKhuVuc.DataSource = address;
            comboBoxGiaNha.Text = "";
            comboBoxKhuVuc.Text = "";
            comboBoxLoaiNha.Text = "";
            this.GetAll();
        //    dataGridView1.Visible = false;

        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private Boolean check_GiaNha(double gia, string str)
        {
            if(str == "Duoi 12 tr")
            {
                if(gia < 12000000)
                {
                    return true;
                }
            }
            else
            {
                if (str == "Tu 12tr đen 25tr")
                {
                    if (gia >= 12000000 && gia <= 25000000)
                    {
                        return true;
                    }
                }
                else
                {
                    if (str == "Tren 25tr")
                    {
                        if (gia > 25000000)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private Boolean check_khuvuc(string khuvuc, string str)
        {
            string convert = khuvuc.ToLower();
            string str_convert = str.ToLower();
            if(str == "Quan 1" || str == "Quan2" || str == "Quan 3" || str == "Quan 4" || str == "Quan 5" ||
                str == "Quan 7" || str == "Quan 8" || str == "Quan 10")
            {
                if (convert.Contains(str_convert))
                {
                    return true;
                }
            }
            return false;
        }
        private Boolean check_LoaiNha(string MaLN, string str)
        {
            if(str == "Loai 1")
            {
                if(MaLN == "LN001")
                {
                    return true;
                }
            }
            if (str == "Loai 2")
            {
                if (MaLN == "LN002")
                {
                    return true;
                }
            }
            if (str == "Loai 3")
            {
                if (MaLN == "LN003")
                {
                    return true;
                }
            }
            if (str == "Loai 4")
            {
                if (MaLN == "LN004")
                {
                    return true;
                }
            }

            return false;
        }

        private Boolean check_SoPhong(int sp, int sl)
        {
            if(sp == sl)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = new List<int>();

            int check = 0;
            if (comboBoxGiaNha.Text != "")
            {
                check += 1;
            }
            if(comboBoxKhuVuc.Text != "")
            {
                check += 1;
            }
            if(comboBoxLoaiNha.Text != "")
            {
                check += 1;
            }
            if(numericUpDownSoPhong.Value > 0)
            {
                check += 1;
            }


            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=KhachHang;Password=A";

            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            string sqlSelect = "SELECT * FROM NHA Where TinhTrang=0";
            SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();
            int k = 0;
            while (dr.Read())
            {
                int tmp_check = 0;
                if (check_GiaNha(Convert.ToDouble(dr["TienThue"]), comboBoxGiaNha.Text))
                {
                    tmp_check += 1;
                    Console.Out.WriteLine("Gia nha dung");
                }
                if (check_khuvuc(Convert.ToString(dr["DiaChi"]), comboBoxKhuVuc.Text))
                {
                    tmp_check += 1;
                    Console.Out.WriteLine("Khu vuc dung");
                }
                if(check_LoaiNha(Convert.ToString(dr["MaLN"]), comboBoxLoaiNha.Text))
                {
                    tmp_check += 1;
                    Console.Out.WriteLine("Ma loai nha dung");
                }
                var sp = numericUpDownSoPhong.Value;
                if (check_SoPhong(Convert.ToInt32(dr["SoPhong"]), (int)sp))
                {
                    tmp_check += 1;
                    Console.Out.WriteLine("So phong dung");
                }
                if(check <= tmp_check)
                {

                }
                else
                {
                    index.Add(k);
                }
                k++;
            }
            this.GetAll();
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            currencyManager1.SuspendBinding();
            for (var i = 0; i < index.Count; i++)
            {
                dataGridView1.Rows[index[i]].Visible = false;
            }
            currencyManager1.ResumeBinding();

            sqlCon.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "Mua")
            {
                if(MessageBox.Show("Ban muon mua ngoi nha nay?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                    ==DialogResult.Yes)
                {
                    var index = dataGridView1.Columns[e.RowIndex].Index;
                    
                    Console.Out.WriteLine(dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString());
                    string ngay = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                    Console.Out.WriteLine(ngay);
                    String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

                    sqlCon = new SqlConnection(strConnect);
                    sqlCon.Open();
                    string MaMua = "";
                    string sqlSelect = "SELECT * FROM MUA_NHA";
                    SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        MaMua = Convert.ToString(dr["MaMua"]);
                    }
                    String str = null;
                    for(int i = MaMua.Length-3; i < MaMua.Length; i++)
                    {
                        str += MaMua[i];
                    }
                    Console.Out.WriteLine(str);
                        
                    string new_MaMua = "MaMua" + this.findSum(str,"1");
                    Console.Out.WriteLine(new_MaMua);
                    sqlCon.Close();


                    ///
                    sqlCon = new SqlConnection(strConnect);
                    sqlCon.Open();
                 //   string sqlInsert = "INSERT INTO MUA_NHA VALUES (@MaMua, @MaKH, @MaNha, @GiaBan, @NgayMua, @DieuKien)";
                    SqlCommand cmd_tmp = new SqlCommand("InsertMuaNha", sqlCon);
                    cmd_tmp.CommandType = CommandType.StoredProcedure;
                    cmd_tmp.Parameters.Add("@mamua", SqlDbType.NVarChar).Value = new_MaMua;
                    cmd_tmp.Parameters.Add("@makh", SqlDbType.NVarChar).Value = "KH001";
                    cmd_tmp.Parameters.Add("@manha", SqlDbType.NVarChar).Value = dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString();
                    cmd_tmp.Parameters.Add("@tien", SqlDbType.NVarChar).Value = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["TienThue"].FormattedValue.ToString());
                    cmd_tmp.Parameters.Add("@ngay", SqlDbType.NVarChar).Value = ngay;
                    cmd_tmp.Parameters.Add("@dieukien", SqlDbType.NVarChar).Value = "Dat coc 70%";
                    //    cmd_tmp.Parameters.AddWithValue("MaMua", new_MaMua);
                    //    cmd_tmp.Parameters.AddWithValue("MaKH", "KH001");
                    //    cmd_tmp.Parameters.AddWithValue("MaNha", dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString());
                    //    cmd_tmp.Parameters.AddWithValue("GiaBan", Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["TienThue"].FormattedValue.ToString())*3);
                    //    cmd_tmp.Parameters.AddWithValue("NgayMua", ngay);
                    //    cmd_tmp.Parameters.AddWithValue("DieuKien", "Dat coc 70%");

                    cmd_tmp.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Mua nha thanh cong");
                    this.UpdateTinhTrang(dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString());


                }

            }
            else
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "ThueNha")
                {
                    if (MessageBox.Show("Ban muon thue ngoi nha nay?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        var index = dataGridView1.Columns[e.RowIndex].Index;

                        Console.Out.WriteLine(dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString());

                        String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;User ID=NhanVien;Password=C";

                        sqlCon = new SqlConnection(strConnect);
                        sqlCon.Open();
                        string MaMua = "";
                        string sqlSelect = "SELECT * FROM THUE_NHA";
                        SqlCommand cmd = new SqlCommand(sqlSelect, sqlCon);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            MaMua = Convert.ToString(dr["MaThue"]);
                        }
                        String str = null;
                        for (int i = MaMua.Length - 3; i < MaMua.Length; i++)
                        {
                            str += MaMua[i];
                        }
                        Console.Out.WriteLine(str);

                        string new_MaMua = "MT" + this.findSum(str, "1");
                        Console.Out.WriteLine(new_MaMua);
                        sqlCon.Close();


                        ///
                        sqlCon = new SqlConnection(strConnect);
                        sqlCon.Open();
                        string sqlInsert = "INSERT INTO THUE_NHA VALUES (@MaThue, @MaKH, @MaNha, @NgayDangKy, @NgayHetHan)";
                        SqlCommand cmd_tmp = new SqlCommand(sqlInsert, sqlCon);

                        cmd_tmp.Parameters.AddWithValue("MaThue", new_MaMua);
                        cmd_tmp.Parameters.AddWithValue("MaKH", "KH001");
                        cmd_tmp.Parameters.AddWithValue("MaNha", dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString());
                
                        cmd_tmp.Parameters.AddWithValue("NgayDangKy", dataGridView1.Rows[e.RowIndex].Cells["NgayDangKy"].FormattedValue.ToString());
                        cmd_tmp.Parameters.AddWithValue("NgayHetHan", dataGridView1.Rows[e.RowIndex].Cells["NgayHetHan"].FormattedValue.ToString());


                        cmd_tmp.ExecuteNonQuery();
                        sqlCon.Close();
                        MessageBox.Show("Thue nha thanh cong");
                        this.UpdateTinhTrang(dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString());
                    }

                }
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            new KhachHang().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.GetAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String strConnect = @"Data Source=DESKTOP-7O9O0JV\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True;";
            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand("DemNha_KH_T1", sqlCon);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = "KH001";
            cmd.Parameters.Add("@nb", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@nb1", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
            //    cmd.Parameters.Add("@nb2", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int nb = Convert.ToInt32(cmd.Parameters["@nb"].Value);
            MessageBox.Show("So nha so huu: " + cmd.Parameters["@nb1"].Value + " (" + nb + " ngoi nha)");


            sqlCon.Close();
        }
    }
}

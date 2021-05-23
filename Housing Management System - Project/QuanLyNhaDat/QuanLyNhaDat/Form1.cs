using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaDat
{
    public partial class Form1 : Form
    {

        private string[] username;
        private string[] password;
        private int type;

        public void LoadAccout()
        {
            if (this.type == 1)
            {
                this.username = new string[3];
                this.password = new string[3];
                this.username[0] = "NhanVien01";
                this.username[1] = "NhanVien02";
                this.username[2] = "NhanVien03";
                this.password[0] = "nv001";
                this.password[1] = "nv002";
                this.password[2] = "nv003";
            }
            else
            {
                if (this.type == 2)
                {
                    this.username = new string[3];
                    this.password = new string[3];
                    this.username[0] = "ChuNha01";
                    this.username[1] = "ChuNha02";
                    this.username[2] = "ChuNha03";
                    this.password[0] = "chunha01";
                    this.password[1] = "chunha02";
                    this.password[2] = "chunha03";
                }
                else
                {
                    if (this.type == 3)
                    {
                        this.username = new string[3];
                        this.password = new string[3];
                        this.username[0] = "KhachHang01";
                        this.username[1] = "KhachHang02";
                        this.username[2] = "KhachHang03";
                        this.password[0] = "kh001";
                        this.password[1] = "kh002";
                        this.password[2] = "kh003";
                    }
                }


            }
        }
     //   String connect = "Data Source=DESKTOP-EIVACRQ\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True";
        public Form1(int t)
        {

            InitializeComponent();
            this.type = t;
            this.LoadAccout();
            txtPassword.PasswordChar = '*' ;


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < this.username.Length; i++)
            {
                if (txtUsername.Text == this.username[i] && txtPassword.Text == this.password[i])
                {
                    if(this.type == 2)
                    {
                        new BaiDang().Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        if(this.type == 3)
                        {
                            new KhachHang().Show();
                            this.Hide();
                            break;
                        }
                    }
                   
                }
                else
                {
                    MessageBox.Show("Username or Password does not correct");
                    txtPassword.Clear();
                    txtUsername.Clear();
                }
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

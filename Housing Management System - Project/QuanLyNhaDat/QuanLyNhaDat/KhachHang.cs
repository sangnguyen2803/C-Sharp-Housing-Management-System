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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new ThongTinKH().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ThongTinKH().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new TimKiemNha().Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new TimKiemNha().Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new TimKiemNha().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new TimKiemNha().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TimKiemNha().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new TimKiemNha().Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new LichSuKH().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new LichSuKH().Show();
            this.Hide();
        }
    }
}

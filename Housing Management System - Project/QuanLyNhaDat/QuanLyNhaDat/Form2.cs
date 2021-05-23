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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1(1).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1(3).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1(2).Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


namespace QuanLyNhaDat
{
    partial class BaiDang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataLoad = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.FormBaiDang = new System.Windows.Forms.Panel();
            this.ErrorLoai = new System.Windows.Forms.TextBox();
            this.ErrorDate = new System.Windows.Forms.TextBox();
            this.ErrorMCN = new System.Windows.Forms.TextBox();
            this.ErrorMaNha = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMCN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ThongTin = new System.Windows.Forms.Panel();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaChuNha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.DataLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.FormBaiDang.SuspendLayout();
            this.ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonHuy);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.DataLoad);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.FormBaiDang);
            this.panel1.Controls.Add(this.ThongTin);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 524);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DataLoad
            // 
            this.DataLoad.Controls.Add(this.dataGridView1);
            this.DataLoad.Location = new System.Drawing.Point(42, 297);
            this.DataLoad.Margin = new System.Windows.Forms.Padding(4);
            this.DataLoad.Name = "DataLoad";
            this.DataLoad.Size = new System.Drawing.Size(771, 214);
            this.DataLoad.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(7, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(520, 193);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 41);
            this.button5.TabIndex = 7;
            this.button5.Text = "Danh sách bài đăng";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(745, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormBaiDang
            // 
            this.FormBaiDang.Controls.Add(this.ErrorLoai);
            this.FormBaiDang.Controls.Add(this.ErrorDate);
            this.FormBaiDang.Controls.Add(this.ErrorMCN);
            this.FormBaiDang.Controls.Add(this.ErrorMaNha);
            this.FormBaiDang.Controls.Add(this.button3);
            this.FormBaiDang.Controls.Add(this.radioButton2);
            this.FormBaiDang.Controls.Add(this.radioButton1);
            this.FormBaiDang.Controls.Add(this.label6);
            this.FormBaiDang.Controls.Add(this.txtDate);
            this.FormBaiDang.Controls.Add(this.label7);
            this.FormBaiDang.Controls.Add(this.txtMCN);
            this.FormBaiDang.Controls.Add(this.label8);
            this.FormBaiDang.Controls.Add(this.txtMaNha);
            this.FormBaiDang.Controls.Add(this.label9);
            this.FormBaiDang.Location = new System.Drawing.Point(49, 310);
            this.FormBaiDang.Margin = new System.Windows.Forms.Padding(4);
            this.FormBaiDang.Name = "FormBaiDang";
            this.FormBaiDang.Size = new System.Drawing.Size(733, 163);
            this.FormBaiDang.TabIndex = 5;
            // 
            // ErrorLoai
            // 
            this.ErrorLoai.BackColor = System.Drawing.Color.Cyan;
            this.ErrorLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorLoai.Location = new System.Drawing.Point(491, 117);
            this.ErrorLoai.Name = "ErrorLoai";
            this.ErrorLoai.Size = new System.Drawing.Size(161, 15);
            this.ErrorLoai.TabIndex = 13;
            // 
            // ErrorDate
            // 
            this.ErrorDate.BackColor = System.Drawing.Color.Cyan;
            this.ErrorDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorDate.Location = new System.Drawing.Point(491, 57);
            this.ErrorDate.Name = "ErrorDate";
            this.ErrorDate.Size = new System.Drawing.Size(164, 15);
            this.ErrorDate.TabIndex = 12;
            // 
            // ErrorMCN
            // 
            this.ErrorMCN.BackColor = System.Drawing.Color.Cyan;
            this.ErrorMCN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorMCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorMCN.Location = new System.Drawing.Point(132, 120);
            this.ErrorMCN.Name = "ErrorMCN";
            this.ErrorMCN.Size = new System.Drawing.Size(164, 15);
            this.ErrorMCN.TabIndex = 11;
            // 
            // ErrorMaNha
            // 
            this.ErrorMaNha.BackColor = System.Drawing.Color.Cyan;
            this.ErrorMaNha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorMaNha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorMaNha.Location = new System.Drawing.Point(133, 59);
            this.ErrorMaNha.Name = "ErrorMaNha";
            this.ErrorMaNha.Size = new System.Drawing.Size(165, 15);
            this.ErrorMaNha.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(323, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Tạo bài đăng";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(488, 86);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "0";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(595, 89);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 21);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Loại";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(488, 28);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(167, 22);
            this.txtDate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày đăng ký";
            // 
            // txtMCN
            // 
            this.txtMCN.Location = new System.Drawing.Point(132, 85);
            this.txtMCN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMCN.Name = "txtMCN";
            this.txtMCN.Size = new System.Drawing.Size(167, 22);
            this.txtMCN.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã chủ nhà: ";
            // 
            // txtMaNha
            // 
            this.txtMaNha.Location = new System.Drawing.Point(132, 30);
            this.txtMaNha.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNha.Name = "txtMaNha";
            this.txtMaNha.Size = new System.Drawing.Size(167, 22);
            this.txtMaNha.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã nhà: ";
            // 
            // ThongTin
            // 
            this.ThongTin.Controls.Add(this.txtAdress);
            this.ThongTin.Controls.Add(this.label5);
            this.ThongTin.Controls.Add(this.txtSdt);
            this.ThongTin.Controls.Add(this.label4);
            this.ThongTin.Controls.Add(this.txtHoTen);
            this.ThongTin.Controls.Add(this.label3);
            this.ThongTin.Controls.Add(this.txtMaChuNha);
            this.ThongTin.Controls.Add(this.label2);
            this.ThongTin.Location = new System.Drawing.Point(48, 350);
            this.ThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.Size = new System.Drawing.Size(733, 148);
            this.ThongTin.TabIndex = 4;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(488, 80);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(167, 22);
            this.txtAdress.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ: ";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(488, 28);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(167, 22);
            this.txtSdt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(132, 85);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(167, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên: ";
            // 
            // txtMaChuNha
            // 
            this.txtMaChuNha.Location = new System.Drawing.Point(132, 30);
            this.txtMaChuNha.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChuNha.Name = "txtMaChuNha";
            this.txtMaChuNha.Size = new System.Drawing.Size(167, 22);
            this.txtMaChuNha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã chủ nhà: ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(288, 193);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tạo bài đăng";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(49, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xem thông tin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox2.Image = global::QuanLyNhaDat.Properties.Resources._81_819571_icon_blog_blog_hd_png_download;
            this.pictureBox2.Location = new System.Drawing.Point(288, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.Image = global::QuanLyNhaDat.Properties.Resources.business_costume_male_man_office_user_icon_1320196264882354682;
            this.pictureBox1.Location = new System.Drawing.Point(48, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(893, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "CN001";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyNhaDat.Properties.Resources.user_male;
            this.pictureBox3.Location = new System.Drawing.Point(876, 47);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 192);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button6.Location = new System.Drawing.Point(49, 246);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 42);
            this.button6.TabIndex = 9;
            this.button6.Text = "Chỉnh sửa";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHuy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonHuy.Location = new System.Drawing.Point(288, 247);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(181, 42);
            this.buttonHuy.TabIndex = 10;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonSave.Location = new System.Drawing.Point(520, 245);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(186, 42);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Lưu thông tin";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // BaiDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaiDang";
            this.Text = "BaiDang";
            this.Load += new System.EventHandler(this.BaiDang_Load);
            this.panel1.ResumeLayout(false);
            this.DataLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.FormBaiDang.ResumeLayout(false);
            this.FormBaiDang.PerformLayout();
            this.ThongTin.ResumeLayout(false);
            this.ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ThongTin;
        private System.Windows.Forms.TextBox txtMaChuNha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel FormBaiDang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMCN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaNha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox ErrorLoai;
        private System.Windows.Forms.TextBox ErrorDate;
        private System.Windows.Forms.TextBox ErrorMCN;
        private System.Windows.Forms.TextBox ErrorMaNha;
        private System.Windows.Forms.Panel DataLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

namespace QuanLyNhaDat
{
    partial class QuanLyKH
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
            this.buttonHuy = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.TextBox();
            this.buttonThemKhachHang = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonChinhSua = new System.Windows.Forms.Button();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaChiNhanh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkNam = new System.Windows.Forms.CheckBox();
            this.checkNu = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTieuChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThongTinYC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SoNhaSoHuu = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHuy.Location = new System.Drawing.Point(267, 278);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(110, 28);
            this.buttonHuy.TabIndex = 24;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // Error
            // 
            this.Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Error.Enabled = false;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(295, 206);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(174, 15);
            this.Error.TabIndex = 22;
            // 
            // buttonThemKhachHang
            // 
            this.buttonThemKhachHang.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonThemKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThemKhachHang.Location = new System.Drawing.Point(383, 240);
            this.buttonThemKhachHang.Name = "buttonThemKhachHang";
            this.buttonThemKhachHang.Size = new System.Drawing.Size(141, 28);
            this.buttonThemKhachHang.TabIndex = 21;
            this.buttonThemKhachHang.Text = "Thêm khách hàng";
            this.buttonThemKhachHang.UseVisualStyleBackColor = false;
            this.buttonThemKhachHang.Click += new System.EventHandler(this.buttonThemKhachHang_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(211, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "Danh sách khách hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.SoNhaSoHuu});
            this.dataGridView1.Location = new System.Drawing.Point(30, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(652, 309);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(824, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "NV001";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Cyan;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(383, 278);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 28);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonChinhSua
            // 
            this.buttonChinhSua.BackColor = System.Drawing.Color.Silver;
            this.buttonChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChinhSua.Location = new System.Drawing.Point(267, 240);
            this.buttonChinhSua.Name = "buttonChinhSua";
            this.buttonChinhSua.Size = new System.Drawing.Size(111, 28);
            this.buttonChinhSua.TabIndex = 15;
            this.buttonChinhSua.Text = "Chỉnh sửa";
            this.buttonChinhSua.UseVisualStyleBackColor = false;
            this.buttonChinhSua.Click += new System.EventHandler(this.buttonChinhSua_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(493, 173);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(170, 22);
            this.txtMaNhanVien.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã nhân viên";
            // 
            // txtMaChiNhanh
            // 
            this.txtMaChiNhanh.Location = new System.Drawing.Point(105, 173);
            this.txtMaChiNhanh.Name = "txtMaChiNhanh";
            this.txtMaChiNhanh.Size = new System.Drawing.Size(170, 22);
            this.txtMaChiNhanh.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã chi nhánh";
            // 
            // checkNam
            // 
            this.checkNam.AutoSize = true;
            this.checkNam.Location = new System.Drawing.Point(547, 130);
            this.checkNam.Name = "checkNam";
            this.checkNam.Size = new System.Drawing.Size(59, 21);
            this.checkNam.TabIndex = 8;
            this.checkNam.Text = "Nam";
            this.checkNam.UseVisualStyleBackColor = true;
            this.checkNam.Click += new System.EventHandler(this.checkNam_Click);
            // 
            // checkNu
            // 
            this.checkNu.AutoSize = true;
            this.checkNu.Location = new System.Drawing.Point(493, 130);
            this.checkNu.Name = "checkNu";
            this.checkNu.Size = new System.Drawing.Size(48, 21);
            this.checkNu.TabIndex = 7;
            this.checkNu.Text = "Nữ";
            this.checkNu.UseVisualStyleBackColor = true;
            this.checkNu.Click += new System.EventHandler(this.checkNu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới tính";
            // 
            // txtTieuChi
            // 
            this.txtTieuChi.Location = new System.Drawing.Point(493, 78);
            this.txtTieuChi.Name = "txtTieuChi";
            this.txtTieuChi.Size = new System.Drawing.Size(170, 22);
            this.txtTieuChi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiêu chí";
            // 
            // txtThongTinYC
            // 
            this.txtThongTinYC.Location = new System.Drawing.Point(105, 126);
            this.txtThongTinYC.Name = "txtThongTinYC";
            this.txtThongTinYC.Size = new System.Drawing.Size(170, 22);
            this.txtThongTinYC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thông tin yc";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(105, 78);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(170, 22);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonHuy);
            this.panel1.Controls.Add(this.Error);
            this.panel1.Controls.Add(this.buttonThemKhachHang);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonChinhSua);
            this.panel1.Controls.Add(this.txtMaNhanVien);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMaChiNhanh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkNam);
            this.panel1.Controls.Add(this.checkNu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTieuChi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtThongTinYC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(40, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 756);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(572, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "Danh sách";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(493, 28);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(170, 22);
            this.txtSdt.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Sđt";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(105, 28);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(170, 22);
            this.txtHoTen.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Họ tên";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Location = new System.Drawing.Point(571, 685);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(111, 28);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "Quay về";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTimKiem.Location = new System.Drawing.Point(953, 367);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(110, 28);
            this.buttonTimKiem.TabIndex = 17;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(893, 318);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(170, 22);
            this.txtTimKiem.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(826, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Họ tên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::QuanLyNhaDat.Properties.Resources.business_costume_male_man_office_user_icon_1320196264882354682;
            this.pictureBox1.Location = new System.Drawing.Point(786, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            // SoNhaSoHuu
            // 
            this.SoNhaSoHuu.HeaderText = "So nha so huu";
            this.SoNhaSoHuu.MinimumWidth = 6;
            this.SoNhaSoHuu.Name = "SoNhaSoHuu";
            this.SoNhaSoHuu.Text = "So luong";
            this.SoNhaSoHuu.UseColumnTextForButtonValue = true;
            this.SoNhaSoHuu.Width = 125;
            // 
            // QuanLyKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1075, 816);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyKH";
            this.Text = "QuanLyKH";
            this.Load += new System.EventHandler(this.QuanLyKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.TextBox Error;
        private System.Windows.Forms.Button buttonThemKhachHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonChinhSua;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaChiNhanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkNam;
        private System.Windows.Forms.CheckBox checkNu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTieuChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThongTinYC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn SoNhaSoHuu;
    }
}
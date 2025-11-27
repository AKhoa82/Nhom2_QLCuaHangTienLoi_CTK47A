namespace QLCuaHang
{
    partial class MainForm
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
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_DanhMuc = new System.Windows.Forms.ComboBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.flpn_DanhSachHangHoa = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_HoaDon = new System.Windows.Forms.Panel();
            this.lbl_ThanhToan = new System.Windows.Forms.Label();
            this.nm_GiamGia = new System.Windows.Forms.NumericUpDown();
            this.mtxt_SĐT = new System.Windows.Forms.MaskedTextBox();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpn_SanPhamDaChon = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_InBill = new System.Windows.Forms.Button();
            this.txt_Diem = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.cbo_Loai = new System.Windows.Forms.ComboBox();
            this.lb_Loai = new System.Windows.Forms.Label();
            this.lb_GiamGia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_TongCong = new System.Windows.Forms.Label();
            this.lb_Diem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.pn_Menu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pn_HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_GiamGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_HoaDon);
            this.panel1.Controls.Add(this.btn_KhachHang);
            this.panel1.Controls.Add(this.btnDoanhThu);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnHangHoa);
            this.panel1.Controls.Add(this.pcLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 612);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoaDon.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_HoaDon.Location = new System.Drawing.Point(0, 381);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(200, 47);
            this.btn_HoaDon.TabIndex = 6;
            this.btn_HoaDon.Text = "Hóa đơn";
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_KhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KhachHang.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_KhachHang.Location = new System.Drawing.Point(1, 328);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(200, 47);
            this.btn_KhachHang.TabIndex = 5;
            this.btn_KhachHang.Text = "Khách hàng";
            this.btn_KhachHang.UseVisualStyleBackColor = false;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThu.Location = new System.Drawing.Point(0, 222);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(200, 47);
            this.btnDoanhThu.TabIndex = 5;
            this.btnDoanhThu.Text = "Doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 275);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(200, 47);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.BackColor = System.Drawing.Color.SandyBrown;
            this.btnHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangHoa.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnHangHoa.Location = new System.Drawing.Point(0, 170);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(200, 47);
            this.btnHangHoa.TabIndex = 4;
            this.btnHangHoa.Text = "Hàng hóa";
            this.btnHangHoa.UseVisualStyleBackColor = false;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // pcLogo
            // 
            this.pcLogo.Image = global::QLCuaHang.Properties.Resources.logo;
            this.pcLogo.Location = new System.Drawing.Point(45, 11);
            this.pcLogo.MaximumSize = new System.Drawing.Size(100, 89);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(100, 89);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLogo.TabIndex = 1;
            this.pcLogo.TabStop = false;
            // 
            // pn_Menu
            // 
            this.pn_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Menu.Controls.Add(this.groupBox2);
            this.pn_Menu.Controls.Add(this.flpn_DanhSachHangHoa);
            this.pn_Menu.Location = new System.Drawing.Point(200, 0);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(579, 612);
            this.pn_Menu.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbo_DanhMuc);
            this.groupBox2.Controls.Add(this.txt_TimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 72);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm hàng hóa";
            // 
            // cbo_DanhMuc
            // 
            this.cbo_DanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_DanhMuc.FormattingEnabled = true;
            this.cbo_DanhMuc.Location = new System.Drawing.Point(424, 27);
            this.cbo_DanhMuc.Name = "cbo_DanhMuc";
            this.cbo_DanhMuc.Size = new System.Drawing.Size(132, 28);
            this.cbo_DanhMuc.TabIndex = 1;
            this.cbo_DanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbo_DanhMuc_SelectedIndexChanged);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txt_TimKiem.Location = new System.Drawing.Point(6, 27);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(412, 30);
            this.txt_TimKiem.TabIndex = 0;
            this.txt_TimKiem.Text = "Nhập để tìm kiếm...";
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.Enter += new System.EventHandler(this.txt_TimKiem_Enter);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            // 
            // flpn_DanhSachHangHoa
            // 
            this.flpn_DanhSachHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpn_DanhSachHangHoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpn_DanhSachHangHoa.ForeColor = System.Drawing.Color.Black;
            this.flpn_DanhSachHangHoa.Location = new System.Drawing.Point(9, 79);
            this.flpn_DanhSachHangHoa.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.flpn_DanhSachHangHoa.Name = "flpn_DanhSachHangHoa";
            this.flpn_DanhSachHangHoa.Size = new System.Drawing.Size(560, 530);
            this.flpn_DanhSachHangHoa.TabIndex = 2;
            // 
            // pn_HoaDon
            // 
            this.pn_HoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_HoaDon.Controls.Add(this.lbl_ThanhToan);
            this.pn_HoaDon.Controls.Add(this.nm_GiamGia);
            this.pn_HoaDon.Controls.Add(this.mtxt_SĐT);
            this.pn_HoaDon.Controls.Add(this.lb_SDT);
            this.pn_HoaDon.Controls.Add(this.lbl_TongTien);
            this.pn_HoaDon.Controls.Add(this.groupBox1);
            this.pn_HoaDon.Controls.Add(this.btn_Huy);
            this.pn_HoaDon.Controls.Add(this.btn_InBill);
            this.pn_HoaDon.Controls.Add(this.txt_Diem);
            this.pn_HoaDon.Controls.Add(this.txt_TenKH);
            this.pn_HoaDon.Controls.Add(this.cbo_Loai);
            this.pn_HoaDon.Controls.Add(this.lb_Loai);
            this.pn_HoaDon.Controls.Add(this.lb_GiamGia);
            this.pn_HoaDon.Controls.Add(this.label1);
            this.pn_HoaDon.Controls.Add(this.lb_TongCong);
            this.pn_HoaDon.Controls.Add(this.lb_Diem);
            this.pn_HoaDon.Controls.Add(this.label3);
            this.pn_HoaDon.Controls.Add(this.lb_Ten);
            this.pn_HoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_HoaDon.Location = new System.Drawing.Point(779, 0);
            this.pn_HoaDon.Name = "pn_HoaDon";
            this.pn_HoaDon.Size = new System.Drawing.Size(422, 612);
            this.pn_HoaDon.TabIndex = 2;
            // 
            // lbl_ThanhToan
            // 
            this.lbl_ThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ThanhToan.AutoSize = true;
            this.lbl_ThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhToan.ForeColor = System.Drawing.Color.Black;
            this.lbl_ThanhToan.Location = new System.Drawing.Point(150, 519);
            this.lbl_ThanhToan.Name = "lbl_ThanhToan";
            this.lbl_ThanhToan.Size = new System.Drawing.Size(15, 23);
            this.lbl_ThanhToan.TabIndex = 14;
            this.lbl_ThanhToan.Text = ".";
            // 
            // nm_GiamGia
            // 
            this.nm_GiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nm_GiamGia.Location = new System.Drawing.Point(325, 464);
            this.nm_GiamGia.Name = "nm_GiamGia";
            this.nm_GiamGia.Size = new System.Drawing.Size(81, 27);
            this.nm_GiamGia.TabIndex = 13;
            // 
            // mtxt_SĐT
            // 
            this.mtxt_SĐT.Location = new System.Drawing.Point(263, 44);
            this.mtxt_SĐT.Mask = "(0000)\\.000\\.000";
            this.mtxt_SĐT.Name = "mtxt_SĐT";
            this.mtxt_SĐT.Size = new System.Drawing.Size(147, 27);
            this.mtxt_SĐT.TabIndex = 12;
            this.mtxt_SĐT.Leave += new System.EventHandler(this.mtxt_SĐT_Leave);
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SDT.ForeColor = System.Drawing.Color.Black;
            this.lb_SDT.Location = new System.Drawing.Point(214, 49);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(43, 19);
            this.lb_SDT.TabIndex = 11;
            this.lb_SDT.Text = "SĐT:";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.ForeColor = System.Drawing.Color.Red;
            this.lbl_TongTien.Location = new System.Drawing.Point(114, 467);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(13, 19);
            this.lbl_TongTien.TabIndex = 10;
            this.lbl_TongTien.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flpn_SanPhamDaChon);
            this.groupBox1.Location = new System.Drawing.Point(4, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 291);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hàng hóa";
            // 
            // flpn_SanPhamDaChon
            // 
            this.flpn_SanPhamDaChon.AllowDrop = true;
            this.flpn_SanPhamDaChon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpn_SanPhamDaChon.AutoScroll = true;
            this.flpn_SanPhamDaChon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpn_SanPhamDaChon.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpn_SanPhamDaChon.Location = new System.Drawing.Point(3, 23);
            this.flpn_SanPhamDaChon.Name = "flpn_SanPhamDaChon";
            this.flpn_SanPhamDaChon.Size = new System.Drawing.Size(409, 265);
            this.flpn_SanPhamDaChon.TabIndex = 0;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Huy.BackColor = System.Drawing.Color.Red;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Huy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(237, 565);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(99, 23);
            this.btn_Huy.TabIndex = 8;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_InBill
            // 
            this.btn_InBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InBill.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_InBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InBill.ForeColor = System.Drawing.Color.Black;
            this.btn_InBill.Location = new System.Drawing.Point(73, 565);
            this.btn_InBill.Name = "btn_InBill";
            this.btn_InBill.Size = new System.Drawing.Size(99, 23);
            this.btn_InBill.TabIndex = 8;
            this.btn_InBill.Text = "In Bill";
            this.btn_InBill.UseVisualStyleBackColor = false;
            this.btn_InBill.Click += new System.EventHandler(this.btn_InBill_Click);
            // 
            // txt_Diem
            // 
            this.txt_Diem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Diem.Location = new System.Drawing.Point(64, 117);
            this.txt_Diem.Name = "txt_Diem";
            this.txt_Diem.Size = new System.Drawing.Size(346, 28);
            this.txt_Diem.TabIndex = 6;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(64, 45);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(135, 28);
            this.txt_TenKH.TabIndex = 6;
            // 
            // cbo_Loai
            // 
            this.cbo_Loai.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Loai.FormattingEnabled = true;
            this.cbo_Loai.Location = new System.Drawing.Point(64, 79);
            this.cbo_Loai.Name = "cbo_Loai";
            this.cbo_Loai.Size = new System.Drawing.Size(346, 28);
            this.cbo_Loai.TabIndex = 5;
            // 
            // lb_Loai
            // 
            this.lb_Loai.AutoSize = true;
            this.lb_Loai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Loai.ForeColor = System.Drawing.Color.Black;
            this.lb_Loai.Location = new System.Drawing.Point(6, 82);
            this.lb_Loai.Name = "lb_Loai";
            this.lb_Loai.Size = new System.Drawing.Size(45, 19);
            this.lb_Loai.TabIndex = 3;
            this.lb_Loai.Text = "Loại:";
            // 
            // lb_GiamGia
            // 
            this.lb_GiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_GiamGia.AutoSize = true;
            this.lb_GiamGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GiamGia.ForeColor = System.Drawing.Color.Black;
            this.lb_GiamGia.Location = new System.Drawing.Point(214, 467);
            this.lb_GiamGia.Name = "lb_GiamGia";
            this.lb_GiamGia.Size = new System.Drawing.Size(105, 19);
            this.lb_GiamGia.TabIndex = 4;
            this.lb_GiamGia.Text = "Giảm giá (%):";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thanh toán:";
            // 
            // lb_TongCong
            // 
            this.lb_TongCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TongCong.AutoSize = true;
            this.lb_TongCong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongCong.ForeColor = System.Drawing.Color.Black;
            this.lb_TongCong.Location = new System.Drawing.Point(4, 467);
            this.lb_TongCong.Name = "lb_TongCong";
            this.lb_TongCong.Size = new System.Drawing.Size(85, 19);
            this.lb_TongCong.TabIndex = 4;
            this.lb_TongCong.Text = "Tổng cộng:";
            // 
            // lb_Diem
            // 
            this.lb_Diem.AutoSize = true;
            this.lb_Diem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Diem.ForeColor = System.Drawing.Color.Black;
            this.lb_Diem.Location = new System.Drawing.Point(6, 119);
            this.lb_Diem.Name = "lb_Diem";
            this.lb_Diem.Size = new System.Drawing.Size(52, 19);
            this.lb_Diem.TabIndex = 4;
            this.lb_Diem.Text = "Điểm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(149, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "KHÁCH HÀNG";
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ten.ForeColor = System.Drawing.Color.Black;
            this.lb_Ten.Location = new System.Drawing.Point(6, 47);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(39, 19);
            this.lb_Ten.TabIndex = 4;
            this.lb_Ten.Text = "Tên:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 612);
            this.Controls.Add(this.pn_HoaDon);
            this.Controls.Add(this.pn_Menu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.pn_Menu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pn_HoaDon.ResumeLayout(false);
            this.pn_HoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_GiamGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcLogo;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Panel pn_Menu;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Panel pn_HoaDon;
        private System.Windows.Forms.Label lb_Loai;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.ComboBox cbo_Loai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_Diem;
        private System.Windows.Forms.Label lb_Diem;
        private System.Windows.Forms.Button btn_KhachHang;
        private System.Windows.Forms.Label lb_TongCong;
        private System.Windows.Forms.Label lb_GiamGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_InBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpn_SanPhamDaChon;
        private System.Windows.Forms.FlowLayoutPanel flpn_DanhSachHangHoa;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_DanhMuc;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.NumericUpDown nm_GiamGia;
        private System.Windows.Forms.MaskedTextBox mtxt_SĐT;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label lbl_ThanhToan;
    }
}


namespace QLCuaHang
{
    partial class frm_KhachHang
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rad_TimKiemLoai = new System.Windows.Forms.RadioButton();
            this.rad_TimKiemMa = new System.Windows.Forms.RadioButton();
            this.rad_TimKiemTen = new System.Windows.Forms.RadioButton();
            this.dgv_DSKH = new System.Windows.Forms.DataGridView();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.txt_SDT = new System.Windows.Forms.MaskedTextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_Diem = new System.Windows.Forms.TextBox();
            this.lbl_DiemTichLuy = new System.Windows.Forms.Label();
            this.lbl_SĐT = new System.Windows.Forms.Label();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.btn_TatCa = new System.Windows.Forms.Button();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSKH)).BeginInit();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaKháchHàngToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 28);
            // 
            // xóaKháchHàngToolStripMenuItem
            // 
            this.xóaKháchHàngToolStripMenuItem.Name = "xóaKháchHàngToolStripMenuItem";
            this.xóaKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.xóaKháchHàngToolStripMenuItem.Text = "Xóa khách hàng";
            // 
            // rad_TimKiemLoai
            // 
            this.rad_TimKiemLoai.AutoSize = true;
            this.rad_TimKiemLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_TimKiemLoai.Location = new System.Drawing.Point(744, 15);
            this.rad_TimKiemLoai.Name = "rad_TimKiemLoai";
            this.rad_TimKiemLoai.Size = new System.Drawing.Size(67, 26);
            this.rad_TimKiemLoai.TabIndex = 30;
            this.rad_TimKiemLoai.TabStop = true;
            this.rad_TimKiemLoai.Text = "Loại";
            this.rad_TimKiemLoai.UseVisualStyleBackColor = true;
            // 
            // rad_TimKiemMa
            // 
            this.rad_TimKiemMa.AutoSize = true;
            this.rad_TimKiemMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_TimKiemMa.Location = new System.Drawing.Point(676, 15);
            this.rad_TimKiemMa.Name = "rad_TimKiemMa";
            this.rad_TimKiemMa.Size = new System.Drawing.Size(57, 26);
            this.rad_TimKiemMa.TabIndex = 31;
            this.rad_TimKiemMa.TabStop = true;
            this.rad_TimKiemMa.Text = "Mã";
            this.rad_TimKiemMa.UseVisualStyleBackColor = true;
            // 
            // rad_TimKiemTen
            // 
            this.rad_TimKiemTen.AutoSize = true;
            this.rad_TimKiemTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_TimKiemTen.Location = new System.Drawing.Point(605, 15);
            this.rad_TimKiemTen.Name = "rad_TimKiemTen";
            this.rad_TimKiemTen.Size = new System.Drawing.Size(61, 26);
            this.rad_TimKiemTen.TabIndex = 32;
            this.rad_TimKiemTen.TabStop = true;
            this.rad_TimKiemTen.Text = "Tên";
            this.rad_TimKiemTen.UseVisualStyleBackColor = true;
            // 
            // dgv_DSKH
            // 
            this.dgv_DSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSKH.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_DSKH.Location = new System.Drawing.Point(12, 60);
            this.dgv_DSKH.Name = "dgv_DSKH";
            this.dgv_DSKH.ReadOnly = true;
            this.dgv_DSKH.RowHeadersWidth = 51;
            this.dgv_DSKH.Size = new System.Drawing.Size(714, 502);
            this.dgv_DSKH.TabIndex = 29;
            this.dgv_DSKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSKH_CellClick);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.btn_TimKiem.Location = new System.Drawing.Point(472, 12);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(104, 29);
            this.btn_TimKiem.TabIndex = 26;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(12, 12);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(454, 30);
            this.txt_TimKiem.TabIndex = 25;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.txt_SDT);
            this.panelInput.Controls.Add(this.txt_MaKH);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.btn_Luu);
            this.panelInput.Controls.Add(this.txt_Diem);
            this.panelInput.Controls.Add(this.lbl_DiemTichLuy);
            this.panelInput.Controls.Add(this.lbl_SĐT);
            this.panelInput.Controls.Add(this.txt_TenKH);
            this.panelInput.Controls.Add(this.lbl_HoTen);
            this.panelInput.Location = new System.Drawing.Point(765, 114);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(289, 375);
            this.panelInput.TabIndex = 24;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(124, 141);
            this.txt_SDT.Mask = "(0000)\\.000\\.000";
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(150, 25);
            this.txt_SDT.TabIndex = 16;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKH.Location = new System.Drawing.Point(124, 65);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(150, 25);
            this.txt_MaKH.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã khách hàng:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(108, 279);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 29);
            this.btn_Luu.TabIndex = 11;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txt_Diem
            // 
            this.txt_Diem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Diem.Location = new System.Drawing.Point(124, 179);
            this.txt_Diem.Name = "txt_Diem";
            this.txt_Diem.ReadOnly = true;
            this.txt_Diem.Size = new System.Drawing.Size(150, 25);
            this.txt_Diem.TabIndex = 5;
            // 
            // lbl_DiemTichLuy
            // 
            this.lbl_DiemTichLuy.AutoSize = true;
            this.lbl_DiemTichLuy.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiemTichLuy.Location = new System.Drawing.Point(7, 185);
            this.lbl_DiemTichLuy.Name = "lbl_DiemTichLuy";
            this.lbl_DiemTichLuy.Size = new System.Drawing.Size(115, 19);
            this.lbl_DiemTichLuy.TabIndex = 4;
            this.lbl_DiemTichLuy.Text = "Điểm tích lũy:";
            // 
            // lbl_SĐT
            // 
            this.lbl_SĐT.AutoSize = true;
            this.lbl_SĐT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SĐT.Location = new System.Drawing.Point(7, 145);
            this.lbl_SĐT.Name = "lbl_SĐT";
            this.lbl_SĐT.Size = new System.Drawing.Size(45, 19);
            this.lbl_SĐT.TabIndex = 2;
            this.lbl_SĐT.Text = "SĐT:";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(124, 101);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(150, 25);
            this.txt_TenKH.TabIndex = 1;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(7, 107);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(42, 19);
            this.lbl_HoTen.TabIndex = 0;
            this.lbl_HoTen.Text = "Tên:";
            // 
            // btn_TatCa
            // 
            this.btn_TatCa.BackColor = System.Drawing.Color.Transparent;
            this.btn_TatCa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TatCa.ForeColor = System.Drawing.Color.Black;
            this.btn_TatCa.Location = new System.Drawing.Point(815, 12);
            this.btn_TatCa.Name = "btn_TatCa";
            this.btn_TatCa.Size = new System.Drawing.Size(75, 29);
            this.btn_TatCa.TabIndex = 27;
            this.btn_TatCa.Text = "Tất cả";
            this.btn_TatCa.UseVisualStyleBackColor = false;
            this.btn_TatCa.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_TroVe.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe.ForeColor = System.Drawing.Color.White;
            this.btn_TroVe.Location = new System.Drawing.Point(979, 13);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(75, 29);
            this.btn_TroVe.TabIndex = 28;
            this.btn_TroVe.Text = "Trở về";
            this.btn_TroVe.UseVisualStyleBackColor = false;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 574);
            this.Controls.Add(this.rad_TimKiemLoai);
            this.Controls.Add(this.rad_TimKiemMa);
            this.Controls.Add(this.rad_TimKiemTen);
            this.Controls.Add(this.dgv_DSKH);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.btn_TatCa);
            this.Controls.Add(this.btn_TroVe);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_KhachHang";
            this.Text = "frm_KhachHang";
            this.Load += new System.EventHandler(this.frm_KhachHang_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSKH)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaKháchHàngToolStripMenuItem;
        private System.Windows.Forms.RadioButton rad_TimKiemLoai;
        private System.Windows.Forms.RadioButton rad_TimKiemMa;
        private System.Windows.Forms.RadioButton rad_TimKiemTen;
        private System.Windows.Forms.DataGridView dgv_DSKH;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.MaskedTextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_Diem;
        private System.Windows.Forms.Label lbl_DiemTichLuy;
        private System.Windows.Forms.Label lbl_SĐT;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Button btn_TatCa;
        private System.Windows.Forms.Button btn_TroVe;
    }
}
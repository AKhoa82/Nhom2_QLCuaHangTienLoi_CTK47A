namespace QLCuaHang
{
    partial class frm_Account
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
            this.panelInput = new System.Windows.Forms.Panel();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.cbo_Actived = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_Role = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.mtxt_SDT = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInput.Controls.Add(this.btn_Huy);
            this.panelInput.Controls.Add(this.cbo_Actived);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.cbo_Role);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.txt_Email);
            this.panelInput.Controls.Add(this.mtxt_SDT);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.txt_AccountName);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.btn_Luu);
            this.panelInput.Controls.Add(this.txt_MatKhau);
            this.panelInput.Controls.Add(this.lblPassword);
            this.panelInput.Controls.Add(this.txt_HoTen);
            this.panelInput.Controls.Add(this.lblHoTen);
            this.panelInput.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInput.Location = new System.Drawing.Point(783, 91);
            this.panelInput.Margin = new System.Windows.Forms.Padding(4);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(413, 500);
            this.panelInput.TabIndex = 2;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Huy.BackColor = System.Drawing.Color.Red;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Huy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(244, 395);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(107, 39);
            this.btn_Huy.TabIndex = 15;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // cbo_Actived
            // 
            this.cbo_Actived.FormattingEnabled = true;
            this.cbo_Actived.Location = new System.Drawing.Point(171, 285);
            this.cbo_Actived.Name = "cbo_Actived";
            this.cbo_Actived.Size = new System.Drawing.Size(213, 28);
            this.cbo_Actived.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Actived:";
            // 
            // cbo_Role
            // 
            this.cbo_Role.FormattingEnabled = true;
            this.cbo_Role.Location = new System.Drawing.Point(171, 247);
            this.cbo_Role.Name = "cbo_Role";
            this.cbo_Role.Size = new System.Drawing.Size(213, 28);
            this.cbo_Role.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Role:";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(171, 111);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(213, 28);
            this.txt_Email.TabIndex = 23;
            // 
            // mtxt_SDT
            // 
            this.mtxt_SDT.Location = new System.Drawing.Point(171, 156);
            this.mtxt_SDT.Mask = "0000\\.000\\.000";
            this.mtxt_SDT.Name = "mtxt_SDT";
            this.mtxt_SDT.Size = new System.Drawing.Size(213, 28);
            this.mtxt_SDT.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tell:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email:";
            // 
            // txt_AccountName
            // 
            this.txt_AccountName.Enabled = false;
            this.txt_AccountName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccountName.Location = new System.Drawing.Point(171, 15);
            this.txt_AccountName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AccountName.Name = "txt_AccountName";
            this.txt_AccountName.Size = new System.Drawing.Size(213, 28);
            this.txt_AccountName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Account Name: ";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(112, 395);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(107, 39);
            this.btn_Luu.TabIndex = 11;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(171, 202);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(213, 28);
            this.txt_MatKhau.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(29, 211);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(93, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Pass Word:";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(171, 61);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(213, 28);
            this.txt_HoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(29, 70);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(93, 19);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Full Name:";
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_TroVe.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe.ForeColor = System.Drawing.Color.White;
            this.btn_TroVe.Location = new System.Drawing.Point(1399, 17);
            this.btn_TroVe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(107, 39);
            this.btn_TroVe.TabIndex = 13;
            this.btn_TroVe.Text = "Trở về";
            this.btn_TroVe.UseVisualStyleBackColor = false;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_TimKiem.Location = new System.Drawing.Point(13, 13);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(762, 30);
            this.txt_TimKiem.TabIndex = 3;
            this.txt_TimKiem.Text = "Nhập tên nhân viên cần tìm...";
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.Enter += new System.EventHandler(this.txt_TimKiem_Enter);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AllowUserToResizeColumns = false;
            this.dgv_NhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_NhanVien.Location = new System.Drawing.Point(0, 63);
            this.dgv_NhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(775, 545);
            this.dgv_NhanVien.TabIndex = 14;
            this.dgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellClick);
            this.dgv_NhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_NhanVien_CellFormatting);
            this.dgv_NhanVien.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_NhanVien_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaNhânViênToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // xóaNhânViênToolStripMenuItem
            // 
            this.xóaNhânViênToolStripMenuItem.Name = "xóaNhânViênToolStripMenuItem";
            this.xóaNhânViênToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.xóaNhânViênToolStripMenuItem.Text = "Inactive";
            this.xóaNhânViênToolStripMenuItem.Click += new System.EventHandler(this.xóaNhânViênToolStripMenuItem_Click);
            // 
            // frm_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 612);
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.btn_TroVe);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Account_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txt_AccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxt_SDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaNhânViênToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.ComboBox cbo_Actived;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_Role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Huy;
    }
}
namespace QLCuaHang
{
    partial class frm_HoaDon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.dgv_ChiTiet = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ThucThu = new System.Windows.Forms.Label();
            this.lbl_GiamGia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTiet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_TaiLai);
            this.panel1.Controls.Add(this.btn_ThongKe);
            this.panel1.Controls.Add(this.dtp_To);
            this.panel1.Controls.Add(this.dtp_From);
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 130);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đến ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Từ ngày:";
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.Location = new System.Drawing.Point(737, 19);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(100, 28);
            this.btn_TaiLai.TabIndex = 3;
            this.btn_TaiLai.Text = "Tải lại";
            this.btn_TaiLai.UseVisualStyleBackColor = true;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Location = new System.Drawing.Point(737, 63);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(100, 28);
            this.btn_ThongKe.TabIndex = 2;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // dtp_To
            // 
            this.dtp_To.CustomFormat = "dd/MM/yyyy";
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_To.Location = new System.Drawing.Point(201, 78);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(318, 28);
            this.dtp_To.TabIndex = 1;
            // 
            // dtp_From
            // 
            this.dtp_From.CustomFormat = "dd/MM/yyyy";
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_From.Location = new System.Drawing.Point(201, 13);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(318, 28);
            this.dtp_From.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_HoaDon, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ChiTiet, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 144);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 259);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HoaDon.Location = new System.Drawing.Point(3, 3);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersVisible = false;
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.Size = new System.Drawing.Size(474, 253);
            this.dgv_HoaDon.TabIndex = 0;
            this.dgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellClick);
            // 
            // dgv_ChiTiet
            // 
            this.dgv_ChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ChiTiet.Location = new System.Drawing.Point(483, 3);
            this.dgv_ChiTiet.Name = "dgv_ChiTiet";
            this.dgv_ChiTiet.RowHeadersVisible = false;
            this.dgv_ChiTiet.RowHeadersWidth = 51;
            this.dgv_ChiTiet.RowTemplate.Height = 24;
            this.dgv_ChiTiet.Size = new System.Drawing.Size(474, 253);
            this.dgv_ChiTiet.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lbl_ThucThu);
            this.panel2.Controls.Add(this.lbl_GiamGia);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_TongTien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 70);
            this.panel2.TabIndex = 15;
            // 
            // lbl_ThucThu
            // 
            this.lbl_ThucThu.AutoSize = true;
            this.lbl_ThucThu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThucThu.ForeColor = System.Drawing.Color.Red;
            this.lbl_ThucThu.Location = new System.Drawing.Point(914, 20);
            this.lbl_ThucThu.Name = "lbl_ThucThu";
            this.lbl_ThucThu.Size = new System.Drawing.Size(14, 20);
            this.lbl_ThucThu.TabIndex = 5;
            this.lbl_ThucThu.Text = ".";
            // 
            // lbl_GiamGia
            // 
            this.lbl_GiamGia.AutoSize = true;
            this.lbl_GiamGia.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiamGia.ForeColor = System.Drawing.Color.Red;
            this.lbl_GiamGia.Location = new System.Drawing.Point(536, 20);
            this.lbl_GiamGia.Name = "lbl_GiamGia";
            this.lbl_GiamGia.Size = new System.Drawing.Size(14, 20);
            this.lbl_GiamGia.TabIndex = 4;
            this.lbl_GiamGia.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(832, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thực thu";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.ForeColor = System.Drawing.Color.Red;
            this.lbl_TongTien.Location = new System.Drawing.Point(183, 20);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(14, 20);
            this.lbl_TongTien.TabIndex = 3;
            this.lbl_TongTien.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giảm giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền chưa giảm";
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_HoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTiet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.Button btn_TaiLai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.DataGridView dgv_ChiTiet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ThucThu;
        private System.Windows.Forms.Label lbl_GiamGia;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

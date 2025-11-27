namespace QLCuaHang
{
    partial class frm_DoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txt_NamOnly = new System.Windows.Forms.TextBox();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.cbo_ChartMode = new System.Windows.Forms.ComboBox();
            this.txt_BanItNhat = new System.Windows.Forms.TextBox();
            this.txt_BanNhieuNhat = new System.Windows.Forms.TextBox();
            this.txt_TongDoanhThu = new System.Windows.Forms.TextBox();
            this.chart_DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.rad_TheoNam = new System.Windows.Forms.RadioButton();
            this.rad_TheoThang = new System.Windows.Forms.RadioButton();
            this.rad_TheoNgay = new System.Windows.Forms.RadioButton();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.cbo_Thang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NamOnly
            // 
            this.txt_NamOnly.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_NamOnly.Location = new System.Drawing.Point(163, 76);
            this.txt_NamOnly.Name = "txt_NamOnly";
            this.txt_NamOnly.Size = new System.Drawing.Size(94, 28);
            this.txt_NamOnly.TabIndex = 29;
            // 
            // txt_Nam
            // 
            this.txt_Nam.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_Nam.Location = new System.Drawing.Point(382, 44);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(102, 28);
            this.txt_Nam.TabIndex = 28;
            // 
            // cbo_ChartMode
            // 
            this.cbo_ChartMode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbo_ChartMode.FormattingEnabled = true;
            this.cbo_ChartMode.Location = new System.Drawing.Point(1039, 206);
            this.cbo_ChartMode.Name = "cbo_ChartMode";
            this.cbo_ChartMode.Size = new System.Drawing.Size(134, 27);
            this.cbo_ChartMode.TabIndex = 27;
            this.cbo_ChartMode.SelectedIndexChanged += new System.EventHandler(this.cbo_ChartMode_SelectedIndexChanged);
            // 
            // txt_BanItNhat
            // 
            this.txt_BanItNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BanItNhat.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_BanItNhat.Location = new System.Drawing.Point(922, 191);
            this.txt_BanItNhat.Name = "txt_BanItNhat";
            this.txt_BanItNhat.Size = new System.Drawing.Size(241, 29);
            this.txt_BanItNhat.TabIndex = 26;
            // 
            // txt_BanNhieuNhat
            // 
            this.txt_BanNhieuNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BanNhieuNhat.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_BanNhieuNhat.Location = new System.Drawing.Point(922, 154);
            this.txt_BanNhieuNhat.Name = "txt_BanNhieuNhat";
            this.txt_BanNhieuNhat.Size = new System.Drawing.Size(241, 29);
            this.txt_BanNhieuNhat.TabIndex = 25;
            // 
            // txt_TongDoanhThu
            // 
            this.txt_TongDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_TongDoanhThu.Location = new System.Drawing.Point(922, 114);
            this.txt_TongDoanhThu.Name = "txt_TongDoanhThu";
            this.txt_TongDoanhThu.Size = new System.Drawing.Size(241, 29);
            this.txt_TongDoanhThu.TabIndex = 24;
            // 
            // chart_DoanhThu
            // 
            this.chart_DoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea9.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 8F);
            chartArea9.AxisX.TitleFont = new System.Drawing.Font("Arial", 8F);
            chartArea9.AxisX2.LabelStyle.Font = new System.Drawing.Font("Arial", 8F);
            chartArea9.AxisX2.TitleFont = new System.Drawing.Font("Arial", 8F);
            chartArea9.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 8F);
            chartArea9.AxisY.TitleFont = new System.Drawing.Font("Arial", 8F);
            chartArea9.AxisY2.LabelStyle.Font = new System.Drawing.Font("Arial", 8F);
            chartArea9.AxisY2.TitleFont = new System.Drawing.Font("Arial", 8F);
            chartArea9.Name = "ChartArea1";
            this.chart_DoanhThu.ChartAreas.Add(chartArea9);
            legend9.Font = new System.Drawing.Font("Arial", 8F);
            legend9.Name = "Legend1";
            legend9.TitleFont = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chart_DoanhThu.Legends.Add(legend9);
            this.chart_DoanhThu.Location = new System.Drawing.Point(747, 315);
            this.chart_DoanhThu.Name = "chart_DoanhThu";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart_DoanhThu.Series.Add(series9);
            this.chart_DoanhThu.Size = new System.Drawing.Size(426, 316);
            this.chart_DoanhThu.TabIndex = 23;
            this.chart_DoanhThu.Text = "chart1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label3.Location = new System.Drawing.Point(757, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bán ít nhất :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label2.Location = new System.Drawing.Point(757, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Bán nhiều nhất :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(758, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tổng doanh thu :";
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_HienThi.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.btn_HienThi.Location = new System.Drawing.Point(542, 13);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(133, 88);
            this.btn_HienThi.TabIndex = 19;
            this.btn_HienThi.Text = "Hiện danh sách";
            this.btn_HienThi.UseVisualStyleBackColor = true;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // rad_TheoNam
            // 
            this.rad_TheoNam.AutoSize = true;
            this.rad_TheoNam.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.rad_TheoNam.Location = new System.Drawing.Point(23, 76);
            this.rad_TheoNam.Name = "rad_TheoNam";
            this.rad_TheoNam.Size = new System.Drawing.Size(113, 24);
            this.rad_TheoNam.TabIndex = 18;
            this.rad_TheoNam.TabStop = true;
            this.rad_TheoNam.Text = "Theo năm :";
            this.rad_TheoNam.UseVisualStyleBackColor = true;
            // 
            // rad_TheoThang
            // 
            this.rad_TheoThang.AutoSize = true;
            this.rad_TheoThang.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.rad_TheoThang.Location = new System.Drawing.Point(23, 45);
            this.rad_TheoThang.Name = "rad_TheoThang";
            this.rad_TheoThang.Size = new System.Drawing.Size(121, 24);
            this.rad_TheoThang.TabIndex = 17;
            this.rad_TheoThang.TabStop = true;
            this.rad_TheoThang.Text = "Theo tháng :";
            this.rad_TheoThang.UseVisualStyleBackColor = true;
            // 
            // rad_TheoNgay
            // 
            this.rad_TheoNgay.AutoSize = true;
            this.rad_TheoNgay.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.rad_TheoNgay.Location = new System.Drawing.Point(23, 16);
            this.rad_TheoNgay.Name = "rad_TheoNgay";
            this.rad_TheoNgay.Size = new System.Drawing.Size(116, 24);
            this.rad_TheoNgay.TabIndex = 16;
            this.rad_TheoNgay.TabStop = true;
            this.rad_TheoNgay.Text = "Theo ngày :";
            this.rad_TheoNgay.UseVisualStyleBackColor = true;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Location = new System.Drawing.Point(11, 114);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.Size = new System.Drawing.Size(730, 517);
            this.dgv_HoaDon.TabIndex = 15;
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.dtp_Ngay.Location = new System.Drawing.Point(163, 13);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(211, 28);
            this.dtp_Ngay.TabIndex = 14;
            // 
            // cbo_Thang
            // 
            this.cbo_Thang.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.cbo_Thang.FormattingEnabled = true;
            this.cbo_Thang.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbo_Thang.Location = new System.Drawing.Point(163, 43);
            this.cbo_Thang.Name = "cbo_Thang";
            this.cbo_Thang.Size = new System.Drawing.Size(211, 28);
            this.cbo_Thang.TabIndex = 13;
            // 
            // frm_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 644);
            this.Controls.Add(this.txt_NamOnly);
            this.Controls.Add(this.txt_Nam);
            this.Controls.Add(this.cbo_ChartMode);
            this.Controls.Add(this.txt_BanItNhat);
            this.Controls.Add(this.txt_BanNhieuNhat);
            this.Controls.Add(this.txt_TongDoanhThu);
            this.Controls.Add(this.chart_DoanhThu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.rad_TheoNam);
            this.Controls.Add(this.rad_TheoThang);
            this.Controls.Add(this.rad_TheoNgay);
            this.Controls.Add(this.dgv_HoaDon);
            this.Controls.Add(this.dtp_Ngay);
            this.Controls.Add(this.cbo_Thang);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Name = "frm_DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoanhThu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NamOnly;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.ComboBox cbo_ChartMode;
        private System.Windows.Forms.TextBox txt_BanItNhat;
        private System.Windows.Forms.TextBox txt_BanNhieuNhat;
        private System.Windows.Forms.TextBox txt_TongDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.RadioButton rad_TheoNam;
        private System.Windows.Forms.RadioButton rad_TheoThang;
        private System.Windows.Forms.RadioButton rad_TheoNgay;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.ComboBox cbo_Thang;
    }
}
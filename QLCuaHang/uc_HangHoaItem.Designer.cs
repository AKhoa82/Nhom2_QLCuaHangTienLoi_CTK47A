namespace QLCuaHang
{
    partial class uc_HangHoaItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_HangHoaItem));
            this.tt_TrangThai = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txt_TieuDe = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.nm_GiaBan = new System.Windows.Forms.NumericUpDown();
            this.nm_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.pb_HinhMinhHoa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_GiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HinhMinhHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txt_TieuDe);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.nm_GiaBan);
            this.panel1.Controls.Add(this.nm_SoLuong);
            this.panel1.Controls.Add(this.pb_HinhMinhHoa);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(352, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(282, 12);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(73, 28);
            this.txtTongTien.TabIndex = 17;
            this.txtTongTien.Text = "10.000";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TieuDe
            // 
            this.txt_TieuDe.Location = new System.Drawing.Point(52, 15);
            this.txt_TieuDe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TieuDe.Name = "txt_TieuDe";
            this.txt_TieuDe.Size = new System.Drawing.Size(144, 25);
            this.txt_TieuDe.TabIndex = 16;
            this.txt_TieuDe.Text = "Mì hảo hảo";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(344, 15);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(28, 0);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // nm_GiaBan
            // 
            this.nm_GiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nm_GiaBan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_GiaBan.Location = new System.Drawing.Point(231, 13);
            this.nm_GiaBan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nm_GiaBan.Name = "nm_GiaBan";
            this.nm_GiaBan.ReadOnly = true;
            this.nm_GiaBan.Size = new System.Drawing.Size(53, 28);
            this.nm_GiaBan.TabIndex = 14;
            this.nm_GiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nm_GiaBan.ThousandsSeparator = true;
            // 
            // nm_SoLuong
            // 
            this.nm_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nm_SoLuong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_SoLuong.Location = new System.Drawing.Point(199, 13);
            this.nm_SoLuong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nm_SoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_SoLuong.Name = "nm_SoLuong";
            this.nm_SoLuong.Size = new System.Drawing.Size(30, 28);
            this.nm_SoLuong.TabIndex = 13;
            this.nm_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nm_SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pb_HinhMinhHoa
            // 
            this.pb_HinhMinhHoa.Image = ((System.Drawing.Image)(resources.GetObject("pb_HinhMinhHoa.Image")));
            this.pb_HinhMinhHoa.Location = new System.Drawing.Point(-2, -1);
            this.pb_HinhMinhHoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pb_HinhMinhHoa.Name = "pb_HinhMinhHoa";
            this.pb_HinhMinhHoa.Size = new System.Drawing.Size(50, 49);
            this.pb_HinhMinhHoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_HinhMinhHoa.TabIndex = 11;
            this.pb_HinhMinhHoa.TabStop = false;
            // 
            // uc_HangHoaItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_HangHoaItem";
            this.Size = new System.Drawing.Size(400, 60);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_GiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HinhMinhHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker tt_TrangThai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txt_TieuDe;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.NumericUpDown nm_GiaBan;
        private System.Windows.Forms.NumericUpDown nm_SoLuong;
        private System.Windows.Forms.PictureBox pb_HinhMinhHoa;
        private System.Windows.Forms.Button btnDelete;
    }
}

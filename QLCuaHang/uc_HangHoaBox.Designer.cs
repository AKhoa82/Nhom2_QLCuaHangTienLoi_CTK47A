namespace QLCuaHang
{
    partial class uc_HangHoaBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_HangHoaBox));
            this.txt_SoTien = new System.Windows.Forms.TextBox();
            this.txt_TenHH = new System.Windows.Forms.TextBox();
            this.pb_Hinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Hinh)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.BackColor = System.Drawing.Color.White;
            this.txt_SoTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SoTien.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_SoTien.Enabled = false;
            this.txt_SoTien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoTien.ForeColor = System.Drawing.Color.Black;
            this.txt_SoTien.Location = new System.Drawing.Point(3, 106);
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.ReadOnly = true;
            this.txt_SoTien.ShortcutsEnabled = false;
            this.txt_SoTien.Size = new System.Drawing.Size(118, 21);
            this.txt_SoTien.TabIndex = 1;
            this.txt_SoTien.TabStop = false;
            this.txt_SoTien.Text = "4.000";
            this.txt_SoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TenHH
            // 
            this.txt_TenHH.BackColor = System.Drawing.Color.White;
            this.txt_TenHH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TenHH.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_TenHH.Enabled = false;
            this.txt_TenHH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHH.ForeColor = System.Drawing.Color.Black;
            this.txt_TenHH.Location = new System.Drawing.Point(1, 125);
            this.txt_TenHH.Multiline = true;
            this.txt_TenHH.Name = "txt_TenHH";
            this.txt_TenHH.ReadOnly = true;
            this.txt_TenHH.Size = new System.Drawing.Size(118, 41);
            this.txt_TenHH.TabIndex = 2;
            this.txt_TenHH.Text = "Mì hảo hảo";
            this.txt_TenHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb_Hinh
            // 
            this.pb_Hinh.Image = ((System.Drawing.Image)(resources.GetObject("pb_Hinh.Image")));
            this.pb_Hinh.Location = new System.Drawing.Point(0, 0);
            this.pb_Hinh.Name = "pb_Hinh";
            this.pb_Hinh.Size = new System.Drawing.Size(124, 106);
            this.pb_Hinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Hinh.TabIndex = 0;
            this.pb_Hinh.TabStop = false;
            // 
            // uc_HangHoaBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txt_TenHH);
            this.Controls.Add(this.txt_SoTien);
            this.Controls.Add(this.pb_Hinh);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_HangHoaBox";
            this.Size = new System.Drawing.Size(122, 169);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Hinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_SoTien;
        private System.Windows.Forms.TextBox txt_TenHH;
        private System.Windows.Forms.PictureBox pb_Hinh;
    }
}

namespace QLCuaHang.Forms
{
	partial class frm_ThemNhaCungCap
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

		private void InitializeComponent()
		{
			this.txtTen = new System.Windows.Forms.TextBox();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTen
			// 
			this.txtTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTen.Location = new System.Drawing.Point(166, 26);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(299, 28);
			this.txtTen.TabIndex = 0;
			// 
			// txtSDT
			// 
			this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSDT.Location = new System.Drawing.Point(166, 60);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(137, 28);
			this.txtSDT.TabIndex = 1;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaChi.Location = new System.Drawing.Point(166, 94);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(299, 28);
			this.txtDiaChi.TabIndex = 2;
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(63, 124);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(79, 40);
			this.btnLuu.TabIndex = 3;
			this.btnLuu.Text = "Lưu";
			// 
			// btnHuy
			// 
			this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.Location = new System.Drawing.Point(299, 124);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(84, 40);
			this.btnHuy.TabIndex = 4;
			this.btnHuy.Text = "Hủy";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(18, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Địa chỉ:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(18, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Số điện thoại:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(18, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(142, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Tên nhà cung cấp:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnHuy);
			this.groupBox2.Controls.Add(this.btnLuu);
			this.groupBox2.Controls.Add(this.txtTen);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtDiaChi);
			this.groupBox2.Controls.Add(this.txtSDT);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(13, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(471, 164);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin Nhà cung cấp";
			// 
			// frm_ThemNhaCungCap
			// 
			this.ClientSize = new System.Drawing.Size(496, 188);
			this.Controls.Add(this.groupBox2);
			this.Name = "frm_ThemNhaCungCap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Thêm nhà cung cấp";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	private System.Windows.Forms.Label label6;
	private System.Windows.Forms.GroupBox groupBox2;
	}
}
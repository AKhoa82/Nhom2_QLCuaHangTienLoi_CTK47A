namespace QLCuaHang
{
    partial class frm_ThemDanhMuc
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
            this.lbl_TenDanhMuc = new System.Windows.Forms.Label();
            this.txt_TenDanhMuc = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TenDanhMuc
            // 
            this.lbl_TenDanhMuc.AutoSize = true;
            this.lbl_TenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDanhMuc.Location = new System.Drawing.Point(6, 30);
            this.lbl_TenDanhMuc.Name = "lbl_TenDanhMuc";
            this.lbl_TenDanhMuc.Size = new System.Drawing.Size(120, 20);
            this.lbl_TenDanhMuc.TabIndex = 0;
            this.lbl_TenDanhMuc.Text = "Tên danh mục:";
            // 
            // txt_TenDanhMuc
            // 
            this.txt_TenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDanhMuc.Location = new System.Drawing.Point(150, 30);
            this.txt_TenDanhMuc.Name = "txt_TenDanhMuc";
            this.txt_TenDanhMuc.Size = new System.Drawing.Size(250, 26);
            this.txt_TenDanhMuc.TabIndex = 1;
            this.txt_TenDanhMuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenDanhMuc_KeyPress);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(150, 80);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 35);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(270, 80);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(100, 35);
            this.btn_Huy.TabIndex = 3;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_TenDanhMuc);
            this.groupBox1.Controls.Add(this.txt_TenDanhMuc);
            this.groupBox1.Controls.Add(this.btn_Huy);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin danh mục";
            // 
            // frm_ThemDanhMuc
            // 
            this.AcceptButton = this.btn_Them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Huy;
            this.ClientSize = new System.Drawing.Size(450, 170);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ThemDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm danh mục mới";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_TenDanhMuc;
        private System.Windows.Forms.TextBox txt_TenDanhMuc;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


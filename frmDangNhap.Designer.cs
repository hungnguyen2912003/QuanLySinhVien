namespace QuanLySinhVien
{
    partial class frmDangNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbbLoaiTK = new ComboBox();
            txtTenTK = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 70);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Loại tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 138);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 210);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // cbbLoaiTK
            // 
            cbbLoaiTK.FormattingEnabled = true;
            cbbLoaiTK.Items.AddRange(new object[] { "Quản trị viên", "Giáo viên", "Sinh viên" });
            cbbLoaiTK.Location = new Point(240, 65);
            cbbLoaiTK.Name = "cbbLoaiTK";
            cbbLoaiTK.Size = new Size(200, 28);
            cbbLoaiTK.TabIndex = 1;
            // 
            // txtTenTK
            // 
            txtTenTK.Location = new Point(240, 135);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(200, 27);
            txtTenTK.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(240, 205);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(200, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(160, 270);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(100, 40);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(328, 270);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(btnExit);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenTK);
            Controls.Add(cbbLoaiTK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbLoaiTK;
        private TextBox txtTenTK;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnExit;
    }
}
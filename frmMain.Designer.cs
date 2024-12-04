namespace QuanLySinhVien
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            heThongToolStripMenuItem = new ToolStripMenuItem();
            doiMatKhauToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            quanLyToolStripMenuItem = new ToolStripMenuItem();
            sinhVienToolStripMenuItem = new ToolStripMenuItem();
            giaoVienToolStripMenuItem = new ToolStripMenuItem();
            monHocToolStripMenuItem = new ToolStripMenuItem();
            diemThiToolStripMenuItem = new ToolStripMenuItem();
            lopHocToolStripMenuItem = new ToolStripMenuItem();
            chucNangToolStripMenuItem = new ToolStripMenuItem();
            dangKyToolStripMenuItem = new ToolStripMenuItem();
            traCuuDiemToolStripMenuItem = new ToolStripMenuItem();
            qlyLopToolStripMenuItem = new ToolStripMenuItem();
            pnlContent = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { heThongToolStripMenuItem, quanLyToolStripMenuItem, chucNangToolStripMenuItem, qlyLopToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, thoatToolStripMenuItem });
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(85, 24);
            heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(181, 26);
            doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(181, 26);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // quanLyToolStripMenuItem
            // 
            quanLyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sinhVienToolStripMenuItem, giaoVienToolStripMenuItem, monHocToolStripMenuItem, diemThiToolStripMenuItem, lopHocToolStripMenuItem });
            quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            quanLyToolStripMenuItem.Size = new Size(73, 24);
            quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // sinhVienToolStripMenuItem
            // 
            sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            sinhVienToolStripMenuItem.Size = new Size(154, 26);
            sinhVienToolStripMenuItem.Text = "Sinh viên";
            sinhVienToolStripMenuItem.Click += sinhVienToolStripMenuItem_Click;
            // 
            // giaoVienToolStripMenuItem
            // 
            giaoVienToolStripMenuItem.Name = "giaoVienToolStripMenuItem";
            giaoVienToolStripMenuItem.Size = new Size(154, 26);
            giaoVienToolStripMenuItem.Text = "Giáo viên";
            giaoVienToolStripMenuItem.Click += giaoVienToolStripMenuItem_Click;
            // 
            // monHocToolStripMenuItem
            // 
            monHocToolStripMenuItem.Name = "monHocToolStripMenuItem";
            monHocToolStripMenuItem.Size = new Size(154, 26);
            monHocToolStripMenuItem.Text = "Môn học";
            monHocToolStripMenuItem.Click += monHocToolStripMenuItem_Click;
            // 
            // diemThiToolStripMenuItem
            // 
            diemThiToolStripMenuItem.Name = "diemThiToolStripMenuItem";
            diemThiToolStripMenuItem.Size = new Size(154, 26);
            diemThiToolStripMenuItem.Text = "Điểm thi";
            diemThiToolStripMenuItem.Click += diemThiToolStripMenuItem_Click;
            // 
            // lopHocToolStripMenuItem
            // 
            lopHocToolStripMenuItem.Name = "lopHocToolStripMenuItem";
            lopHocToolStripMenuItem.Size = new Size(154, 26);
            lopHocToolStripMenuItem.Text = "Lớp học";
            lopHocToolStripMenuItem.Click += lopHocToolStripMenuItem_Click;
            // 
            // chucNangToolStripMenuItem
            // 
            chucNangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dangKyToolStripMenuItem, traCuuDiemToolStripMenuItem });
            chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            chucNangToolStripMenuItem.Size = new Size(93, 24);
            chucNangToolStripMenuItem.Text = "Chức năng";
            chucNangToolStripMenuItem.Click += dangKyToolStripMenuItem_Click;
            // 
            // dangKyToolStripMenuItem
            // 
            dangKyToolStripMenuItem.Name = "dangKyToolStripMenuItem";
            dangKyToolStripMenuItem.Size = new Size(224, 26);
            dangKyToolStripMenuItem.Text = "Đăng ký môn học";
            // 
            // traCuuDiemToolStripMenuItem
            // 
            traCuuDiemToolStripMenuItem.Name = "traCuuDiemToolStripMenuItem";
            traCuuDiemToolStripMenuItem.Size = new Size(224, 26);
            traCuuDiemToolStripMenuItem.Text = "Tra cứu điểm";
            traCuuDiemToolStripMenuItem.Click += traCuuDiemToolStripMenuItem_Click;
            // 
            // qlyLopToolStripMenuItem
            // 
            qlyLopToolStripMenuItem.Name = "qlyLopToolStripMenuItem";
            qlyLopToolStripMenuItem.Size = new Size(99, 24);
            qlyLopToolStripMenuItem.Text = "Quản lý lớp";
            qlyLopToolStripMenuItem.Click += qlyLopToolStripMenuItem_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 28);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1262, 645);
            pnlContent.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(pnlContent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main form";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem heThongToolStripMenuItem;
        private ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem quanLyToolStripMenuItem;
        private ToolStripMenuItem sinhVienToolStripMenuItem;
        private ToolStripMenuItem giaoVienToolStripMenuItem;
        private ToolStripMenuItem monHocToolStripMenuItem;
        private ToolStripMenuItem diemThiToolStripMenuItem;
        private ToolStripMenuItem chucNangToolStripMenuItem;
        private Panel pnlContent;
        private ToolStripMenuItem lopHocToolStripMenuItem;
        private ToolStripMenuItem qlyLopToolStripMenuItem;
        private ToolStripMenuItem dangKyToolStripMenuItem;
        private ToolStripMenuItem traCuuDiemToolStripMenuItem;
    }
}

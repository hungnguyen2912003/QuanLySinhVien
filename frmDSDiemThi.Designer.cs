namespace QuanLySinhVien
{
    partial class frmDSDiemThi
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
            txtTuKhoa = new TextBox();
            btnTimKiem = new Button();
            btnThemMoi = new Button();
            cbbMonHoc = new ComboBox();
            dgvDiemThi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDiemThi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(30, 50);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Môn học";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(450, 50);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Từ khoá";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTuKhoa.Location = new Point(520, 45);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(250, 27);
            txtTuKhoa.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(795, 45);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoi.Location = new Point(910, 45);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(94, 29);
            btnThemMoi.TabIndex = 4;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // cbbMonHoc
            // 
            cbbMonHoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbMonHoc.FormattingEnabled = true;
            cbbMonHoc.Location = new Point(110, 45);
            cbbMonHoc.Name = "cbbMonHoc";
            cbbMonHoc.Size = new Size(250, 28);
            cbbMonHoc.TabIndex = 5;
            // 
            // dgvDiemThi
            // 
            dgvDiemThi.AllowUserToAddRows = false;
            dgvDiemThi.AllowUserToDeleteRows = false;
            dgvDiemThi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDiemThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiemThi.Location = new Point(12, 123);
            dgvDiemThi.Name = "dgvDiemThi";
            dgvDiemThi.ReadOnly = true;
            dgvDiemThi.RowHeadersWidth = 51;
            dgvDiemThi.Size = new Size(1000, 585);
            dgvDiemThi.TabIndex = 6;
            // 
            // frmDSDiemThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1024, 720);
            Controls.Add(dgvDiemThi);
            Controls.Add(cbbMonHoc);
            Controls.Add(btnThemMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTuKhoa);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDSDiemThi";
            Text = "frmDSDiemThi";
            WindowState = FormWindowState.Maximized;
            Load += frmDSDiemThi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiemThi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTuKhoa;
        private Button btnTimKiem;
        private Button btnThemMoi;
        private ComboBox cbbMonHoc;
        private DataGridView dgvDiemThi;
    }
}
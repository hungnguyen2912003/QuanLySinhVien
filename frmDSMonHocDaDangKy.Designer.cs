namespace QuanLySinhVien
{
    partial class frmDSMonHocDaDangKy
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
            dgvDSMonHocDaDK = new DataGridView();
            btnThemMoi = new Button();
            btnTimKiem = new Button();
            txtTuKhoa = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDSMonHocDaDK).BeginInit();
            SuspendLayout();
            // 
            // dgvDSMonHocDaDK
            // 
            dgvDSMonHocDaDK.AllowUserToAddRows = false;
            dgvDSMonHocDaDK.AllowUserToDeleteRows = false;
            dgvDSMonHocDaDK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSMonHocDaDK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMonHocDaDK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMonHocDaDK.Location = new Point(0, 173);
            dgvDSMonHocDaDK.MultiSelect = false;
            dgvDSMonHocDaDK.Name = "dgvDSMonHocDaDK";
            dgvDSMonHocDaDK.ReadOnly = true;
            dgvDSMonHocDaDK.RowHeadersWidth = 51;
            dgvDSMonHocDaDK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMonHocDaDK.Size = new Size(1262, 500);
            dgvDSMonHocDaDK.TabIndex = 0;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoi.Location = new Point(1130, 75);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(100, 29);
            btnThemMoi.TabIndex = 12;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(1010, 75);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 29);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTuKhoa.Location = new Point(730, 75);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(260, 27);
            txtTuKhoa.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(660, 80);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 9;
            label1.Text = "Từ khoá";
            // 
            // frmDSMonHocDaDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnThemMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            Controls.Add(dgvDSMonHocDaDK);
            Name = "frmDSMonHocDaDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách môn học đã đăng ký";
            Load += frmDSMonHocDaDangKy_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSMonHocDaDK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDSMonHocDaDK;
        private Button btnThemMoi;
        private Button btnTimKiem;
        private TextBox txtTuKhoa;
        private Label label1;
    }
}
namespace QuanLySinhVien
{
    partial class frmDSGV
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
            btnThemMoiGV = new Button();
            btnTimKiemGV = new Button();
            txtTuKhoa = new TextBox();
            label1 = new Label();
            dgvGiaoVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoVien).BeginInit();
            SuspendLayout();
            // 
            // btnThemMoiGV
            // 
            btnThemMoiGV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoiGV.Location = new Point(1140, 100);
            btnThemMoiGV.Name = "btnThemMoiGV";
            btnThemMoiGV.Size = new Size(100, 29);
            btnThemMoiGV.TabIndex = 8;
            btnThemMoiGV.Text = "Thêm mới";
            btnThemMoiGV.UseVisualStyleBackColor = true;
            btnThemMoiGV.Click += btnThemMoiGV_Click;
            // 
            // btnTimKiemGV
            // 
            btnTimKiemGV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemGV.Location = new Point(1020, 100);
            btnTimKiemGV.Name = "btnTimKiemGV";
            btnTimKiemGV.Size = new Size(100, 29);
            btnTimKiemGV.TabIndex = 7;
            btnTimKiemGV.Text = "Tìm kiếm";
            btnTimKiemGV.UseVisualStyleBackColor = true;
            btnTimKiemGV.Click += btnTimKiemGV_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTuKhoa.Location = new Point(765, 100);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(230, 27);
            txtTuKhoa.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(680, 100);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 5;
            label1.Text = "Từ khoá";
            // 
            // dgvGiaoVien
            // 
            dgvGiaoVien.AllowUserToAddRows = false;
            dgvGiaoVien.AllowUserToDeleteRows = false;
            dgvGiaoVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGiaoVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGiaoVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiaoVien.Location = new Point(0, 173);
            dgvGiaoVien.MultiSelect = false;
            dgvGiaoVien.Name = "dgvGiaoVien";
            dgvGiaoVien.ReadOnly = true;
            dgvGiaoVien.RowHeadersWidth = 51;
            dgvGiaoVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGiaoVien.Size = new Size(1262, 500);
            dgvGiaoVien.TabIndex = 9;
            dgvGiaoVien.CellDoubleClick += dgvGiaoVien_CellDoubleClick;
            // 
            // frmDSGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(dgvGiaoVien);
            Controls.Add(btnThemMoiGV);
            Controls.Add(btnTimKiemGV);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            Name = "frmDSGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách giáo viên";
            Load += frmDSGV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiaoVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThemMoiGV;
        private Button btnTimKiemGV;
        private TextBox txtTuKhoa;
        private Label label1;
        private DataGridView dgvGiaoVien;
    }
}
namespace QuanLySinhVien
{
    partial class frmDangKyMonHoc
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
            dgvDSLopHoc = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDSLopHoc).BeginInit();
            SuspendLayout();
            // 
            // dgvDSLopHoc
            // 
            dgvDSLopHoc.AllowUserToAddRows = false;
            dgvDSLopHoc.AllowUserToDeleteRows = false;
            dgvDSLopHoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLopHoc.Location = new Point(0, 173);
            dgvDSLopHoc.MultiSelect = false;
            dgvDSLopHoc.Name = "dgvDSLopHoc";
            dgvDSLopHoc.ReadOnly = true;
            dgvDSLopHoc.RowHeadersWidth = 51;
            dgvDSLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSLopHoc.Size = new Size(1006, 500);
            dgvDSLopHoc.TabIndex = 0;
            dgvDSLopHoc.CellDoubleClick += dgvDSLopHoc_CellDoubleClick;
            // 
            // frmDangKyMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 673);
            Controls.Add(dgvDSLopHoc);
            Name = "frmDangKyMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký môn học";
            Load += frmDangKyMonHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSLopHoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDSLopHoc;
    }
}
namespace QuanLySinhVien
{
    partial class frmQuanLyLop
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
            dgvQLLop = new DataGridView();
            btnTimKiem = new Button();
            txtTuKhoa = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQLLop).BeginInit();
            SuspendLayout();
            // 
            // dgvQLLop
            // 
            dgvQLLop.AllowUserToAddRows = false;
            dgvQLLop.AllowUserToDeleteRows = false;
            dgvQLLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLLop.Dock = DockStyle.Bottom;
            dgvQLLop.Location = new Point(0, 173);
            dgvQLLop.MultiSelect = false;
            dgvQLLop.Name = "dgvQLLop";
            dgvQLLop.ReadOnly = true;
            dgvQLLop.RowHeadersWidth = 51;
            dgvQLLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLLop.Size = new Size(1262, 500);
            dgvQLLop.TabIndex = 22;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(1132, 87);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 29);
            btnTimKiem.TabIndex = 20;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTuKhoa.Location = new Point(852, 87);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(260, 27);
            txtTuKhoa.TabIndex = 19;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(782, 92);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 18;
            label1.Text = "Từ khoá";
            // 
            // frmQuanLyLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(dgvQLLop);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            Name = "frmQuanLyLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lớp";
            Load += frmQuanLyLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLLop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvQLLop;
        private Button btnTimKiem;
        private TextBox txtTuKhoa;
        private Label label1;
    }
}
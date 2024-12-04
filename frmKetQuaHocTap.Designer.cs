namespace QuanLySinhVien
{
    partial class frmKetQuaHocTap
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
            btnTimKiem = new Button();
            txtTuKhoa = new TextBox();
            label1 = new Label();
            dgvKQHT = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKQHT).BeginInit();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(1121, 76);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 29);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTuKhoa.Location = new Point(841, 76);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(260, 27);
            txtTuKhoa.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(771, 81);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 13;
            label1.Text = "Từ khoá";
            // 
            // dgvKQHT
            // 
            dgvKQHT.AllowUserToAddRows = false;
            dgvKQHT.AllowUserToDeleteRows = false;
            dgvKQHT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKQHT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKQHT.Dock = DockStyle.Bottom;
            dgvKQHT.Location = new Point(0, 173);
            dgvKQHT.MultiSelect = false;
            dgvKQHT.Name = "dgvKQHT";
            dgvKQHT.ReadOnly = true;
            dgvKQHT.RowHeadersWidth = 51;
            dgvKQHT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKQHT.Size = new Size(1262, 500);
            dgvKQHT.TabIndex = 17;
            // 
            // frmKetQuaHocTap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(dgvKQHT);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            Name = "frmKetQuaHocTap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kết quả học tập";
            Load += frmKetQuaHocTap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKQHT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTimKiem;
        private TextBox txtTuKhoa;
        private Label label1;
        private DataGridView dgvKQHT;
    }
}
﻿namespace QuanLySinhVien
{
    partial class frmTTLopHoc
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
            cbbMonHoc = new ComboBox();
            cbbGiaoVien = new ComboBox();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 50);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Môn học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 100);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 1;
            label2.Text = "Giáo viên giảng dạy";
            // 
            // cbbMonHoc
            // 
            cbbMonHoc.FormattingEnabled = true;
            cbbMonHoc.Location = new Point(230, 45);
            cbbMonHoc.Name = "cbbMonHoc";
            cbbMonHoc.Size = new Size(300, 28);
            cbbMonHoc.TabIndex = 2;
            // 
            // cbbGiaoVien
            // 
            cbbGiaoVien.FormattingEnabled = true;
            cbbGiaoVien.Location = new Point(230, 95);
            cbbGiaoVien.Name = "cbbGiaoVien";
            cbbGiaoVien.Size = new Size(300, 28);
            cbbGiaoVien.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(160, 170);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 29);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(330, 170);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmTTLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 253);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(cbbGiaoVien);
            Controls.Add(cbbMonHoc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTTLopHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTTLopHoc";
            Load += frmTTLopHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbbMonHoc;
        private ComboBox cbbGiaoVien;
        private Button btnLuu;
        private Button btnHuy;
    }
}
﻿namespace QuanLySinhVien
{
    partial class frmTTGiaoVien
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
            mtbNgsinh = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTen = new TextBox();
            txtTenDem = new TextBox();
            txtHo = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtSdt = new TextBox();
            txtDiaChi = new TextBox();
            txtQueQuan = new TextBox();
            rdbNu = new RadioButton();
            rdbNam = new RadioButton();
            SuspendLayout();
            // 
            // mtbNgsinh
            // 
            mtbNgsinh.Location = new Point(200, 230);
            mtbNgsinh.Mask = "00/00/0000";
            mtbNgsinh.Name = "mtbNgsinh";
            mtbNgsinh.Size = new Size(150, 27);
            mtbNgsinh.TabIndex = 29;
            mtbNgsinh.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mtbNgsinh.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 230);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 28;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 170);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 27;
            label3.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 110);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 26;
            label2.Text = "Tên đệm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 50);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 25;
            label1.Text = "Họ";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(200, 170);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(250, 27);
            txtTen.TabIndex = 24;
            // 
            // txtTenDem
            // 
            txtTenDem.Location = new Point(200, 110);
            txtTenDem.Name = "txtTenDem";
            txtTenDem.Size = new Size(250, 27);
            txtTenDem.TabIndex = 23;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(200, 50);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(250, 27);
            txtHo.TabIndex = 22;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(300, 590);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 42;
            btnCancel.Text = "Huỷ";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(130, 590);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 41;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 530);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 40;
            label9.Text = "Số điện thoại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(80, 470);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 39;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 410);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 38;
            label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 290);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 37;
            label6.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 350);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 36;
            label5.Text = "Quê quán";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 470);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 35;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(200, 530);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(250, 27);
            txtSdt.TabIndex = 34;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(200, 410);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(250, 27);
            txtDiaChi.TabIndex = 33;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(200, 350);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(250, 27);
            txtQueQuan.TabIndex = 32;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(330, 290);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(50, 24);
            rdbNu.TabIndex = 31;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(200, 290);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(62, 24);
            rdbNam.TabIndex = 30;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // frmTTGiaoVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 653);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(txtSdt);
            Controls.Add(txtDiaChi);
            Controls.Add(txtQueQuan);
            Controls.Add(rdbNu);
            Controls.Add(rdbNam);
            Controls.Add(mtbNgsinh);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTen);
            Controls.Add(txtTenDem);
            Controls.Add(txtHo);
            Name = "frmTTGiaoVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTTGiaoVien";
            Load += frmTTGiaoVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbNgsinh;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTen;
        private TextBox txtTenDem;
        private TextBox txtHo;
        private Button btnCancel;
        private Button btnSave;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtSdt;
        private TextBox txtDiaChi;
        private TextBox txtQueQuan;
        private RadioButton rdbNu;
        private RadioButton rdbNam;
    }
}
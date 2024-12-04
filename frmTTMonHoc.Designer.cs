namespace QuanLySinhVien
{
    partial class frmTTMonHoc
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
            txtTenMH = new TextBox();
            txtSoTC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(150, 38);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(300, 27);
            txtTenMH.TabIndex = 0;
            // 
            // txtSoTC
            // 
            txtSoTC.Location = new Point(580, 38);
            txtSoTC.Name = "txtSoTC";
            txtSoTC.Size = new Size(80, 27);
            txtSoTC.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 40);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên môn học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 40);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Số tín chỉ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(720, 35);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(850, 35);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Huỷ";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmTTMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 103);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSoTC);
            Controls.Add(txtTenMH);
            Name = "frmTTMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTTMonHoc";
            Load += frmTTMonHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenMH;
        private TextBox txtSoTC;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private Button btnCancel;
    }
}
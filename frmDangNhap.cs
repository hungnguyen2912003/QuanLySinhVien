using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public string loaiTK = "";
        public string tenDangNhap = "";
        public string matKhau = "";

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            #region ktra_rangBuoc
            if (cbbLoaiTK.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }

            if (string.IsNullOrEmpty(txtTenTK.Text))
            {
                MessageBox.Show("Tên đăng nhập không được để trống");
                txtTenTK.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống");
                txtMatKhau.Select();
                return;
            }
            #endregion

            tenDangNhap = txtTenTK.Text;

            #region swtk
            switch (cbbLoaiTK.Text)
            {
                case "Quản trị viên":
                    loaiTK = "admin";
                    break;
                case "Giáo viên":
                    loaiTK = "gvien";
                    break;
                case "Sinh viên":
                    loaiTK = "svien";
                    break;
            }
            #endregion

            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    Key = "@loaiTaiKhoan",
                    Value = loaiTK
                },
                new CustomParameter()
                {
                    Key = "@tenTaiKhoan",
                    Value = txtTenTK.Text
                },
                new CustomParameter()
                {
                    Key = "@matKhau",
                    Value = txtMatKhau.Text
                }
            };

            var rs = new Database().SelectData("DangNhap", lst);

            if (rs.Rows.Count > 0)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên tài khoản hoặc mật khẩu", "Tài khoản hoặc mật khẩu không hợp lệ");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

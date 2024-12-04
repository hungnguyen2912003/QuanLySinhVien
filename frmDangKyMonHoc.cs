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
    public partial class frmDangKyMonHoc : Form
    {
        public frmDangKyMonHoc(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;
        }

        private string mssv;

        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
        }

        private void LoadDSLH()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@masinhvien",
                Value = mssv,
            });
            dgvDSLopHoc.DataSource = new Database().SelectData("DSLopChuaDangKy", lst);

            dgvDSLopHoc.Columns["MaLopHoc"].HeaderText = "Mã lớp học";
            dgvDSLopHoc.Columns["MaMonHoc"].HeaderText = "Mã môn học";
            dgvDSLopHoc.Columns["TenMonHoc"].HeaderText = "Tên môn học";
            dgvDSLopHoc.Columns["SoTinChi"].HeaderText = "Số tín chỉ";
        }

        private void dgvDSLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLopHoc.Rows[e.RowIndex].Index >= 0)
            {
                if(DialogResult.Yes == MessageBox.Show("Bạn muốn đăng ký học phần: " + dgvDSLopHoc.Rows[e.RowIndex].Cells["TenMonHoc"].Value.ToString(), "Xác nhận đăng ký", MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(new CustomParameter()
                    {
                        Key = "@masinhvien",
                        Value = mssv,
                    });
                    lst.Add(new CustomParameter()
                    {
                        Key = "@malophoc",
                        Value = dgvDSLopHoc.Rows[e.RowIndex].Cells["MaLopHoc"].Value.ToString()
                    });

                    var rs = new Database().Excute("DangKyHoc", lst);
                    if (rs == -1)
                    {
                        MessageBox.Show("Học phần này đã đăng ký", "Cảnh báo!");
                        return;
                    }
                    if (rs == 1)
                    {
                        MessageBox.Show("Đã đăng ký học phần thành công", "Thông báo");
                        LoadDSLH();
                    }
                }
            }
        }
    }
}

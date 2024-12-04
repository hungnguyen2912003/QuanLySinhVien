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
    public partial class frmDSLopHoc : Form
    {
        public frmDSLopHoc()
        {
            InitializeComponent();
        }

        private string tuKhoa = "";

        private void frmDSLopHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
        }

        private void LoadDSLH()
        {
            List<CustomParameter> lst = new List<CustomParameter>();

            tuKhoa = txtTuKhoa.Text;
            lst.Add(new CustomParameter()
            {
                Key = "@tuKhoa",
                Value = tuKhoa
            });

            dgvLopHoc.DataSource = new Database().SelectData("SelectAllLopHoc", lst);

            dgvLopHoc.Columns["MaLopHoc"].HeaderText = "Mã lớp học";
            dgvLopHoc.Columns["TenMonHoc"].HeaderText = "Tên môn học";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmTTLopHoc(null).ShowDialog();
            LoadDSLH();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSLH();
        }

        private void dgvLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mlh = dgvLopHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                new frmTTLopHoc(mlh).ShowDialog();

                LoadDSLH();
            }
        }
    }
}

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
    public partial class frmDSMH : Form
    {
        public frmDSMH()
        {
            InitializeComponent();
        }

        private string tuKhoa = "";

        private void frmDSMH_Load(object sender, EventArgs e)
        {
            LoadDSMH();
        }

        private void LoadDSMH()
        {
            List<CustomParameter> lst = new List<CustomParameter>();

            tuKhoa = txtTuKhoa.Text;
            lst.Add(new CustomParameter()
            {
                Key = "@tuKhoa",
                Value = tuKhoa
            });

            dgvMonHoc.DataSource = new Database().SelectData("SelectAllMonHoc", lst);

            dgvMonHoc.Columns["MaMonHoc"].HeaderText = "Mã môn học";
            dgvMonHoc.Columns["TenMonHoc"].HeaderText = "Tên môn học";
            dgvMonHoc.Columns["SoTinChi"].HeaderText = "Số tín chỉ";
        }

        private void dgvMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msmh = dgvMonHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                new frmTTMonHoc(msmh).ShowDialog();

                LoadDSMH();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSMH();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmTTMonHoc(null).ShowDialog();
            LoadDSMH();
        }
    }
}

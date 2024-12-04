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
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }

        private string tuKhoa = "";

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            LoadDSGV();
        }

        private void LoadDSGV()
        {
            List<CustomParameter> lst = new List<CustomParameter>();

            tuKhoa = txtTuKhoa.Text;
            lst.Add(new CustomParameter()
            {
                Key = "@tuKhoa",
                Value = tuKhoa
            });

            dgvGiaoVien.DataSource = new Database().SelectData("SelectAllGiaoVien", lst);

            dgvGiaoVien.Columns[1].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvGiaoVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGiaoVien.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvGiaoVien.Columns[4].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvGiaoVien.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGiaoVien.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvGiaoVien.Columns[5].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvGiaoVien.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGiaoVien.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvGiaoVien.Columns[7].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvGiaoVien.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGiaoVien.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgvGiaoVien.Columns["MaGiaoVien"].HeaderText = "Mã số giáo viên";
            dgvGiaoVien.Columns["HoTen"].HeaderText = "Họ tên giáo viên";
            dgvGiaoVien.Columns["QueQuan"].HeaderText = "Quê quán";
            dgvGiaoVien.Columns["DiaChi"].HeaderText = "Địa chỉ thường trú";
            dgvGiaoVien.Columns["DienThoai"].HeaderText = "Số điện thoại";
        }

        private void dgvGiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msgv = dgvGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                new frmTTGiaoVien(msgv).ShowDialog();

                LoadDSGV();
            }
        }

        private void btnTimKiemGV_Click(object sender, EventArgs e)
        {
            LoadDSGV();
        }

        private void btnThemMoiGV_Click(object sender, EventArgs e)
        {
            new frmTTGiaoVien(null).ShowDialog();
            LoadDSGV();
        }
    }
}

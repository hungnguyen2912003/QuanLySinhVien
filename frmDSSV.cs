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
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
        }

        private string tuKhoa = "";

        private void frmDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();
        }

        private void LoadDSSV()
        {
            List<CustomParameter> lst = new List<CustomParameter>();

            tuKhoa = txtTuKhoa.Text;
            lst.Add(new CustomParameter()
            {
                Key = "@tuKhoa",
                Value = tuKhoa
            });

            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", lst);

            dgvSinhVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSinhVien.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvSinhVien.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSinhVien.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvSinhVien.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSinhVien.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvSinhVien.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSinhVien.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgvSinhVien.Columns["MaSinhVien"].HeaderText = "Mã sinh viên";
            dgvSinhVien.Columns["HoTen"].HeaderText = "Họ tên sinh viên";
            dgvSinhVien.Columns["QueQuan"].HeaderText = "Quê quán";
            dgvSinhVien.Columns["DiaChi"].HeaderText = "Địa chỉ thường trú";
            dgvSinhVien.Columns["DienThoai"].HeaderText = "Số điện thoại";
        }

        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mssv = dgvSinhVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                new frmTTSinhVien(mssv).ShowDialog();

                LoadDSSV();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //Nếu thêm mới sinh viên => Mã sinh viên = null
            new frmTTSinhVien(null).ShowDialog();
            LoadDSSV();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSSV();
        }
    }
}

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
    public partial class frmDSMonHocDaDangKy : Form
    {

        private string mssv;

        public frmDSMonHocDaDangKy(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;
        }

        private void frmDSMonHocDaDangKy_Load(object sender, EventArgs e)
        {
            LoadDSMHDK();
        }

        private void LoadDSMHDK()
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    Key = "@masinhvien",
                    Value = mssv
                }
            };
            dgvDSMonHocDaDK.DataSource = new Database().SelectData("DSMonDaDky", lst);
            dgvDSMonHocDaDK.Columns[0].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvDSMonHocDaDK.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSMonHocDaDK.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgvDSMonHocDaDK.Columns[1].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvDSMonHocDaDK.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSMonHocDaDK.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgvDSMonHocDaDK.Columns[2].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvDSMonHocDaDK.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSMonHocDaDK.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgvDSMonHocDaDK.Columns[3].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvDSMonHocDaDK.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSMonHocDaDK.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgvDSMonHocDaDK.Columns[4].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvDSMonHocDaDK.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSMonHocDaDK.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgvDSMonHocDaDK.Columns[5].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvDSMonHocDaDK.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSMonHocDaDK.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgvDSMonHocDaDK.Columns[6].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvDSMonHocDaDK.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSMonHocDaDK.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgvDSMonHocDaDK.Columns[7].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvDSMonHocDaDK.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSMonHocDaDK.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dgvDSMonHocDaDK.Columns[8].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvDSMonHocDaDK.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSMonHocDaDK.Columns[8].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvDSMonHocDaDK.Columns["MaLopHoc"].HeaderText = "Mã lớp học";
            dgvDSMonHocDaDK.Columns["TenMonHoc"].HeaderText = "Tên môn học";
            dgvDSMonHocDaDK.Columns["SoTinChi"].HeaderText = "Số tín chỉ";
            dgvDSMonHocDaDK.Columns["DiemQuaTrinh"].HeaderText = "Điểm quá trình";
            dgvDSMonHocDaDK.Columns["DiemGiuaKy"].HeaderText = "Điểm giữa kỳ";
            dgvDSMonHocDaDK.Columns["DiemKetThuc"].HeaderText = "Điểm kết thúc";
            dgvDSMonHocDaDK.Columns["DiemThiLaiLan1"].HeaderText = "Điểm thi lại lần 1";
            dgvDSMonHocDaDK.Columns["DiemThiLaiLan2"].HeaderText = "Điểm thi lại lần 2";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmDangKyMonHoc(mssv).ShowDialog();
            LoadDSMHDK();
        }
    }
}

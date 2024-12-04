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
    public partial class frmTTLopHoc : Form
    {
        public frmTTLopHoc(string malh)
        {
            InitializeComponent();
            this.malh = malh;
        }

        private string malh;
        private Database db;


        private void frmTTLopHoc_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> lst = new List<CustomParameter>();

            lst.Add(new CustomParameter()
            {
                Key = "@tuKhoa",
                Value = ""
            });

            cbbMonHoc.DataSource = db.SelectData("SelectAllMonHoc", lst);
            cbbMonHoc.DisplayMember = "TenMonHoc";
            cbbMonHoc.ValueMember = "MaMonHoc";
            cbbMonHoc.SelectedIndex = -1;

            cbbGiaoVien.DataSource = db.SelectData("SelectAllGiaoVien", lst);
            cbbGiaoVien.DisplayMember = "HoTen";
            cbbGiaoVien.ValueMember = "MaGiaoVien";
            cbbGiaoVien.SelectedIndex = -1;

            if (string.IsNullOrEmpty(malh))
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật thông tin lớp học";
                var r = db.Select("XemChiTietLopHoc '" + malh + "'");
                cbbGiaoVien.SelectedValue = r["MaGiaoVien"].ToString();
                cbbMonHoc.SelectedValue = r["MaMonHoc"].ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string sql = "";

            if (cbbMonHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            if (cbbGiaoVien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên");
                return;
            }

            List<CustomParameter> lst = new List<CustomParameter>();
            if (string.IsNullOrEmpty(malh))
            {
                sql = "ThemMoiLopHoc";
            }
            else
            {
                sql = "CapNhatTTLopHoc";
                lst.Add(new CustomParameter()
                {
                    Key = "@MaLopHoc",
                    Value = malh
                });
            }

            lst.Add(new CustomParameter()
            {
                Key = "@MaMonHoc",
                Value = cbbMonHoc.SelectedValue.ToString()
            });
            lst.Add(new CustomParameter()
            {
                Key = "@MaGiaoVien",
                Value = cbbGiaoVien.SelectedValue.ToString()
            });

            var rs = db.Excute(sql, lst);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(malh))
                {
                    MessageBox.Show("Thêm mới lớp học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin lớp học thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }
    }
}

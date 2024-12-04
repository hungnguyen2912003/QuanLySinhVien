using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmTTMonHoc : Form
    {
        public frmTTMonHoc(string mamh)
        {
            InitializeComponent();
            this.mamh = mamh;
        }

        private string mamh;

        private void frmTTMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhật thông tin môn học";
                var r = new Database().Select("XemChiTietMonHoc '" + mamh + "'");

                txtTenMH.Text = r[0].ToString();
                txtSoTC.Text = r[1].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            string tenMH = txtTenMH.Text;
            string soTC = txtSoTC.Text;

            List<CustomParameter> list = new List<CustomParameter>();

            if (string.IsNullOrEmpty(mamh))
            {
                sql = "ThemMoiMonHoc";

            }
            else
            {
                sql = "CapNhatTTMonHoc";
                list.Add(new CustomParameter()
                {
                    Key = "@MaMH",
                    Value = mamh
                });
            }

            list.Add(new CustomParameter()
            {
                Key = "@TenMH",
                Value = tenMH
            });
            list.Add(new CustomParameter()
            {
                Key = "@SoTC",
                Value = soTC
            });

            var rs = new Database().Excute(sql, list);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin môn học thành công");
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

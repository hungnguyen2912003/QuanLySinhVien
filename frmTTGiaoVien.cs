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
    public partial class frmTTGiaoVien : Form
    {
        public frmTTGiaoVien(string msgv)
        {
            InitializeComponent();
            this.msgv = msgv;
        }

        private string msgv;

        private void frmTTGiaoVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msgv))
            {
                this.Text = "Thêm mới giáo viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin giáo viên";
                var r = new Database().Select("XemChiTietGiaoVien '" + msgv + "'");

                txtHo.Text = r[0].ToString();
                txtTenDem.Text = r[1].ToString();
                txtTen.Text = r[2].ToString();
                mtbNgsinh.Text = r[3].ToString();
                if (r[4].ToString() == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
                txtQueQuan.Text = r[5].ToString();
                txtDiaChi.Text = r[6].ToString();
                txtSdt.Text = r[7].ToString();
                txtEmail.Text = r[8].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            string hoGV = txtHo.Text;
            string tenDemGV = txtTenDem.Text;
            string tenGV = txtTen.Text;
            DateTime ngaySinh;
            try
            {
                ngaySinh = DateTime.ParseExact(mtbNgsinh.Text, "dd MM yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgsinh.Select();
                return;
            }

            string gioiTinh = rdbNam.Checked ? "1" : "0";
            string queQuan = txtQueQuan.Text;
            string diaChi = txtDiaChi.Text;
            string sdt = txtSdt.Text;
            string email = txtEmail.Text;

            List<CustomParameter> list = new List<CustomParameter>();

            if (string.IsNullOrEmpty(msgv))
            {
                sql = "ThemMoiGiaoVien";

            }
            else
            {
                sql = "CapNhatTTGiaoVien";
                list.Add(new CustomParameter()
                {
                    Key = "MaGiaoVien",
                    Value = msgv
                });
            }

            list.Add(new CustomParameter()
            {
                Key = "@HoGV",
                Value = hoGV
            });
            list.Add(new CustomParameter()
            {
                Key = "@TenDemGV",
                Value = tenDemGV
            });
            list.Add(new CustomParameter()
            {
                Key = "@TenGV",
                Value = tenGV
            });

            list.Add(new CustomParameter()
            {
                Key = "@NgaySinh",
                Value = ngaySinh.ToString("yyyy-MM-dd")
            });
            list.Add(new CustomParameter()
            {
                Key = "@GioiTinh",
                Value = gioiTinh
            });
            list.Add(new CustomParameter()
            {
                Key = "@QueQuan",
                Value = queQuan
            });
            list.Add(new CustomParameter()
            {
                Key = "@DiaChi",
                Value = diaChi
            });
            list.Add(new CustomParameter()
            {
                Key = "@DienThoai",
                Value = sdt
            });
            list.Add(new CustomParameter()
            {
                Key = "@Email",
                Value = email
            });

            var rs = new Database().Excute(sql, list);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(msgv))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin giáo viên thành công");
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

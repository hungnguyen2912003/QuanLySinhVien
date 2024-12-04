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
    public partial class frmTTSinhVien : Form
    {
        public frmTTSinhVien(string mssv)
        {
            this.mssv = mssv;
            InitializeComponent();
        }

        private string mssv;

        private void frmTTSinhVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mssv))
            {
                this.Text = "Thêm mới sinh viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin sinh viên";
                var r = new Database().Select("XemChiTietSinhVien '" + mssv + "'");

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
            string hoSV = txtHo.Text;
            string tenDemSV = txtTenDem.Text;
            string tenSV = txtTen.Text;
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

            if (string.IsNullOrEmpty(mssv)) 
            {
                sql = "ThemMoiSinhVien";

            }
            else
            {
                sql = "CapNhatTTSinhVien";
                list.Add(new CustomParameter()
                {
                    Key = "MaSinhVien",
                    Value = mssv
                });
            }

            list.Add(new CustomParameter()
            {
                Key = "@HoSV",
                Value = hoSV
            });
            list.Add(new CustomParameter()
            {
                Key = "@TenDemSV",
                Value = tenDemSV
            });
            list.Add(new CustomParameter()
            {
                Key = "@TenSV",
                Value = tenSV
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
            if(rs == 1)
            {
                if (string.IsNullOrEmpty(mssv))
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công");
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

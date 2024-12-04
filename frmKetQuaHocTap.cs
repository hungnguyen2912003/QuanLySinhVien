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
    public partial class frmKetQuaHocTap : Form
    {
        private string mssv;
        public frmKetQuaHocTap(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;
        }

        private void frmKetQuaHocTap_Load(object sender, EventArgs e)
        {
            LoadKQHT();
        }

        private void LoadKQHT()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@masinhvien",
                Value = mssv,
            });
            lst.Add(new CustomParameter()
            {
                Key = "@tuKhoa",
                Value = txtTuKhoa.Text,
            });
            dgvKQHT.DataSource = new Database().SelectData("TraCuuDiem", lst);
        }
    }
}

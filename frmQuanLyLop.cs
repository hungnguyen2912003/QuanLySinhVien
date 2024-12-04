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
    public partial class frmQuanLyLop : Form
    {
        private string msgv;
        public frmQuanLyLop(string msgv)
        {
            InitializeComponent();
            this.msgv = msgv;
        }

        private void frmQuanLyLop_Load(object sender, EventArgs e)
        {
            LoadQLLop();
        }

        private void LoadQLLop()
        {
            List<CustomParameter> paramList = new List<CustomParameter>();
            paramList.Add(new CustomParameter()
            {
                Key = "@magiaovien",
                Value = msgv
            });
            paramList.Add(new CustomParameter()
            {
                Key = "@tuKhoa",
                Value = txtTuKhoa.Text
            });
            dgvQLLop.DataSource = new Database().SelectData("TraCuuLop", paramList);
        }
    }
}

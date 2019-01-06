using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class wfCompany : Form
    {
        public wfCompany()
        {
            InitializeComponent();
            
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            ofdOpenFile.ShowDialog();
            string file = ofdOpenFile.FileName.Trim();
            if (string.IsNullOrEmpty(file))
            {
                return;
            }
            Image logo = Image.FromFile(file);
            ptbLogo.Image = logo;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtCompanyName.Text.Trim();

            if (CompanyDAO.Instance.validCompany(name))
            {
                CompanyDAO.Instance.addCompany(name);
                MessageBox.Show("Bạn đã thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            { 
                MessageBox.Show("Công ty đã tồn tại !! Vui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}

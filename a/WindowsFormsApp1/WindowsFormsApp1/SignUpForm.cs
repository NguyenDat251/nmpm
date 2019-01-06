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
    public partial class SignUpForm : Form
    {
       
        public SignUpForm()
        {
            InitializeComponent();
           
            txtPassword.PasswordChar = '●';
            txtConfirmPassword.PasswordChar = '●';
            loadCbxCompany();
        }
    

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string sType = cbxType.GetItemText(cbxType.SelectedItem);
            string pw = txtPassword.Text.Trim();
            string username = txtUsername.Text.Trim();
            string displayname = txtDisplayName.Text.Trim();
            string company;
            int type;
            if (pw == "" || username == "" || displayname == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AccoutDAO.Instance.validUsername(username) == false)
            {
                MessageBox.Show("Tài khoản đã tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (sType == "Người xin việc")
                {
                    type = 1;
                    company = "none";
                }
                else
                {
                    type = 2;
                    company = cbxCompany.Text.Trim();
                }
                AccoutDAO.Instance.createAccount(username, pw, type, displayname, company);
                
                MessageBox.Show("Chúc mừng !! Bạn đã đăng ký thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Clear();
            }
        }

        private void loadCbxCompany()
        {
            cbxCompany.DataSource = CompanyDAO.Instance.loadListCompany();
        }

        private void Clear()
        {
            txtUsername.Text = txtDisplayName.Text = txtPassword.Text = txtConfirmPassword.Text = "";
            cbxType.Text = null;
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedIndex.ToString() == "1")
            {
                pnlCompany.Visible = true;
            }
            else
            {
                pnlCompany.Visible = false;
            }
        }

     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            wfCompany addCompany = new wfCompany();
            addCompany.ShowDialog();
        }
    }
}

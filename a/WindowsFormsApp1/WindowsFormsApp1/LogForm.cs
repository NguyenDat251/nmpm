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
    
    public partial class LogForm : Form
    {
        string idUser;
        string type;
        string Displayname;
        
        public LogForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '●';
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DataTable dtTb = AccoutDAO.Instance.Login(txtUserName.Text, txtPassword.Text);


            if (dtTb.Rows.Count > 0)
            {
                if (dtTb != null)
                {
                    foreach (DataRow item in dtTb.Rows)
                    {
                        Displayname = (item[2].ToString());
                        idUser = (item[4].ToString());
                        type = (item[5].ToString());
                    }
                    
                    Job J = new Job(idUser, type, Displayname);

                    this.Hide();
                    J.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại\nVui lòng kiểm tra tài khoản hoặc mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
           
            SignUpForm signup = new SignUpForm();
            signup.ShowDialog();
            
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

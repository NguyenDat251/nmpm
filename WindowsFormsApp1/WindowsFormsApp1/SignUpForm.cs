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


namespace WindowsFormsApp1
{
    public partial class SignUpForm : Form
    {
        static public SqlConnection conSign;

        public SignUpForm(SqlConnection con)
        {
            InitializeComponent();
            conSign = con;
            txtPassword.PasswordChar = '●';
            txtConfirmPassword.PasswordChar = '●';
        }



        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }



        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string type = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (txtPassword.Text == "" || txtUsername.Text == "" || txtDisplayName.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (validUsername(txtUsername.Text) == false)
            {
                MessageBox.Show("Tài khoản đã tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                SqlCommand sqlCmd = new SqlCommand("AddUser", conSign);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Displayname", txtDisplayName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                if (type == "Người xin việc")
                {
                    sqlCmd.Parameters.AddWithValue("@type", 1);
                }
                else if (type == "Nhà tuyển dụng")
                {
                    sqlCmd.Parameters.AddWithValue("@type", 2);
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("@type", 3);
                }
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Chúc mừng !! Bạn đã đăng ký thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Clear();
            }
        }
        void Clear()
        {
            txtUsername.Text = txtDisplayName.Text = txtPassword.Text = txtConfirmPassword.Text = "";
            comboBox1.Text = null;
        }

        bool validUsername(string s)
        {
            SqlDataAdapter sda;
            sda = new SqlDataAdapter("SELECT COUNT(*) FROM ACCOUNT A WHERE A.Username = '" + s + "'", conSign);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].Equals(1))
            {
                return false;
            }
            return true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            conSign.Close();
            this.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            conSign.Close();
        }
    }
}

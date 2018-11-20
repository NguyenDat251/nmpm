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
    
    public partial class LogForm : Form
    {


        public string idUser;
        static public SqlConnection con = new SqlConnection("Data Source = CAOMINHTAN; Initial Catalog = JOBS; Persist Security Info=True;User ID = sa; Password=tan225593450");


        public LogForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '●';
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter("SELECT COUNT(*) FROM ACCOUNT A WHERE A.Username = '" + txtUserName.Text + "' AND A.Password = '" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].Equals(1))
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại\nVui lòng kiểm tra tài khoản hoặc mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SqlCommand sqlCmd = new SqlCommand("SELECT A.type FROM ACCOUNT A WHERE A.Username = '" + txtUserName.Text + "'", con);
            SqlDataReader dtRd = sqlCmd.ExecuteReader();
            if (dtRd.Read())
            {
                idUser = (dtRd["type"].ToString());
            }
            con.Close();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            signup.Show();
        }
    }
}

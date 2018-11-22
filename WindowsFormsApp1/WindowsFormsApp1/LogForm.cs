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
        string idUser;
        string type;
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-E1R7M37;Initial Catalog = JOBS; Integrated Security = True");
       

        public LogForm()
        {
            InitializeComponent();
            
            txtPassword.PasswordChar = '●';
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter("SELECT * FROM ACCOUNT A WHERE A.Username = '" + txtUserName.Text + "' AND A.Password = '" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            
            sda.Fill(dt);
            //if(dt.Rows[0][0].Equals(1))
            if(dt != null)
            {
                //SqlCommand sqlCmd = new SqlCommand("SELECT A.type, A.ID FROM ACCOUNT A WHERE A.Username = '" + txtUserName.Text + "'", con);
                //SqlDataReader dtRd = sqlCmd.ExecuteReader();
                // if (dtRd.Read())
                //{
                foreach (DataRow item in dt.Rows)
                {
                    idUser = (item[2].ToString());
                    type = (item[3].ToString());
                }
                //  }



               
                Job J = new Job(con, idUser);
                //con.Close
                this.Hide();
                J.ShowDialog();
                this.Close();
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
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            con.Open();
            SignUpForm signup = new SignUpForm(con);
            signup.Show();
            
        }
    }
}

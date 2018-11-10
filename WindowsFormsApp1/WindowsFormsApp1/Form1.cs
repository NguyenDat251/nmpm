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



//class ListJob
//{
//    public static List<Jobs> LJ = new List<Jobs>();
//    public static int idx;
//}

namespace WindowsFormsApp1
{
   

    public partial class Form1 : Form
    {
        struct Jobs
        {
            public int ID;
            public string Name;
            public string Company;
            public string Language;
            public int Salary;
            public string Description;
        }

        static List<Jobs> LJ = new List<Jobs>();

        int NumPage = 1;
        int AmountOfJobs = 0;

        public Form1()
        {
            InitializeComponent();

            loadJobList();
        }

        void loadJobList()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E1R7M37;Initial Catalog=JOBS;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.JOBS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string dcr;
            foreach (DataRow item in dt.Rows)
            {
                Jobs temp;
                temp.ID = int.Parse(item[0].ToString().Trim());
                temp.Name = item[1].ToString().Trim();
                temp.Company = item[2].ToString().Trim();
                temp.Language = item[3].ToString().Trim();
                temp.Salary = int.Parse(item[4].ToString().Trim());
                temp.Description = item[5].ToString().Trim();
                AmountOfJobs++;
                LJ.Add(temp);
            }

            changeListJob();
            
        }

        private void changeListJob()
        {

            lbName.Text = LJ[NumPage - 1].Name;
            lbCom.Text = LJ[NumPage - 1].Company;
            lbLang.Text = LJ[NumPage - 1].Language;
            picBox1.Image = Image.FromFile("images\\" + lbCom.Text + ".jpeg");


            lbName2.Text = LJ[NumPage].Name;
            lbCom2.Text = LJ[NumPage].Company;
            lbLang2.Text = LJ[NumPage].Language;
            picBox2.Image = Image.FromFile("images\\" + lbCom2.Text + ".jpeg");

            lbName3.Text = LJ[NumPage + 1].Name;
            lbCom3.Text = LJ[NumPage + 1].Company;
            lbLang3.Text = LJ[NumPage + 1].Language;
            picBox3.Image = Image.FromFile("images\\" + lbCom3.Text + ".jpeg");

            lbName4.Text = LJ[NumPage + 2].Name;
            lbCom4.Text = LJ[NumPage + 2].Company;
            lbLang4.Text = LJ[NumPage + 2].Language;
            picBox4.Image = Image.FromFile("images\\" + lbCom4.Text + ".jpeg");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNEXT_Click(object sender, EventArgs e)
        {
            if (NumPage + 7 <= AmountOfJobs)
            {
                NumPage += 4;
                changeListJob();
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            if (NumPage > 4)
            {
                NumPage -= 4;
                changeListJob();
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentJob f = new CurrentJob(LJ[NumPage - 1].Name, LJ[NumPage - 1].Company, LJ[NumPage - 1].Language, LJ[NumPage - 1].Salary, LJ[NumPage - 1].Description);
           
            f.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lbName2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentJob f = new CurrentJob(LJ[NumPage].Name, LJ[NumPage].Company, LJ[NumPage].Language, LJ[NumPage].Salary, LJ[NumPage - 1].Description);

            f.ShowDialog();
        }

        private void lbName3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentJob f = new CurrentJob(LJ[NumPage + 1].Name, LJ[NumPage + 1].Company, LJ[NumPage + 1].Language, LJ[NumPage + 1].Salary, LJ[NumPage - 1].Description);

            f.ShowDialog();
        }

        private void lbName4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentJob f = new CurrentJob(LJ[NumPage + 2].Name, LJ[NumPage + 2].Company, LJ[NumPage + 2].Language, LJ[NumPage + 2].Salary, LJ[NumPage - 1].Description);

            f.ShowDialog();
        }
    }
}

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
   class identify
    {
        public static int ID = 0;
        public static string type;
    }

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
        struct Aplly
        {
            public string NameCandidate;
            public string NameJob;
        }
        static List<Jobs> LJ = new List<Jobs>();
        List<Aplly> LApply = new List<Aplly>();

        int NumPage = 0;
        int NumPageApply = 0;
        int AmountOfJobs = 0;
        int AmountOfApply = 0;


        public Form1()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=34.222.44.149;Initial Catalog=JOBS;Persist Security Info=True;User ID=admin; Password = 123456");
            con.Open();
            loadJobList(con);
            loadApplyList(con);
        }

        void loadJobList(SqlConnection con)
        {
           
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.JOB", con);
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
         
        void loadLabel(int i, Label Name, Label Com, Label Lang, PictureBox picBox)
        {
            try
            {
                Name.Text = LJ[NumPage + i].Name;
                Com.Text = LJ[NumPage + i].Company;
                Lang.Text = LJ[NumPage + i].Language;
                picBox.Image = Image.FromFile("images\\" + Com.Text + ".jpeg");
            }
            catch
            {
                Name.Text = "";
                Com.Text = "";
                Lang.Text = "";
                picBox.Image = null;
            }
        }

        private void changeListJob()
        {
            loadLabel(0, lbName, lbCom, lbLang, picBox1);

            loadLabel(1, lbName2, lbCom2, lbLang2, picBox2);

            loadLabel(2, lbName3, lbCom3, lbLang3, picBox3);

            loadLabel(3, lbName4, lbCom4, lbLang4, picBox4);
        }

        void loadApplyList(SqlConnection con)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT	C.NAME, J.NAME " +
                "FROM CANDIDATE AS C, APPLY AS A, JOB AS J " +
                "WHERE C.IDCAND = A.IDCAND AND A.IDJOB = J.ID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            
            foreach (DataRow item in dt.Rows)
            {
                Aplly temp;
                temp.NameCandidate = item[0].ToString().Trim();
                temp.NameJob = item[1].ToString().Trim();

                AmountOfApply++;
                LApply.Add(temp);
            }

            changeListApply();
        }

        
        void loadLabelApply(int i, Label Candidate, Label Job, Panel pn)
        {
            try
            {
                Candidate.Text = LApply[NumPageApply + i].NameCandidate;
                Job.Text = LApply[NumPageApply + i].NameJob;
                pn.Show();
            }
            catch
            {
                pn.Hide();
            }
        }
        private void changeListApply()
        {
            loadLabelApply(0, lbCandidate1, lbJob1, pnlApply1);
            
            loadLabelApply(1, lbCandidate2, lbJob2, pnlApply2);
            
            loadLabelApply(2, lbCandidate3, lbJob3, pnlApply3);

            loadLabelApply(3, lbCandidate4, lbJob4, pnlApply4);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNEXT_Click(object sender, EventArgs e)
        {
            if (NumPage + 5 <= AmountOfJobs)
            {
                NumPage += 4;
                changeListJob();
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            if (NumPage > 3)
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
            CurrentJob f = new CurrentJob(LJ[NumPage].Name, LJ[NumPage].Company, LJ[NumPage].Language, LJ[NumPage].Salary, LJ[NumPage].Description);
           
            f.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lbName2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentJob f = new CurrentJob(LJ[NumPage + 1].Name, LJ[NumPage + 1].Company, LJ[NumPage + 1].Language, LJ[NumPage + 1].Salary, LJ[NumPage + 1].Description);

            f.ShowDialog();
        }

        private void lbName3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentJob f = new CurrentJob(LJ[NumPage + 2].Name, LJ[NumPage + 2].Company, LJ[NumPage + 2].Language, LJ[NumPage + 2].Salary, LJ[NumPage + 2].Description);

            f.ShowDialog();
        }

        private void lbName4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentJob f = new CurrentJob(LJ[NumPage + 3].Name, LJ[NumPage + 3].Company, LJ[NumPage + 3].Language, LJ[NumPage + 3].Salary, LJ[NumPage + 3].Description);

            f.ShowDialog();
        }

        private void btnNxt_Click(object sender, EventArgs e)
        {
            if (NumPageApply + 5 <= AmountOfApply)
            {
                NumPageApply += 4;
                changeListApply();
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (NumPageApply  > 3)
            {
                NumPageApply -= 4;
                changeListApply();
            }
        }
    }
}

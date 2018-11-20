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
        struct Aplly
        {
            public string NameCandidate;
            public string NameJob;
        }

        struct PanelJobs
        {
            public LinkLabel Name;
            public Label Com;
            public Label Lang;
            public PictureBox picBox;
        }

        static List<Jobs> LJ = new List<Jobs>();
        static List<Jobs> LJSearch = new List<Jobs>();
        List<Aplly> LApply = new List<Aplly>();

        int NumPage = 0;
        int NumPageApply = 0;
        int AmountOfJobs = 0;
        int AmountOfJobsSearch = 0;
        int AmountOfApply = 0;

        //static public SqlConnection con = new SqlConnection("Data Source=34.222.44.149;Initial Catalog=JOBS;Persist Security Info=True;User ID=admin; Password = 123456");

        static public SqlConnection con = new SqlConnection("Data Source = CAOMINHTAN; Initial Catalog = JOBS; Persist Security Info=True;User ID = sa; Password=tan225593450");

        public Form1()
        {
            InitializeComponent();
            con.Open();

            //PanelJobs[] listPanelJob = new PanelJobs[4];
            //listPanelJob[0].Name = lbName;
            //listPanelJob[0].Com = lbCom;
            //listPanelJob[0].Lang = lbLang;
            //listPanelJob[0].picBox = picBox1;

            //listPanelJob[1].Name = lbName2;
            //listPanelJob[1].Com = lbCom2;
            //listPanelJob[1].Lang = lbLang2;
            //listPanelJob[1].picBox = picBox2;

            //listPanelJob[2].Name = lbName3;
            //listPanelJob[2].Com = lbCom3;
            //listPanelJob[2].Lang = lbLang3;
            //listPanelJob[2].picBox = picBox3;

            //listPanelJob[3].Name = lbName4;
            //listPanelJob[3].Com = lbCom4;
            //listPanelJob[3].Lang = lbLang4;
            //listPanelJob[3].picBox = picBox4;


            loadJobList(con);
            loadApplyList(con);


        }

        void loadJobList(SqlConnection con)
        {
           
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.JOB", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

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

            changeListJob(LJ);
            
        }

        void loadLabelUpgrade(ref PanelJobs temp, ref List<Jobs> theList, int i)
        {
            try
            {
                temp.Name.Text = theList[NumPage + i].Name;
                temp.Com.Text = theList[NumPage + i].Company;
                temp.Lang.Text = theList[NumPage + i].Language;
                temp.picBox.Image = Image.FromFile("images\\" + temp.Com.Text + ".jpeg");
            }
            catch
            {
                temp.Name.Text = "";
                temp.Com.Text = "";
                temp.Lang.Text = "";
                temp.picBox.Image = null;
            }
        }


        void loadLabel(int i,ref LinkLabel Name, ref Label Com, ref Label Lang, ref PictureBox picBox, ref List<Jobs> TheList)
        {
            try
            {
                Name.Text = TheList[NumPage + i].Name;
                Com.Text = TheList[NumPage + i].Company;
                Lang.Text = TheList[NumPage + i].Language;
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

        private void changeListJob(List<Jobs> TheList)
        {
            loadLabel(0,ref lbName, ref lbCom, ref lbLang, ref picBox1, ref TheList);

            loadLabel(1, ref lbName2, ref lbCom2, ref lbLang2, ref picBox2, ref TheList);

            loadLabel(2, ref lbName3, ref lbCom3, ref lbLang3, ref picBox3, ref TheList);

            loadLabel(3, ref lbName4, ref lbCom4, ref lbLang4, ref picBox4, ref TheList);
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
                changeListJob(LJ);
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            if (NumPage > 3)
            {
                NumPage -= 4;
                changeListJob(LJ);
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            LJSearch.Clear();
          
            string title = comboBox1.GetItemText(comboBox1.SelectedItem);
            SqlDataAdapter sda;

            if (title == "Tên công việc")
            {
                sda = new SqlDataAdapter("SELECT * " + "FROM JOB AS J " + "WHERE J.NAME LIKE '%" + txtSearch.Text + "%'", con);
                sda.Fill(dt);
            }
            else if (title == "Tên công ty")
            {
                sda = new SqlDataAdapter("SELECT * " + "FROM JOB AS J " + "WHERE J.COMPANY LIKE '%" + txtSearch.Text + "%'", con);
                sda.Fill(dt);
            }
            else if(title == "")
            {
                changeListJob(LJ);
                return;
            }
           
            

            foreach (DataRow item in dt.Rows)
            {
                Jobs temp;
                temp.ID = int.Parse(item[0].ToString().Trim());
                temp.Name = item[1].ToString().Trim();
                temp.Company = item[2].ToString().Trim();
                temp.Language = item[3].ToString().Trim();
                temp.Salary = int.Parse(item[4].ToString().Trim());
                temp.Description = item[5].ToString().Trim();
                AmountOfJobsSearch++;
                LJSearch.Add(temp);
            }
            changeListJob(LJSearch);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void tcAdmin_Click(object sender, EventArgs e)
        {

        }
    }

    class identify
    {
        public static int ID = 0;
        public static string type;
    }
}

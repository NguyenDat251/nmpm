﻿using System;
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
    public partial class Job : Form
    {
        public struct Jobs
        {
            public string ID;
            public string Name;
            public string Company;
            public string Language;
            public string Salary;
            public string Description;
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

        int NumPage = 0;
        int AmountOfJobs = 0;
        int AmountOfJobsSearch = 0;
        
        private string idU, typeU, displayN;
        public Job(string idUser, string type, string Displayname)
        {
            InitializeComponent();
            //Employee EmployeeWindow = new Employee(idUser, type);
            idU = idUser.Trim();
            typeU = type.Trim();
            displayN = Displayname.Trim();
            lblNameDisplay.Text = displayN;
            //Admin AdminWindow = new Admin();
            loadJobList();
        }
        
        void loadJobList()
        {
            string quer = "SELECT * FROM dbo.JOB";
            DataTable dt = DataProvider.Instance.ExcuteQuerry(quer);
            
            foreach (DataRow item in dt.Rows)
            {
                Jobs temp;
                temp.ID = item[0].ToString().Trim();
                temp.Name = item[1].ToString().Trim();
                temp.Company = item[2].ToString().Trim();
                temp.Language = item[3].ToString().Trim();
                temp.Salary = item[4].ToString().Trim();
                temp.Description = item[5].ToString().Trim();
                AmountOfJobs++;
                LJ.Add(temp);
            }
            changeListJob(LJ);

        }

        private void changeListJob(List<Jobs> TheList)
        {
            loadLabel(0, ref lbName, ref lbCom, ref lbLang, ref picBox1, ref TheList);

            loadLabel(1, ref lbName2, ref lbCom2, ref lbLang2, ref picBox2, ref TheList);

            loadLabel(2, ref lbName3, ref lbCom3, ref lbLang3, ref picBox3, ref TheList);

            loadLabel(3, ref lbName4, ref lbCom4, ref lbLang4, ref picBox4, ref TheList);
        }

        void loadLabel(int i, ref LinkLabel Name, ref Label Com, ref Label Lang, ref PictureBox picBox, ref List<Jobs> TheList)
        {
            //try
            //{
            //    Name.Text = TheList[NumPage + i].Name;
            //    Com.Text = TheList[NumPage + i].Company;
            //    Lang.Text = TheList[NumPage + i].Language;
            //    picBox.Image = Image.FromFile("images\\" + Com.Text + ".jpeg");
            //}
            //catch
            //{
            //    Name.Text = "";
            //    Com.Text = "";
            //    Lang.Text = "";
            //    picBox.Image = null;
            //}

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


        private void lbName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentJob f = new CurrentJob(LJ[NumPage], idU, typeU);

            f.ShowDialog();
        }

        private void lbName2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentJob f = new CurrentJob(LJ[NumPage + 1], idU, typeU);
            f.ShowDialog();
        }

        private void lbName3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentJob f = new CurrentJob(LJ[NumPage + 2], idU, typeU);
            f.ShowDialog();
        }

        private void lbName4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentJob f = new CurrentJob(LJ[NumPage + 3], idU, typeU);
            f.ShowDialog();
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

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (typeU != "2")
                MessageBox.Show("Bạn không phải là người tuyển việc");
            else
            {
                Employee E = new Employee(idU, typeU);
                E.ShowDialog();
            }
        }

        private void ptbUserInfo_Click(object sender, EventArgs e)
        {
            UserInfo UI = new UserInfo();
            UI.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (typeU == "3")
            {
                Admin A = new Admin();
                A.ShowDialog();
            }
            else { MessageBox.Show("Bạn không phải là admin"); }
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string quer;
            LJSearch.Clear();

            string title = comboBox1.GetItemText(comboBox1.SelectedItem);

            if (title == "Tên công việc")
            {
                quer = "SELECT * " + "FROM JOB AS J " + "WHERE J.NAME LIKE '%" + txtSearch.Text + "%'";
                dt = DataProvider.Instance.ExcuteQuerry(quer);
            }
            else if (title == "Tên công ty")
            {
                quer = "SELECT * " + "FROM JOB AS J " + "WHERE J.COMPANY LIKE '%" + txtSearch.Text + "%'";
                dt = DataProvider.Instance.ExcuteQuerry(quer);
            }
            else if (title == "")
            {
                changeListJob(LJ);
                return;
            }
            
            foreach (DataRow item in dt.Rows)
            {
                Jobs temp;
                temp.ID = item[0].ToString().Trim();
                temp.Name = item[1].ToString().Trim();
                temp.Company = item[2].ToString().Trim();
                temp.Language = item[3].ToString().Trim();
                temp.Salary = item[4].ToString().Trim();
                temp.Description = item[5].ToString().Trim();
                AmountOfJobsSearch++;
                LJSearch.Add(temp);
            }
            
            changeListJob(LJSearch);
        }
    }
}

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
    public partial class Employee : Form
    {
        struct Aplly
        {
            public string NameCandidate;
            public string NameJob;
            public string IDCANDIDATE;
            public string IDJOB;
        }

        int NumPageApply = 0;
        int AmountOfApply = 0;
        List<Aplly> LApply = new List<Aplly>();
        SqlConnection conEmp;
        string idU, typeU;
        public Employee(SqlConnection con, string idUser, string typeUser)
        {
            InitializeComponent();
           // con.Close();
            //con.Open();
            conEmp = con;
            //con.Close();
            //conEmp.Open();
            idU = idUser;
            typeU = typeUser;
            loadApplyList();
        }

        void loadApplyList()
        {
            //conEmp.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT	AC2.Displayname, J.NAME, A.IDCAND, A.IDJOB " +
                "FROM APPLY AS A, JOB AS J, ACCOUNT AS AC,  ACCOUNT AS AC2 " +
                "WHERE A.IDJOB = J.ID AND AC.ID = " + idU + " AND J.COMPANY = AC.Company AND AC2.ID = A.IDCAND", conEmp);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            foreach (DataRow item in dt.Rows)
            {
                Aplly temp;
                temp.NameCandidate = item[0].ToString().Trim();
                temp.NameJob = item[1].ToString().Trim();
                temp.IDCANDIDATE = item[2].ToString().Trim();
                temp.IDJOB = item[3].ToString().Trim();

                AmountOfApply++;
                LApply.Add(temp);
            }

            //conEmp.Close();
            changeListApply();
        }

        private void changeListApply()
        {
            loadLabelApply(0, lbCandidate1, lbJob1, pnlApply1);

            loadLabelApply(1, lbCandidate2, lbJob2, pnlApply2);

            loadLabelApply(2, lbCandidate3, lbJob3, pnlApply3);

            loadLabelApply(3, lbCandidate4, lbJob4, pnlApply4);
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

        private void btnNxt_Click(object sender, EventArgs e)
        {
            if (NumPageApply + 5 <= AmountOfApply)
            {
                NumPageApply += 4;
                changeListApply();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM APPLY  WHERE APPLY.IDCAND = " + LApply[0].IDCANDIDATE +
            //                                        " AND APPLY.IDJOB = " + LApply[0].IDJOB, conEmp);
            SqlCommand sda = new SqlCommand("DELETE FROM APPLY  WHERE APPLY.IDCAND = " + LApply[0].IDCANDIDATE +
                                                    " AND APPLY.IDJOB = " + LApply[0].IDJOB, conEmp);
            sda.ExecuteNonQuery();
            LApply.Clear();
            loadApplyList();

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (NumPageApply > 3)
            {
                NumPageApply -= 4;
                changeListApply();
            }
        }

    }
}

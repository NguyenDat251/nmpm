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
    public partial class Admin : Form
    {

        public struct Acc
        {
            public string name;
            public string type;
        }



        List<Acc> listAcc = new List<Acc>();
        List<string> listCom = new List<string>();

        int nPage = 0;
        int nAcc = 0;

        int nPageCom = 0;
        int nCom = 0;

        public Admin()
        {
            InitializeComponent();
            loadAccList();
            loadComList();
        }

        void loadAccList()
        {
            string quer = "SELECT * FROM ACCOUNT";
            DataTable dt = DataProvider.Instance.ExcuteQuerry(quer);

            foreach (DataRow item in dt.Rows)
            {
                Acc temp;
                temp.name = item[0].ToString().Trim();
                if (item[5].ToString().Trim() == "1")
                {
                    temp.type = "Người xin việc";
                }
                else if (item[5].ToString().Trim() == "2")
                {
                    temp.type = "Người tuyển dụng";
                }
                else { temp.type = "Admin"; }

                nAcc++;
                listAcc.Add(temp);
            }
            changeListAcc(listAcc);

        }

        private void changeListAcc(List<Acc> TheList)
        {
            loadLabel(0, ref lblName0, ref lblType0, ref TheList);

            loadLabel(1, ref lblName1, ref lblType1, ref TheList);

            loadLabel(2, ref lblName2, ref lblType2, ref TheList);

            loadLabel(3, ref lblName3, ref lblType3, ref TheList);

            loadLabel(4, ref lblName4, ref lblType4, ref TheList);

            loadLabel(5, ref lblName5, ref lblType5, ref TheList);
        }

        void loadLabel(int i, ref Label name, ref Label type, ref List<Acc> TheList)
        {
            try
            {
                name.Text = TheList[nPage + i].name;
                type.Text = TheList[nPage + i].type;
            }
            catch
            {
                name.Text = "";
                type.Text = "";
            }
        }


        void loadComList()
        {
            string quer = "SELECT DISTINCT COMPANY FROM JOB";
            DataTable dt = DataProvider.Instance.ExcuteQuerry(quer);

            foreach (DataRow item in dt.Rows)
            {
                listCom.Add(item[0].ToString().Trim());
                nCom++;
            }

            changeListCom(listCom);
        }

        private void changeListCom(List<string> TheList)
        {
            loadLabelCom(0, ref lbCom0);

            loadLabelCom(1, ref lbCom1);

            loadLabelCom(2, ref lbCom2);

            loadLabelCom(3, ref lbCom3);

            loadLabelCom(4, ref lbCom4);

            loadLabelCom(5, ref lbCom5);
        }

        void loadLabelCom(int i, ref Label name)
        {
            try
            {
                name.Text = listCom[nPage + i];
            }
            catch
            {
                name.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (nPage > 5)
            {
                nPage -= 6;
                changeListAcc(listAcc);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nPage + 7 <= nAcc)
            {
                nPage += 6;
                changeListAcc(listAcc);
            }
        }
    }
}

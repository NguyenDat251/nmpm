using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DAO
{
    class CompanyDAO
    {
        private static CompanyDAO instance;

        public static CompanyDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CompanyDAO();
                return CompanyDAO.instance;
            }

            private set
            {
                CompanyDAO.instance = value;
            }

        }
        private CompanyDAO() { }

        public List<string> loadListCompany()
        {
            List<string> res = new List<string>();
            string quer = "SELECT * FROM COMPANY";

            DataTable dt = DataProvider.Instance.ExcuteQuerry(quer);
            foreach (DataRow item in dt.Rows)
            {
                string temp;
                temp = item[1].ToString().Trim();
                res.Add(temp);
            }
            return res;
        }

        public bool validCompany(string name)
        {
            string quer = "SELECT COUNT(*) FROM ACCOUNT A WHERE A.Username = '" + name + "'";
            DataTable dt = DataProvider.Instance.ExcuteQuerry(quer);
            return !(dt.Rows.Count > 0);
        }

        public void addCompany(string name)
        {
            string quer = "addCompany @name";
            DataProvider.Instance.ExcuteQuerry(quer, new object[] { name});
        }
    }
}

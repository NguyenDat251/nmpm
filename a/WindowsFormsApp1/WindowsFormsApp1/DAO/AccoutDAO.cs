using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    class AccoutDAO
    {
        private static AccoutDAO instance;

        public static AccoutDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccoutDAO();
                return AccoutDAO.instance;
            }

            private set
            {
                AccoutDAO.instance = value;
            }
        }
        private AccoutDAO() { }

        public DataTable Login(string id, string pw)
        {
            string quer = "checkLogIn @Username , @Password";
            DataTable dt = DataProvider.Instance.ExcuteQuerry(quer, new object[] { id, pw });
            return dt;
        }

        public void createAccount(string username, string pw, int type, string displayname, string company)
        {

            string quer = "AddUser @Username , @Password , @Displayname , @Company , @type";
            DataTable dt = DataProvider.Instance.ExcuteQuerry(quer, new object[] { username, pw, displayname, company, type });
        }

        public bool validUsername(string name)
        {
            string quer = "SELECT COUNT(*) FROM ACCOUNT A WHERE A.Username = '" + name + "'";
            DataTable dt = DataProvider.Instance.ExcuteQuerry(quer);

            return !(dt.Rows.Count > 1);
        }

    }
}

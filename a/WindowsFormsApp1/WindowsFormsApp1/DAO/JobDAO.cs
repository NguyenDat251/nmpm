using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    class JobDAO
    {
        private static JobDAO instance;

        public static JobDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new JobDAO();
                return JobDAO.instance;
            }

            private set
            {
                JobDAO.instance = value;
            }

        }
        private JobDAO() { }

        public void createJob(byte[] data, string id, string idJ)
        {
            string quer = "insert into APPLY " + "(PDFFile, IDCAND, IDJOB)values( @data, @id, @idJ)";
            DataProvider.Instance.ExcuteNonQuerry(quer, new object[] { data, id, idJ });
        }

        
    }
}

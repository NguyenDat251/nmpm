using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1.DAO
{


    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }

            private set
            {
                DataProvider.instance = value;
            }
        }
        private DataProvider() { }

        private string sCon = "Data Source=DESKTOP-E1R7M37;Initial Catalog = JOBS; Integrated Security = True";

        public DataTable ExcuteQuerry(string quer, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(sCon))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(quer, conn);
                if (parameter != null)
                {
                    string[] listPara = quer.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }

            return data;
        }

        public int ExcuteNonQuerry(string quer, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection conn = new SqlConnection(sCon))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(quer, conn))
                {
                    if (parameter != null)
                    {
                        string[] listPara = quer.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            return data;
        }

        public object ExcuteScalar(string quer, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection conn = new SqlConnection(sCon))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(quer, conn))
                {
                    if (parameter != null)
                    {
                        string[] listPara = quer.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            return data;
        }
    }


}
   


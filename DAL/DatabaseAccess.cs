using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseAccess
    {
        private string strConnect = "Server=GIANGPHAN; Database=QL_DaCap; User=sa; Password=20061998";
        protected SqlConnection conn = null;

        public void openConnection()
        {
            if (conn == null)
                conn = new SqlConnection(strConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

        }
        public void closeConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}

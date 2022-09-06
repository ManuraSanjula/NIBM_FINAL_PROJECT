using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIBM_FINAL_PROJECT
{

    internal class ErroController
    {
        public static void SendErrorData(String message, String stringFormat)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=NIBM;Integrated Security=True");
            try
            {
                SqlCommand sql = new SqlCommand("insert into Error values('" + message + "', '" + stringFormat + "')", sqlCon);
                sqlCon.Open();
                sql.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

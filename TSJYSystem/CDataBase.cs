using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace TSJYSystem
{
    class CDataBase
    {
        public static string connstr= "Data Source=.;Initial Catalog=TSJYSystem;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connstr);
        public static DataSet GetDataFromDB(string sqlStr, Dictionary<string, object> parameters = null)
        {
            conn.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            myAdapter.SelectCommand = new SqlCommand(sqlStr, conn);
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    myAdapter.SelectCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }
            }
            DataSet myDataSet = new DataSet();
            myDataSet.Clear();
            myAdapter.Fill(myDataSet);
            conn.Close();
            if (myDataSet.Tables[0].Rows.Count != 0)
            {
                return myDataSet;
            }
            else
            {
                return null;
            }
        }

        public static bool UpdateDB(string sqlStr, Dictionary<string, object> parameters = null)
        {
            conn.Open();
            SqlCommand myCmd = new SqlCommand(sqlStr, conn);
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    myCmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }
            }
            myCmd.CommandType = CommandType.Text;
            myCmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }

    }
}

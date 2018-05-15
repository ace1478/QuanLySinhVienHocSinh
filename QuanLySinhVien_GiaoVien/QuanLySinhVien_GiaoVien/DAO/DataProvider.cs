using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DAO
{
    class DataProvider
    {
        private string ConnectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=NGANHANGCAUHOI;Integrated Security=True";
        private static DataProvider Instanse;
        public static DataProvider instanse
        {
            get
            {
                if (Instanse == null) Instanse = new DataProvider(); return DataProvider.Instanse;
            }


            private set
            {
                DataProvider.Instanse = value;
            }
        }
        //  private DataProvider() { }

        public DataTable Executequerry(string querry)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionSTR))
            {
                connection.Open();
                SqlCommand Command = new SqlCommand(querry, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(data);
                connection.Close();
            }


            return data;
        }
        public int ExecuteNonquerry(string querry)
        {
            int data;
            using (SqlConnection connection = new SqlConnection(ConnectionSTR))
            {

                connection.Open();
                SqlCommand Command = new SqlCommand(querry, connection);
                data = Command.ExecuteNonQuery();

            }


            return data;
        }
    }
}

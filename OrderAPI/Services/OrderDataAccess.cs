using System.Data;
using System.Data.SqlClient;
using System.Text;
using OrderAPI.Models;

namespace OrderAPI.Services
{
    public class OrderDataAccess : IOrderDataAccess
    {
        public Order RetrieveOrder(Guid uid)
        {
            String queryString = "SELECT * FROM [dbo].[orders] WHERE uid = @uidValue;";
            String connectionString = "";
            String output = "";
            StringBuilder sb = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@uidValue", uid.ToString());
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        for(int i = 0; i < reader.FieldCount; i++)
                        {
                            if(reader.GetValue(i) != DBNull.Value)
                            {
                                sb.AppendFormat("{0}-", Convert.ToString(reader.GetValue(i)));
                            }
                        }
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return null;
        }

        public void CreateOrder(Order order)
        {
            String queryString = "SELECT * FROM [dbo].[orders] WHERE uid = @uidValue;";
            String connectionString = "";
            String output = "";
            StringBuilder sb = new StringBuilder();
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@uidValue", order.Id.ToString());
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader.GetValue(i) != DBNull.Value)
                            {
                                sb.AppendFormat("{0}-", Convert.ToString(reader.GetValue(i)));
                            }
                        }
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

        }

        public void DeleteOrder(Guid uid)
        {
            String queryString = "SELECT * FROM [dbo].[orders] WHERE uid = @uidValue;";
            String connectionString = "";
            String output = "";
            StringBuilder sb = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@uidValue", uid.ToString());
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader.GetValue(i) != DBNull.Value)
                            {
                                sb.AppendFormat("{0}-", Convert.ToString(reader.GetValue(i)));
                            }
                        }
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

        }

        public void UpdateOrder(Order order)
        {
            String queryString = "SELECT * FROM [dbo].[orders] WHERE uid = @uidValue;";
            String connectionString = "";
            String output = "";
            StringBuilder sb = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@uidValue", order.Id.ToString());
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader.GetValue(i) != DBNull.Value)
                            {
                                sb.AppendFormat("{0}-", Convert.ToString(reader.GetValue(i)));
                            }
                        }
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

        }

        public List<Order> RetrieveOrdersByType(OrderType orderType)
        {
            String queryString = "SELECT * FROM [dbo].[orders] WHERE uid = @uidValue;";
            String connectionString = "";
            String output = "";
            StringBuilder sb = new StringBuilder();

/*            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@uidValue", order.Id.ToString());
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader.GetValue(i) != DBNull.Value)
                            {
                                sb.AppendFormat("{0}-", Convert.ToString(reader.GetValue(i)));
                            }
                        }
                    }
                }
                finally
                {
                    reader.Close();
                }
            }*/

            return null;
        }

    }
}

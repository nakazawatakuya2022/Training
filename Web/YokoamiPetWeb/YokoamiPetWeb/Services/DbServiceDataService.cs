using Microsoft.Data.SqlClient;
using System.Data;
using YokoamiPetWeb.Models;

namespace YokoamiPetWeb.Services
{
    public class DbServiceDataService : IServiceDataService
    {
        public List<Service> GetList()
        {
            List<Service> services = new();

            using (SqlConnection connection =new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
                    SELECT
                        id,
                        name,
                        price,
                        status
                    FROM service
                    WHERE status = 1
                    ORDER BY name
                    ";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Service service = new Service(
                            reader.GetInt32("id"),
                            reader.GetString("name"),
                            reader.GetInt32("price"),
                            reader.GetBoolean("status")
                        );

                        services.Add(service);
                    }
                }
            }

            return services;
        }
    }
}
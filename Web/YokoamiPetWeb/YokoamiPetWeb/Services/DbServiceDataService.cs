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
                    ORDER BY id
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

        public Service? GetById(int id)
        {
            Service? service = null;

            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
                    SELECT
                        id,
                        name,
                        price,
                        status
                    FROM service
                    WHERE id = @Id
                    ";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        service = new Service(
                            reader.GetInt32("id"),
                            reader.GetString("name"),
                            reader.GetInt32("price"),
                            reader.GetBoolean("status")
                        );
                    }
                }
            }
            return service;
        }
        public void Register(Service service)
        {
            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
            INSERT INTO service
            (
                name,
                price,
                status
            )
            VALUES
            (
                @Name,
                @Price,
                @Status
            )
            ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@Name",
                    service.Name);

                command.Parameters.AddWithValue(
                    "@Price",
                    service.Price);

                command.Parameters.AddWithValue(
                    "@Status",
                    service.Status);

                command.ExecuteNonQuery();
            }
        }
        public void Update(Service service)
        {
            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
            UPDATE service
            SET
                name = @Name,
                price = @Price,
                status = @Status
            WHERE id = @Id
            ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@Id",
                    service.Id);

                command.Parameters.AddWithValue(
                    "@Name",
                    service.Name);

                command.Parameters.AddWithValue(
                    "@Price",
                    service.Price);

                command.Parameters.AddWithValue(
                    "@Status",
                    service.Status);

                command.ExecuteNonQuery();
            }
        }
    }
}
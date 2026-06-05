using Microsoft.Data.SqlClient;
using System.Data;
using YokoamiPetWeb.Models;

namespace YokoamiPetWeb.Services
{
    public class DbPetServices : IPetServices
    {
        public List<Pet> GetList()
        {
            List<Pet> pets = new();

            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
                    SELECT
                        p.id,
                        p.name,
                        p.owner_id,
                        o.name AS owner_name
                    FROM pet p
                    JOIN owner o
                        ON p.owner_id = o.id
                    ORDER BY p.id
                    ";

                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pet pet = new Pet(
                            reader.GetInt32("id"),
                            reader.GetString("name"),
                            reader.GetInt32("owner_id"),
                            reader.GetString("owner_name")
                        );

                        pets.Add(pet);
                    }
                }
            }
            return pets;
        }
    }
}
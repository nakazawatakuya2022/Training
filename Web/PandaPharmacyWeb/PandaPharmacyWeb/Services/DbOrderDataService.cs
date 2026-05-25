using Microsoft.Data.SqlClient;
using PandaPharmacyWeb.Models;
using System.Data;

namespace PandaPharmacyWeb.Services
{
    public class DbOrderDataService : IOrderDataService
    {
        public List<Order> GetList()
        {
            List<Order> list = new();

            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
SELECT
    order_id,
    order_date,
    customer_no,
    product_id,
    quantity
FROM
    orders;
";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                using (SqlDataReader reader =
                    command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Order order =
                            new Order(
                                reader.GetInt32("order_id"),
                                reader.GetDateTime("order_date"),
                                reader.GetString("customer_no"),
                                reader.GetInt32("product_id"),
                                reader.GetInt32("quantity")
                            );

                        list.Add(order);
                    }
                }
            }

            return list;
        }

        public void Register(Order order)
        {
            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
                INSERT INTO orders (
                    order_date,
                    customer_no,
                    product_id,
                    quantity
                )
                VALUES (
                    @OrderDate,
                    @CustomerNo,
                    @ProductId,
                    @Quantity
                );
                            ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                command.Parameters.AddWithValue("@CustomerNo", order.CustomerNo);
                command.Parameters.AddWithValue("@ProductId", order.ProductId);
                command.Parameters.AddWithValue("@Quantity", order.Quantity);

                command.ExecuteNonQuery();
            }
        }

        public Order? GetById(int id)
        {
            Order? order = null;

            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
                        SELECT
                            order_id,
                            order_date,
                            customer_no,
                            product_id,
                            quantity
                        FROM
                            orders
                        WHERE
                            order_id = @OrderId;
                        ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@OrderId", id);

                using (SqlDataReader reader =
                    command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        order = new Order(
                            reader.GetInt32("order_id"),
                            reader.GetDateTime("order_date"),
                            reader.GetString("customer_no"),
                            reader.GetInt32("product_id"),
                            reader.GetInt32("quantity")
                        );
                    }
                }
            }

            return order;
        }
    }
}
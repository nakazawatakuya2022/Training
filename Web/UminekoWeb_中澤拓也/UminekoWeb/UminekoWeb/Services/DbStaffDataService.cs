using Microsoft.Data.SqlClient;
using System.Data;
using UminekoWeb.Models;

namespace UminekoWeb.Services
{
    /// <summary>
    /// データベースから職員データを取得することでIStaffDataServiceを実装する具象クラス
    /// </summary>
    public class DbStaffDataService : IStaffDataService
    {
        // staff_idを指定して職員データを取得する
        public Staff? GetById(string staffId)
        {
            Staff? staff = null;

            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
                    SELECT
                        staff_id,
                        staff_name,
                        password,
                        role
                    FROM
                        staffs
                    WHERE
                        staff_id = @StaffId;
                    ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@StaffId", staffId);

                using (SqlDataReader reader =
                    command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // using System.Dataがあるからstaff_idで列番号がわかる
                        // ただし、列番号は0から始まるので注意
                        // GetStringもusing System.Dataがあるから列番号で指定できる
                        staff = new Staff(
                            reader.GetString("staff_id"),
                            reader.GetString("staff_name"),
                            reader.GetString("password"),
                            reader.GetByte("role")
                        );
                    }
                }
            }

            return staff;
        }
    }
}
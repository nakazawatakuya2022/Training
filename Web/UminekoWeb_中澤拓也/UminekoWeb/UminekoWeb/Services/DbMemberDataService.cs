using Microsoft.Data.SqlClient;
using System.Data;
using UminekoWeb.Models;

namespace UminekoWeb.Services
{
    public class DbMemberDataService : IMemberDataService
    {
        public List<Member> GetList()
        {
            List<Member> list = new();

            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
                    SELECT
                        member_code,
                        member_name
                    FROM
                        members
                    ORDER BY
                        member_code;
                    ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                using (SqlDataReader reader =
                    command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Member member =
                            new Member()
                            {
                                MemberCode =
                                    reader.GetString("member_code"),

                                MemberName =
                                    reader.GetString("member_name")
                            };

                        list.Add(member);
                    }
                }
            }

            return list;
        }
    }
}
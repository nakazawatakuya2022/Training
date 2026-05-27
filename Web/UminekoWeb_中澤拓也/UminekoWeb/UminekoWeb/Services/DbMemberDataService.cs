using Microsoft.Data.SqlClient;
using System.Data;
using UminekoWeb.Models;

namespace UminekoWeb.Services
{
    /// <summary>
    /// データベースから利用者データを取得するクラス
    /// </summary>
    public class DbMemberDataService : IMemberDataService
    {
        public List<Member> GetList()
        {
            // 空のリストで初期化
            //new以降省略しても書ける
            List<Member> list = new();

            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                //メンバーを取得
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
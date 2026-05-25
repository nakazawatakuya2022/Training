namespace PandaPharmacyWeb.Models
{
    public class User
    {
        public User(string userName, string password,
            string firstName, string lastName, byte role)
        {
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte Role { get; set; }

        // 管理者かどうか判定するための定数とメソッドと定義
        private const int USER_ROLE_ADMIN = 1;

        public bool IsAdmin()
        {
            return Role == USER_ROLE_ADMIN;
        }
    }
}
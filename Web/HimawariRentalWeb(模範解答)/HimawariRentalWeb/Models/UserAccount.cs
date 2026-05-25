namespace HimawariRentalWeb.Models
{
    public class UserAccount
    {
        public UserAccount() { }

        public UserAccount(string staffId, string staffName, 
            string password, byte role)
        {
            StaffId = staffId;
            StaffName = staffName;
            Password = password;
            Role = role;
        }

        public string? StaffId { get; set; }

        public string? StaffName { get; set; }

        public string? Password { get; set; }

        public byte? Role { get; set; }

        private const int USER_ROLE_ADMIN = 1;

        /// <summary>
        /// ユーザが管理者かどうか判定する
        /// </summary>
        /// <returns>true:管理者 / false:一般ユーザ</returns>
        public bool IsAdmin()
        {
            return Role == USER_ROLE_ADMIN;
        }
    }
}

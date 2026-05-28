using System.ComponentModel.DataAnnotations;

namespace UminekoWeb.Models
{
    public class Staff
    {
        public Staff() { }

        public Staff(
            string staffId,
            string staffName,
            string password,
            byte role)
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

        private const int STAFF_ROLE_ADMIN = 1;

        public bool IsAdmin()
        {
            return Role == STAFF_ROLE_ADMIN;
        }
    }
}
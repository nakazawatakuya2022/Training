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
    }
}
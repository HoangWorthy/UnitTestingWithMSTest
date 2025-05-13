namespace User
{
    public class User
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public User(string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty");
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email cannot be empty");

            Name = name;
            Email = email;
        }
    }
}

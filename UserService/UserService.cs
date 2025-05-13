using System;
using System.Collections.Generic;
using System.Linq;

namespace User.Services
{
    public class UserService
    {
        public List<User> Users { get; set; } = new List<User>();

        public void AddUser(string name, string email)
        {
            foreach (User user in Users)
            {
                if (string.Equals(user.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    throw new InvalidOperationException("User already exists");
                }
            }

            Users.Add(new User(name, email));
        }

        public User? FindUserByName(string name)
        {
            foreach (User user in Users)
            {
                if (string.Equals(user.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    return user;
                }
            }

            return null;
        }
    }
}

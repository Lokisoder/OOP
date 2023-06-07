using System.Collections.Generic;
using System.Linq;
using BookRecipe.Models;

namespace BookRecipe.Services
{
    public class UserService
    {
        private List<User> users;

        public UserService()
        {
            users = new List<User>();
        }

        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public bool AuthenticateUser(string username, string password)
        {
            return users.Any(u => u.Username == username && u.Password == password);
        }
    }
}






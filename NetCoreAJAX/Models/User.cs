using System.Collections.Generic;
using System.Linq;

namespace NetCoreAJAX.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public static class UserDb
    {
        private static List<User> Users = new List<User>()
        {
            new User{Id=1,Name="Atiba"},
            new User{Id=2,Name="Oğuzhan"},
            new User{Id=3,Name="Mensah"},
            new User{Id=4,Name="Ljajic"},
            new User{Id=5,Name="Dorukhan"},
            new User{Id=6,Name="Necip"}
        };

        public static List<User> List()
        {
            return Users;
        }

        public static User GetUser(int id)
        {
            return Users.FirstOrDefault(p => p.Id == id);
        }

        public static void AddUser(User user)
        {
            Users.Add(user);
        }
    }
}

using Aztrowebaplication.Models;

namespace Aztrowebaplication.Services
{
    public class UserServices
    {
        public List<User> GetAllUsers()
        {
            var user1 = new User{Name = "User1", Email = "", Age = 10};
            var user2 = new User{Name = "User2", Email = "", Age = 11};

            var respondDataBase = new List<User>{user1, user2};

            return respondDataBase;
        }
        public User GetUserById(int id)
        {
            var user1 = new User{Name = "User1", Email = "", Age = 10};

            if(id != 1)
            {
                return null;
            }
            return user1;
        }
        public User CreateUser()
        {
            return new User();
        }
        
        public User UpdateUserById(int id)
        {
            return new User();
        }

        public User DeleteUserById(int id)
        {
            return new User();
        }
    }
}
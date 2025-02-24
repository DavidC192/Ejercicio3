using Aztrowebaplication.Data;
using Aztrowebaplication.Models;
using Aztrowebaplication.Repositories;

namespace Aztrowebaplication.Services
{
    public class UserServices
    {
        private readonly UserRepository userRepository;

        public UserServices(ApplicationDbContext context)
        {
            userRepository = new UserRepository(context);
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await userRepository.GetAllUsers();
            return users.ToList();
        }
        public User? GetUserById(int id)
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
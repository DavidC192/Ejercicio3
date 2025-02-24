using Aztrowebaplication.Models;
using Aztrowebaplication.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aztrowebaplication.Data
{
    public class UserRepository 
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<User?> GetUserById(int id)
        {
            return await _context.User.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> CreateUser(User user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUserById(int id, User user)
        {
            var userToUpdate = _context.User.FirstOrDefault(x => x.Id == id);
            if (userToUpdate == null)
            {
                return null;
            }

            userToUpdate.Name = user.Name;
            userToUpdate.Email = user.Email;
            userToUpdate.Age = user.Age;

            await _context.SaveChangesAsync();
            return userToUpdate;
        }

        public async Task<User> DeleteUserById(int id)
        {
            var userToDelete = _context.User.FirstOrDefault(x => x.Id == id);
            if (userToDelete == null)
            {
                return null;
            }

            _context.User.Remove(userToDelete);
            await _context.SaveChangesAsync();
            return userToDelete;
        }
    }
}
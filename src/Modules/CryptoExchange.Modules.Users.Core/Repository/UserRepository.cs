using CryptoExchange.Modules.Users.Core.DAL;
using CryptoExchange.Modules.Users.Core.DTO;
using CryptoExchange.Modules.Users.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _dbContext;

        public UserRepository(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUserById(string id) => await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        public async Task<IReadOnlyList<User>> GetAllUsers() => await _dbContext.Users.ToListAsync();
       


        public async Task DeleteAsync(User user)
        {
            _dbContext.Remove(user);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(User user)
        {
            _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}

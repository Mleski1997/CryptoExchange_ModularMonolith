using CryptoExchange.Modules.Users.Core.DAL;
using CryptoExchange.Modules.Users.Core.DTO;
using CryptoExchange.Modules.Users.Core.Entities;
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

        public UserRepository(UserDbContext  dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<User> GetAsync(Guid id) => _dbContext.
      

        public Task<User> GetAsync(string email)
        {
            throw new NotImplementedException();
        }
        public Task<User> AddAsync(RegisterDto registerDto)
        {
            throw new NotImplementedException();
        }


        public Task<User> UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}

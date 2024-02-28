using CryptoExchange.Modules.Users.Core.DTO;
using CryptoExchange.Modules.Users.Core.Entities;
using CryptoExchange.Modules.Users.Core.Exceptions;
using CryptoExchange.Modules.Users.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<User> GetUserById(string id)
        {
            var result =  _userRepository.GetUserById(id);
            if (result == null)
            {
                throw new UserDoesntExistsExceptions(id);
            }
            return result;

        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            var entities = await _userRepository.GetAllUsers();
            return entities.Select(x => new User
            {
                Id = x.Id,
                UserName = x.UserName,
                Email = x.Email,

            });

        }

        

        public Task DeleteAsync(User user) => _userRepository.DeleteAsync(user);





        public async Task UpdateAsync(UpdateUserDto updateUserDto)
        {
           

         
        }
    }
}

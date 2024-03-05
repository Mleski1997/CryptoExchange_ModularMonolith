using CryptoExchange.Modules.Users.Core.DTO;
using CryptoExchange.Modules.Users.Core.Entities;
using CryptoExchange.Modules.Users.Core.Exceptions;
using CryptoExchange.Modules.Users.Core.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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

        public async Task DeleteUser(string id)
        {
            var user = await _userRepository.GetById(id);
            if (user is null)
            {
                throw new UserIdDoesntExistsExceptions(id);
            }
            await _userRepository.Delete(user);
        }

        public async Task<IReadOnlyList<UserDto>> GetAllUsers()
        {
            var users = await _userRepository.GetAllUsers();
            var userDtos = users.Select(user => new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
            }).ToList();
            return userDtos;
        }

        public async Task<UserDto> GetById(string id)
        {
            var user = await _userRepository.GetById(id);
            if (user == null)
            {
                throw new UserIdDoesntExistsExceptions(id);
            }

            var userDto = new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
            };
            return userDto;





        }

        public async Task UpdateUser(UpdateUserDto dto)
        {
            var user = await _userRepository.GetById(dto.id);
            if (user is null)
            {
                throw new UserIdDoesntExistsExceptions(dto.id);
            }

            user.UserName = dto.UserName;
            user.Email = dto.Email;
            user.IsActive = dto.IsActive;

            await _userRepository.Update(user);
        }
    }
}
using CryptoExchange.Modules.Users.Core.DTO;
using CryptoExchange.Modules.Users.Core.Entities;
using CryptoExchange.Modules.Users.Core.Exceptions;
using CryptoExchange.Modules.Users.Core.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CryptoExchange.Modules.Users.Core.Services
{
    public class IdentityService : IIdentityService
    {
        
        private readonly ITokenService _tokenService;
        private readonly IIdentityRepository _identityRepository;
     


        public IdentityService(ITokenService tokenService, IIdentityRepository identityRepository)
        {
            _identityRepository = identityRepository;
            _tokenService = tokenService;
           

        }
        public async Task SignUpAsync(SignUpDto signUpDto)
        {
            var existEmail = await _identityRepository.FindByEmailAsync(signUpDto.Email);
            if (existEmail != null)
            {
                throw new EmailAlreadyExistsExcpetion(signUpDto.Email);
            }

            var existUserName = await _identityRepository.FindByNameAsync(signUpDto.UserName);
            if (existUserName != null)
            {
                throw new UserNameAlreadyExistsException(signUpDto.UserName);
            }

            var User = new User()
            {
                Email = signUpDto.Email,
                UserName = signUpDto.UserName

            };
            await _identityRepository.CreateAsync(User, signUpDto.Password);
            await _identityRepository.AddRoleAsync(User);

        }
        public async Task<String> SignInAsync(SignInDto signInDto)
        {

            var user = await _identityRepository.FindByNameAsync(signInDto.UserName);
            if (user is null)
            {
                throw new UserDoesntExistsExceptions(signInDto.UserName);
            }

            if (!user.IsActive)
            {
                throw new UserIsNotActiveExcepetion(user.Id);
            }

            var result = await _identityRepository.CheckPasswordAsync(user, signInDto.Password);

            if (!result)
            {
                throw new WrongPasswordException();
            }


            return _tokenService.CreateToken(user);
        }



    }
}
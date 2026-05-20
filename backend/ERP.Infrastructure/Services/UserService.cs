using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Application.Interfaces;
using ERP.Domain.Entities;

namespace ERP.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task RegisterUser(string email, string password, string fullName)
        {
            var user = new User
            {
                Email = email,
                PasswordHash = password,
                FullName = fullName,
                Role = "Employee"
            };

            await _userRepository.AddAsync(user);
        }
    }
}

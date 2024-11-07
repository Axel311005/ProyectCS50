using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Nomina
{
    public interface IUserRepository
    {
        Task<string> AuthenticateUserAsync(string username, string password);
        Task<string> Register(string username, string firstName,
            string lastName, string password, string Email);
    }
}

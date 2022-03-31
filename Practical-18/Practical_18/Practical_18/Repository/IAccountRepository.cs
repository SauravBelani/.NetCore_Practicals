using Microsoft.AspNetCore.Identity;
using Practical_18.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_18.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(Login login);
        Task<string> LoginAsync(SignIn signIn);
    }
}

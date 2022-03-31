using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practical_18.Models;
using Practical_18.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_18.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody]Login login)
        {
            var result = await accountRepository.SignUpAsync(login);
            if(result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized();
        }
        
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]SignIn signIn)
        {
            var result = await accountRepository.LoginAsync(signIn);
            if(string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);
        }
    }
}

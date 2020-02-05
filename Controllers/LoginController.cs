using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_core_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_api.Controllers
{
    [Route("api/login")]
    public class LoginController : Controller
    {

        [HttpPost("")]
        public IActionResult Login(User user)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(user.email))
                    return BadRequest(Result.CreateResult(true, "Email não pode ser vazio"));
                if (string.IsNullOrWhiteSpace(user.password))
                    return BadRequest(Result.CreateResult(true, "Senha não pode ser vazio"));
                Result result = Result.GetInstance;



                LoginBusiness loginBusiness = new LoginBusiness();
                result = loginBusiness.ValidateLogin(user.email, user.password);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(Result.CreateResult(true, "Houve um problema ao realizar o login."));
            }

        }
        [HttpPost("register")]
        public IActionResult Register(User user)
        {

            return Ok("");
        }
        [HttpPost("resetpassword")]
        public IActionResult ResetPassword(User user)
        {

            return Ok("");
        }

    }
}
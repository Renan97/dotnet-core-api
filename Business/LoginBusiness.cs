using System;
using dotnet_core_api.Models;

namespace dotnet_core_api
{
    public class LoginBusiness
    {
        public Result ValidateLogin(string email, string password)
        {
            try
            {
                Result result = Result.GetInstance;

                //some code
                return Result.CreateResult(false, "Login efetuado com sucesso!", null);

            }
            catch (Exception ex)
            {
                return Result.CreateResult(true, ex.Message);
            }

        }
    }
}
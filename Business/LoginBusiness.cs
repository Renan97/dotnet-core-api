using System;
using System.Data;
using dotnet_core_api.Models;
using dotnet_core_api.Utils;

namespace dotnet_core_api
{
    public class LoginBusiness
    {
        public Result ValidateLogin(string email, string password)
        {
            try
            {
                Result result = Result.GetInstance;
                PostgreConnection postgre = new PostgreConnection();
                var sql = $"Select * from users where email = '{email}' ";
                DataSet dataResult = postgre.ExecuteQuery(sql);
                if (dataResult.Tables.Count == 0)
                    return Result.CreateResult(true, "Email não encontrado.");
                var row = dataResult.Tables[0].Rows[0];
                var user = new User();
                user.idUser = ConvertDatasetToClass.validateValue(row, "idUser", 0);
                user.nameUser = ConvertDatasetToClass.validateValue(row, "nameUser", "");
                user.email = ConvertDatasetToClass.validateValue(row, "email", "");
                user.password = ConvertDatasetToClass.validateValue(row, "password", "");

                if (user.password != password)
                    return Result.CreateResult(true, "Senha incorreta");







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
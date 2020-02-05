namespace dotnet_core_api.Models
{
    public sealed class Result
    {
        private static Result result;
        public bool hasError { get; set; }
        public string message { get; set; }
        public dynamic objectResult { get; set; }

        private Result()
        {

        }

        public static Result GetInstance
        {
            get
            {
                if (result == null)
                    result = new Result();
                return result;
            }
        }
        public static Result CreateResult(bool hasError, string message, dynamic objectResult = null)
        {
            result.hasError = hasError;
            result.message = message;
            result.objectResult = objectResult;

            return result;
        }

    }
}
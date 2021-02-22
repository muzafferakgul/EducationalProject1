namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //get readonly dir. Ctor da set edilebilir.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool succes)
        {
            Success = succes;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}

namespace Core.Utilities.Results
{
    //Temel void ler icin
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}

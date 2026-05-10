namespace AeroMexic.Domain.Share
{
    public class Result
    {
        public bool IsSuccess { get; set; }
        public string? Error { get; set; } = string.Empty;

        public static Result Success => new Result { IsSuccess = true };
        public static Result Failure(string errorMessage) => new Result { IsSuccess = false, Error = errorMessage };
    }
}

namespace DISCPrinting.Domain.ValueObjects;

public class CustomResult
{
    public bool IsOk { get; set; }
    public string Message { get; set; } = string.Empty;
    public CustomResult()
    {
        IsOk = true;
    }
    public CustomResult(string message)
    {
        IsOk = false;
        Message = message;
    }
    public CustomResult(bool isOk, string message)
    {
        IsOk = isOk;
        Message = message;
    }
}

public class CustomResult<T> : CustomResult
{
    public T? Value { get; set; }

    public CustomResult(T value) : base()
    {
        Value = value;
    }

}

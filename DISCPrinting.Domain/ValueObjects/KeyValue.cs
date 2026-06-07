namespace DISCPrinting.Domain.ValueObjects;

public class KeyValue<T>
{
    public string Key { get; set; } = string.Empty;
    public T Value { get; set; }
    public KeyValue()
    {
        
    }
    public KeyValue(string key, T value)
    {
        Key = key;
        Value = value;
    }
}

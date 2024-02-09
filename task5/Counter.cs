namespace task5;

public class Counter
{
    public int Value { get; set; }  
    public Counter(int value)
    {
        Value = value;        
    }
    public void Plus()
    {
        Value++;
    }
    public void Decrement()
    {
        Value--;
    }
    public void Reset()
    {
        Value = 0;
    }
    public override string ToString()
    {
        return $"Int: {Value}";
    }
}

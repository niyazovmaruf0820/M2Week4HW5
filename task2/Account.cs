namespace task2;

public class Account
{
    public double Balance { get; set; }
    public Account(){}
    public Account(double balance)
    {
        Balance = balance;
    }
    public void InputDepozit(double dep)
    {
        Balance += dep;
    }
    public void OutputDepozit(double dep)
    {
        Balance -= dep;
    }
    public double GetBalance()
    {
        System.Console.Write("Balance: ");
        return Balance;
    }
    public override string ToString()
    {
        return $"Balance: {Balance}";
    }
}

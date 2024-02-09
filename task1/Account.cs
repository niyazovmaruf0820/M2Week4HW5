namespace task1;

public class Account
{
    public int Balance { get; set; }
    public Account(){}
    public Account(int balance)
    {
        Balance = balance;
    }
    public void InputDepozit(int dep)
    {
        Balance += dep;
    }
    public int GetBalance()
    {
        System.Console.Write("Balance: ");
        return Balance;
    }
}

//Bank account!

var account = new Account();
account.Deposit(100);
Console.WriteLine(account.Balance);
account.Withdraw(50);
Console.WriteLine(account.Balance);

class Account
{
    public int Balance { get; set; }

    public void Deposit(int value)
    {
        Balance += value;
    }

    public void Withdraw(int value)
    {
        Balance -= value;
    }
}
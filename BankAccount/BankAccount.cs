public class BankAccount
{
    private string AccountHolder { get; set; }
    private decimal Balance { get; set; }

    public DateTime AccountStarted { get; set; }

    public BankAccount(string name, decimal initialBalance)
    {
        AccountHolder = name;
        Balance = initialBalance;
    }
    public void Deposit(decimal amount)
    {
        
    }
    public void Withdraw(decimal amount)
    {
        
    }

    public decimal GetBalance()
    {

    }
    
    public string GetAccountInfo()
    {
        
    }
}
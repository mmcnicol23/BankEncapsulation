namespace BankEncapsulation;

public class BankAccount
{
    // In your BankAccount class, create the following:
    // A private field of type double named balance with a value of 0
    private double _balance = 0; 
    
    // Define a method named Deposit that will accept a double and store that value in the balance field
    public void Deposit()
    {
        Console.WriteLine("You have selected to deposit money. How much money would you like to deposit?");
        double depositAmount = double.Parse(Console.ReadLine());
        var newBalance = _balance += depositAmount;
        Console.WriteLine($"Thanks for depositing that ${depositAmount}. Your new balance is ${newBalance}.");
    }
    
    // Define a method named GetBalance that will return the amount stored in the balance field
    public void GetBalance()
    {
        Console.WriteLine($"Your balance is currently {_balance}");
    }
    
}
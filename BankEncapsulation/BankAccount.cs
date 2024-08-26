namespace BankEncapsulation;

public class BankAccount
{
    // In your BankAccount class, create the following:
    // A private field of type double named balance with a value of 0
    private int _balance = 0; 
    
    // Define a method named Deposit that will accept a double and store that value in the balance field
    // public void Deposit()
    // {
    //     Console.WriteLine("You have selected to deposit money. How much money would you like to deposit?");
    //     double depositAmount = double.Parse(Console.ReadLine());
    //     var newBalance = _balance += depositAmount;
    //     Console.WriteLine($"Thanks for depositing that ${depositAmount}. Your new balance is ${newBalance}.");
    // }
    
    public void Deposit()
    {
        Console.WriteLine("You have selected to deposit money. How much money would you like to deposit?"); 
        string? depositAmount = Console.ReadLine();
        
            if (depositAmount == "42")
            {
                string hitchhiker = depositAmount;
                int parsedhitchhiker = int.Parse(hitchhiker);
                var newBalance = _balance += parsedhitchhiker;
                Console.WriteLine($"Don't forget your towel!. \n Your new balance is ${newBalance}.");
            }
            else if (depositAmount == "69")
            {
                string sexNumber = depositAmount;
                int parsedsexnumber = int.Parse(sexNumber);
                var newBalance = _balance += parsedsexnumber;
                Console.WriteLine($"LOL! Nice. The sex number. \n Your new balance is ${newBalance}.");
            }
            else if (depositAmount == "420")
            {
                string highTimes = depositAmount;
                int parsedhightimes = int.Parse(highTimes);
                var newBalance = _balance += parsedhightimes;
                Console.WriteLine($"Smoke 'em if you got 'em. \n Your new balance is ${newBalance}.");
            }
            else if (depositAmount == "350")
            {
                string lochNess = depositAmount;
                int parsedLochNess = int.Parse(lochNess);
                var newBalance = _balance += parsedLochNess;
                Console.WriteLine($"I ain't givin' you no tree-fitty, you goddamn Loch Ness Monster! Get your own goddamn money! \n Your new balance is ${newBalance}.");
            }
            else
            {
                int parseddeposit = int.Parse(depositAmount);
                var newBalance = _balance += parseddeposit;
                Console.WriteLine($"Thanks for depositing that ${depositAmount}. Your new balance is ${newBalance}.");   
            }
    }
    // Define a method named GetBalance that will return the amount stored in the balance field
    public void GetBalance()
    {
        Console.WriteLine($"Your balance is currently ${_balance}");
    }
    
}
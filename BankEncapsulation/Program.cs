using System.IO.Pipes;
using BankEncapsulation;

        var account = new BankAccount();

        //var currentBalance = account.GetBalance();

        BankAccount myAccount = new BankAccount();

        while (true)
        {

            Console.WriteLine("Welcome to Text2Bank!");
            Console.WriteLine("Enter 1 to check your balance, or 2 to deposit money.");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                myAccount.GetBalance();
            }
            else if (userInput == "2")
            {
                myAccount.Deposit();
            }
            else
            {
                Console.WriteLine("Invalid entry. Restart program to try again.");
            }
        }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Makes balance a variable and makes the initial balance 1000
            double balance = 1000; 
            bool exit = false;

            // Makes the optios a list for the user to input what they want to do
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the ATM"); // promps user they are in the atm screen
                Console.WriteLine("1. Check Balance");  // users can check balance
                Console.WriteLine("2. Deposit");  // users can deposit money in the balance
                Console.WriteLine("3. Withdraw"); // user can withdraw money out of the balance
                Console.WriteLine("4. Exit"); // exit out of the atm
                Console.Write("Choose an option (1-4): "); // prompts user to choose one of the 4 options available

                // reads the option line to the user
                string choice = Console.ReadLine();
                 // starts the switch for the different outcomes of what the user selects
                switch (choice)
                {
                    case "1": // prompts as 1.
                        Console.WriteLine($"Your current balance is ${balance}"); // case 1: shows the user what their current balance is in their account
                        break;

                    case "2": // prompts as 2.
                        Console.Write("Enter deposit amount: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine()); // makes depositamount a numeric value the user can use to add money
                        balance += depositAmount; // adds the amount to the users balance
                        Console.WriteLine($"You deposited ${depositAmount}. New balance is ${balance}."); //prompts user the amount they added and the new balance
                        break;

                    case "3": // prompts as 3.
                        Console.Write("Enter withdrawal amount: "); // prompts user how much money they want to withdraw from balance
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine()); // makes withdrawamount a numeric value the user can use to take out money from balance
                        if (withdrawAmount <= balance) // Line says if the withdrawamount is less than or equal to the balance it will proceed with taking the money out
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine($"You withdrew ${withdrawAmount}. New balance is ${balance}."); // prompts user they withdrew their amount they selected and shows new balance
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds."); // if withdraw amount is greater than balance it will write insufficient funds
                        }
                        break;

                    case "4": // prompts as 4.
                        Console.WriteLine("Goodbye!"); // prompts user goodbye if they select case 4
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 4."); //prompts user if they hit an invalid key
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("Press any key to continue..."); // prompts user to continue if they would like to
                    Console.ReadKey();
                }
            }
        }
    }
}



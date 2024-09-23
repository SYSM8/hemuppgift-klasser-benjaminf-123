using BenneProgrammering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BenneProgrammering
{
    public class BankAccount
    {
        public string AccountNumber;
        public string AccountName;
        public decimal Balance;

        public BankAccount(string accountNumber, string accountName, decimal InitialBalance)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            Balance = InitialBalance;
        }
        public void Deposit(decimal Amount)
        {

            if (Amount > 0)
            {
                Balance += Amount;
                Console.WriteLine($"Deposit registered! Deposited {Amount:C}");
            }
            else
            {
                Console.WriteLine("Insättningen måste vara större än noll!");
            }

        }

        public void Withdraw(decimal Amount)
        {

            if (Amount > 0 && Balance >= Amount)
            {
                Balance -= Amount;

                Console.WriteLine($"Uttaget på {Amount:C} är lyckad!");
            }
            else if (Amount > 0 && Balance < Amount)
            {
                Console.WriteLine("Uttag inte utfört, otillräckligt saldo!");
            }
            else if (Amount < 0)
            {
                Console.WriteLine("Uttaget måste vara större än 0!");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Saldot på kontot är {Balance:C}");
        }




    }

}


//BankAccount BA = new BankAccount("2938293820", "Benne", 2000m);

//BA.DisplayBalance();

//BA.Deposit(8000m);

//BA.Withdraw(3000m);

//BA.DisplayBalance();


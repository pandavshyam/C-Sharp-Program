using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    /*
    Create an Account Class with the following members: 

    Data :-accountNo, customerName, balance,  

    Methods :- Deposit(), Withdraw(), CalculateInterest() 

    Constructors :- Default, Parameterized 

 

    Create an array of Account object. Accept information about the accounts from the user. Display all the account Details.    
     */
    interface IDisplay
    {
        void Show();
    }

    class Account : IDisplay
    {
        public long AccountNo { get; set; }
        public string CustomerName { get; set; }
        public float Balance { get; set; }

        public override string ToString()
        {
            return String.Format("AccountNo: {0}\nCustomerName: {1}\nBalance: {2}\n\n", AccountNo, CustomerName, Balance);
        }

        public Account()
        {

        }
        public Account(long accountNo, string customerName, float balance)
        {
            AccountNo = accountNo;
            CustomerName = customerName;
            Balance = balance;
        }
        public Account(string customerName, float balance)
        {
            Random rn = new Random();
            int first = rn.Next(1, 100);
            int second = rn.Next(1, 100);
            AccountNo = long.Parse(first + "" + second);
            CustomerName = customerName;
            Balance = balance;
        }

        public virtual long CalculateInterest()
        {
            return 0;
        }

        public void Show()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Problem3
    {
        static void Main(string[] args)
        {

            Account[] accounts = new Account[1];
            int n = accounts.Length;
            int x = 0;
            while (n > 0)
            {

                Console.WriteLine("Enter Account Type: \n1.Salary\n2.FixedDeposit\n3.Recurring\n4.Savings\n");
                int type = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Account Holder Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Account Balance:");
                float Balance = float.Parse(Console.ReadLine());
                Account acc;
                switch (type)
                {
                    case 1:
                        acc = new Salary(Name, Balance);
                        break;
                    case 2:
                        acc = new FixedDeposit(Name, Balance);
                        break;
                    case 3:
                        acc = new Reccuring(Name, Balance);
                        break;
                    case 4:
                        acc = new Savings(Name, Balance);
                        break;
                    default:
                        acc = new Account(Name, Balance);
                        break;

                }
                accounts[x++] = acc;
                n--;
            }

            foreach (var account in accounts)
            {
                account.Show();
                Console.WriteLine(account.CalculateInterest());
            }
        }

    }
}

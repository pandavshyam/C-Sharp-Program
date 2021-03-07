using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    class Savings : Account
    {
        public static float Interest = 7.50f;
        public Savings(string name, float balance)
            : base(name, balance) { }
        public Savings()
            : base() { }

        public override long CalculateInterest()
        {
            return (long)(this.Balance * Interest * 1 / 100);
        }
    }

    class Salary : Account
    {
        public static float Interest = 6.00f;
        public Salary(string name, float balance)
            : base(name, balance) { }
        public Salary()
            : base() { }

        public override long CalculateInterest()
        {
            return (long)(this.Balance * Interest * 1 / 100);
        }
    }
    class Reccuring : Account
    {
        public static float Interest = 9.4f;
        public Reccuring(string name, float balance)
            : base(name, balance) { }
        public Reccuring()
            : base() { }

        public override long CalculateInterest()
        {
            return (long)(this.Balance * Interest * 1 / 100);
        }
    }

    class FixedDeposit : Account
    {
        public static float Interest = 8.30f;
        public FixedDeposit(string name, float balance)
            : base(name, balance) { }
        public FixedDeposit()
            : base() { }

        public override long CalculateInterest()
        {
            return (long)(this.Balance * Interest * 1 / 100);
        }
    }

    class Problem4
    {
        static void Main(string[] args)
        {

        }
    }
}

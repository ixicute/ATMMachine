using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    //En del av Strategy Pattern när användaren vill se sitt saldo.
    internal class BalanceInquiry : IOperation
    {
        public void Execute(User user)
        {
            Console.WriteLine($"Ditt saldo är: {user.Balance}kr");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    //En del av Strategy Pattern när användaren vill ta ut pengar.
    internal class Withdraw : IOperation
    {
        public void Execute(User user)
        {
            Console.WriteLine("Hur mycket pengar vill du ta ut:");
            var amount = decimal.Parse(Console.ReadLine());
            if (user.Balance >= amount)
            {
                user.Balance -= amount;
                Console.WriteLine($"Uttagssumman ${amount}. Nya balansen: ${user.Balance}");
            }
            else
            {
                Console.WriteLine("Du har inte tillräckligt med pengar.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    //En del av Strategy Pattern när användaren vill sätta in pengar.
    internal class Deposit : IOperation
    {
        public void Execute(User user)
        {
            Console.WriteLine("Hur mycket pengar vill du sätta in:");

            string input = Console.ReadLine();
            // Replace any periods with commas
            input = input.Replace('.', ',');

            if (decimal.TryParse(input, out var amount))
            {
                user.Balance += amount;
                Console.Clear();
                Console.WriteLine($"Insatt {amount} kr. Nytt saldo: {user.Balance} kr");
            }
            else
            {
                Console.WriteLine("Ogiltigt format. Ange ett giltigt belopp.");
            }
        }
    }
}

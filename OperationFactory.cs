using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    //Factory pattern som skapar olika instanser av IOperation utifrån vad användaren väljer.
    internal class OperationFactory
    {
        /// <summary>
        /// Returnerar en IOperation datatyp utifrån vad användaren väljer.
        /// Tar emot en string som bör skickas via ATMs menyn.
        /// </summary>
        public static IOperation GetOperation(string operationType)
        {
            switch (operationType)
            {
                case "balance":
                    return new BalanceInquiry();
                case "deposit":
                    return new Deposit();
                case "withdraw":
                    return new Withdraw();
                default:
                    throw new InvalidOperationException("Okänt val...");
            }
        }
    }
}

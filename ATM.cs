using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    //Klassen använder Singelton för att säkerställa ett enda instans av appen under hela
    //livslängden av sessionen.
    public sealed class ATM
    {
        private static readonly ATM _instance = new ATM();
        private ATM() { }
        public static ATM Instance => _instance;

        public void Start()
        {
            //Vi skapar en instans av en användare och kör Authenticate-metoden
            //fär att tillåta inloggning.
            User user = UserLogin.Authenticate();

            //Ifall vi matar in fel data så fortsätter den att köra.
            while(user == null)
            {
                user = UserLogin.Authenticate();
            }

            //Om inloggningen blir lyckad så går vi vidare mot vår Strategy pattern.
            if (user != null)
            {
                Console.WriteLine("Välkommen till ALDORS Bankomat!");

                while (true)
                {
                    Console.WriteLine("Skriv numret motsvarande ditt val:");
                    Console.WriteLine("1. Kolla saldo");
                    Console.WriteLine("2. Sätta in pengar");
                    Console.WriteLine("3. Ta ut pengar");
                    Console.WriteLine("4. Avsluta");

                    var operation = Console.ReadLine();
                    IOperation strategy;

                    switch (operation)
                    {
                        case "1":
                            strategy = OperationFactory.GetOperation("balance");
                            break;
                        case "2":
                            strategy = OperationFactory.GetOperation("deposit");
                            break;
                        case "3":
                            strategy = OperationFactory.GetOperation("withdraw");
                            break;
                        case "4":
                            return;
                        default:
                            Console.WriteLine("Valet finns inte. Försök igen.");
                            continue;
                    }
                    Console.Clear();
                    strategy.Execute(user);
                    Console.WriteLine("Tryck på tangetbordet för att fortsätta...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}

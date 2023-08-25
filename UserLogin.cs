using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    //Den här klassen ansvarar för att autentisera användare
    internal class UserLogin
    {
        private static readonly List<User> _users = new List<User>
    {
            //demo användare
        new User { Email = "test@email.com", Password = "password123", Balance = 1000.50M }
    };

        /// <summary>
        /// Method to authenticate user based on hard-coded credentials.
        /// </summary>
        /// <returns></returns>
        public static User Authenticate()
        {
            Console.WriteLine("Mejladress:");
            var email = Console.ReadLine();
            Console.WriteLine("Lösenord:");
            var password = Console.ReadLine();

            foreach (var user in _users)
            {
                if (user.Email == email && user.Password == password)
                {
                    Console.Clear();
                    return user;
                }
            }
            Console.Clear();
            Console.WriteLine("Fel mejladress eller lösenord.\n" +
                "Tryck på tangentbordet för att försöka igen...");
            Console.ReadKey();
            Console.Clear();
            return null;
        }
    }
}

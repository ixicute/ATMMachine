using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    //En enkel model för en användare.
    internal class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
    }
}

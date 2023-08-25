using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    //Detta interface är nykeln för den Strategy Pattern som ska implementeras.
    internal interface IOperation
    {
        void Execute(User user);
    }
}

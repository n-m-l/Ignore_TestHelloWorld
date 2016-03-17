using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host.ConsoleApp
{
    public sealed class ConsoleEmitter : IEmitter
    {
        public void Emit(string message)
        {
            Console.WriteLine(message);
        }
    }
}

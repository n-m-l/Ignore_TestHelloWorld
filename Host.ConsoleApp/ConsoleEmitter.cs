using HelloWorld;
using System;

namespace Host.ConsoleApp
{
    public sealed class ConsoleEmitter : IEmitter
    {
        public void Emit(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}

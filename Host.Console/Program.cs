using HelloWorld;
using System;

namespace Host.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmitter em = new ConsoleEmitter();
            SayHello eh = new SayHello();
            eh.Register(em);
            eh.Emit();
            Console.ReadLine();
        }
    }
}

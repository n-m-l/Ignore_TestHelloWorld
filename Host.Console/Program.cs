using HelloWorld;
using System;

namespace Host.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello eh = new SayHello();
            eh.Register(new ConsoleEmitter());
#if DEBUG 
            eh.Register(new DebugEmitter());
#endif
            eh.Emit();
            
            System.Console.ReadLine();
        }
    }
}

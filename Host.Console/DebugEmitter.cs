using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host.ConsoleApp
{
    public sealed class DebugEmitter : IEmitter
    {
        public void Emit(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}

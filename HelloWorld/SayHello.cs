using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class SayHello
    {
        public List<IEmitter> Emitters { get; set; }

        public SayHello(List<IEmitter> emitters)
        {
            Emitters = emitters;
        }

        public void Emit()
        {
            if (Emitters == null) return;
            foreach (IEmitter emitter in Emitters) emitter.Emit("Hello World!");
        }
    }
}

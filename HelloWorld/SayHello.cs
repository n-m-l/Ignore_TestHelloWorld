using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class SayHello
    {
        public List<IEmitter> Emitters { get; set; }

        public SayHello()
        { }

        public SayHello(List<IEmitter> emitters)
        {
            Emitters = emitters;
        }

        public void Emit()
        {
            if (Emitters == null) return;
            foreach (IEmitter emitter in Emitters) emitter.Emit("Hello World!");
        }

        public void Register(IEmitter emitter)
        {
            if (Emitters == null) Emitters = new List<IEmitter>();
            Emitters.Add(emitter);
        }
    }
}

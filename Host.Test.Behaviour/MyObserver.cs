using HelloWorld;

namespace Test.Behaviour
{
    public sealed class MyObserver : IEmitter
    {
        public string MessageReceived { get; set; }

        public void Emit(string message)
        {
            MessageReceived = message;
        }
    }
}

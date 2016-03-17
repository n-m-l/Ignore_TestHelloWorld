using HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Test.Behaviour
{
    [Binding]
    public sealed class EmitSteps
    {
        private MyObserver MyObserver { get; set; }
        private SayHello SayHello { get; set; }

        [Given("I have registered for a hello world event")]
        public void GivenIHaveRegisteredForAHelloWorldEvent()
        {
            SayHello = new HelloWorld.SayHello();
            MyObserver = new MyObserver();
            SayHello.Register(MyObserver);
        }

        [When("SayHello is run")]
        public void WhenSayHelloIsRun()
        {
            SayHello.Emit();
        }

        [Then("I should receive the hello world message")]
        public void ThenIShouldReceiveTheHelloWorldMessage()
        {
            Assert.AreEqual(MyObserver.MessageReceived, "Hello World!");
        }
    }
}

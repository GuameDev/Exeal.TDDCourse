namespace Exeal.GreetingKata.TDD.Tests
{
    public class GreeterSpecs
    {
        [Fact]
        public void GreetsPablo()
        {
            var result = Greeter.Greet("Pablo");
            Assert.Equal("¡Hola, Pablo!", result);

        }

        [Fact]
        public void GreetsManuel()
        {
            var result = Greeter.Greet("Manuel");
            Assert.Equal("¡Hola, Manuel!", result);

        }
    }
}
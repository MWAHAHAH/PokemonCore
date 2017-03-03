using Microsoft.Extensions.Configuration;

namespace HelloWorldCore
{
    public interface IGreeter
    {
        string GetGreeting();
    }

    public class Greeter : IGreeter
    {
        private string _greeting;

        public Greeter(IConfiguration config)
        {
            _greeting = config["Greeting"];
        }

        public string GetGreeting()
        {
            return _greeting;
        }
    }
}

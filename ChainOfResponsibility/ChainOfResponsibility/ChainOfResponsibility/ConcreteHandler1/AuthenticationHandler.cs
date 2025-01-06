using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility.ConcreteHandler1
{
    public class AuthenticationHandler : Handler
    {
        protected override bool ProcessRequest(string request)
        {
            if (request == "Authenticated")
            {
                Console.WriteLine("User is authenticated.");
                return true;
            }
            return false;
        }
    }
}

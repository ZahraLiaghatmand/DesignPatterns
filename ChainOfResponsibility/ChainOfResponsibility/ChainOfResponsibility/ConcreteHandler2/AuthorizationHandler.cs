using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility.ConcreteHandler2
{
    public class AuthorizationHandler : Handler
    {
        protected override bool ProcessRequest(string request)
        {
            if (request == "Authorized")
            {
                Console.WriteLine("User is authorized.");
                return true;
            }
            return false;
        }
    }
}

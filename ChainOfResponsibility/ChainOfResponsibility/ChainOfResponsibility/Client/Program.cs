using ChainOfResponsibility.ConcreteHandler1;
using ChainOfResponsibility.ConcreteHandler2;
using ChainOfResponsibility.ConcreteHandler3;
using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility.Client
{
    public class Program
    {
        static void Main(string[] args)
        {

            Handler authHandler = new AuthenticationHandler();
            Handler authorizationHandler = new AuthorizationHandler();
            Handler adminHandler = new AdminHandler();

            authHandler.SetNext(authorizationHandler);
            authorizationHandler.SetNext(adminHandler);

            Console.WriteLine("Sending 'Authenticated' request:");
            authHandler.HandleRequest("Authenticated");

            Console.WriteLine("\nSending 'Authorized' request:");
            authHandler.HandleRequest("Authorized");

            Console.WriteLine("\nSending 'Admin' request:");
            authHandler.HandleRequest("Admin");

            Console.WriteLine("\nSending 'Unknown' request:");
            authHandler.HandleRequest("Unknown");
        }

    }
}

using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility.ConcreteHandler3
{
    public class AdminHandler : Handler
    {
        protected override bool ProcessRequest(string request)
        {
            if (request == "Admin")
            {
                Console.WriteLine("User is admin.");
                return true;
            }
            return false;
        }
    }
}

namespace BetterMediator.Controls
{
    public class Button
    {
        public Boolean IsEnabled { get; set; }
        public void Click()
        {
            if (IsEnabled)
            {
                Console.WriteLine("Sign up process initiated.");
            }
            else
            {
                Console.WriteLine("Fill the fields first.");
            }
        }
    }
}

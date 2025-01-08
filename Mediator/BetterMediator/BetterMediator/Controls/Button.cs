using BetterMediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterMediator.Controls
{
    public class Button : UIControl
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

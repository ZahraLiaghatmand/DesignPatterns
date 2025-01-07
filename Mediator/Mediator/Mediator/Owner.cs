using Mediator.UIControls;

namespace Mediator.Mediator
{
    public class Owner : IMediator
    {
        public UserNameTextBox UserNameTxt;
        public PasswordTextBox PasswordTxt;
        public SignUpButton SignUpButton;
        public Owner()
        {
            UserNameTxt = new(this);
            PasswordTxt = new(this);
            SignUpButton = new(this);

        }
        public void Changed(IUIControl control)
        {
            if (control != null)
            {
                if (UserNameTxt.Text != null && PasswordTxt.Text != null)
                {
                    SignUpButton.IsEnabled = true;
                }
            }        
        }
        public void Simulator()
        {
            UserNameTxt.SetText("Zahra");
            Console.WriteLine(SignUpButton.IsEnabled);
            PasswordTxt.SetText("123");
            Console.WriteLine(SignUpButton.IsEnabled);
        }
    }
}

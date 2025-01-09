using BetterMediator.Controls;
using BetterMediator.Mediator;

namespace BetterMediator.Mediators
{
    public class Mediator : IMediator
    {
        private readonly TextBox _userName;
        private readonly TextBox _password;
        private readonly CheckBox _agreement;
        private readonly Button _signUp;

        public Mediator(TextBox userName, TextBox password, CheckBox agreement, Button signUp)
        {
            _userName = userName;
            _userName.attach(this);
            _password = password;
            _password.attach(this);
            _agreement = agreement;
            _agreement.attach(this);
            _signUp = signUp;
        }

        public void Notify(UIControl control, string eventType)
        {
            bool isFormValid = !string.IsNullOrEmpty(_userName.Text) &&
                !string.IsNullOrEmpty(_password.Text) &&
                _agreement.IsChecked;
            _signUp.IsEnabled = isFormValid;            
        }
        
    }
}

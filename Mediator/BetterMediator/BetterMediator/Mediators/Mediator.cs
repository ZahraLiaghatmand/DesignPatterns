using BetterMediator.Controls;
using BetterMediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _userName.SetMediator(this);
            _password = password;
            _password.SetMediator(this);
            _agreement = agreement;
            _agreement.SetMediator(this);
            _signUp = signUp;
            _signUp.SetMediator(this);
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

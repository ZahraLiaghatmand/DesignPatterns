using BetterMediator.Mediator;

namespace BetterMediator.Controls
{
    public class TextBox(List<IMediator> observers) : UIControl(observers)
    {
        private string _text;

        public string Text {
            get => _text;
            set {
                _text = value;
                NotifyMediator("Text Changed."); 
            }
        }
    }
}

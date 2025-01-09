using BetterMediator.Mediator;

namespace BetterMediator.Controls
{
    public class CheckBox(List<IMediator> observers) : UIControl(observers)
    {
        private Boolean _isChecked;

        public Boolean IsChecked
        {
            get => _isChecked;
            set { _isChecked = value;
                NotifyMediator("check is changed.");
            }
        }

    }
}

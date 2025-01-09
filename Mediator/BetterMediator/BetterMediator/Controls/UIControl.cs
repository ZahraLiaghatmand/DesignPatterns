using BetterMediator.Mediator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BetterMediator.Controls
{
    public abstract class UIControl(List<IMediator> observers)
    {
        private List<IMediator> _observers = observers;

        public void attach(IMediator mediator)
        {
            _observers.Add(mediator);
        }
        protected void NotifyMediator(string eventType)
        {
            foreach(var observer in  _observers)
                observer?.Notify(this, eventType);
        }
    }
}

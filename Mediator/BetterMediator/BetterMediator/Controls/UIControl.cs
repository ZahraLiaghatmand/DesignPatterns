using BetterMediator.Mediator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterMediator.Controls
{
    public abstract class UIControl
    {
        private IMediator _mediator;
        public void SetMediator(IMediator mediator) 
            => _mediator = mediator;
        public void NotifyMediator(string eventType)
        {
            _mediator?.Notify(this, eventType);
        }
    }
}

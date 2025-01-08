using BetterMediator.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterMediator.Mediator
{
    public interface IMediator
    {
        void Notify(UIControl iUIControl, string eventType);
    }
}

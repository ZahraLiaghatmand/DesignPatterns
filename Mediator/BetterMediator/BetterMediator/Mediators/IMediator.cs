using BetterMediator.Controls;

namespace BetterMediator.Mediator
{
    public interface IMediator
    {
        void Notify(UIControl iUIControl, string eventType);
    }
}

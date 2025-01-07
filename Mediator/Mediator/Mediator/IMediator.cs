using Mediator.UIControls;

namespace Mediator.Mediator
{
    public interface IMediator
    {
        public void Changed(IUIControl control);
    }
}

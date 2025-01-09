using Mediator.Mediator;

namespace Mediator.UIControls
{
    public class PasswordTextBox(IMediator owner) : IUIControl
    {
        private readonly IMediator _Owner = owner;
        public string Text;
        public string GetText() { return Text; }
        public void SetText(string text) { Text = text; _Owner.Changed(this); }
    }
}

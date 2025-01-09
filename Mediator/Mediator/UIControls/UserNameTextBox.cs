using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Mediator;

namespace Mediator.UIControls
{
    public class UserNameTextBox : IUIControl
    {
        private readonly IMediator _Owner;
        public string Text { get; set; }

        public UserNameTextBox(IMediator owner)
        {
            _Owner = owner;
        }

        public string GetText() { return Text; }
        public void SetText(string text) { Text = text; _Owner.Changed(this); }
    }
}

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Mediator;

namespace Mediator.UIControls
{
    public class SignUpButton(IMediator owner) : IUIControl
    {
        private readonly IMediator _Owner = owner;
        public Boolean IsEnabled {  get; set; }
    }
}

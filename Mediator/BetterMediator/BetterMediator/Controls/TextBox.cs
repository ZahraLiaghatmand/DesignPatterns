using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterMediator.Controls
{
    public class TextBox : UIControl
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

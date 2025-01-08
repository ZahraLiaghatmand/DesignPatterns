using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterMediator.Controls
{
    public class CheckBox : UIControl
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

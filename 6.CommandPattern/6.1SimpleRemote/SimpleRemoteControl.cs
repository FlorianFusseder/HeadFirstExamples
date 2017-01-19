using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleRemote
{
    public class SimpleRemoteControl
    {
        public ICommand Slot{ get; set; }

        public SimpleRemoteControl()
        {

        }

        public void SetControl(ICommand Command)
        {
            Slot = Command;
        }

        public void PressButton()
        {
            if (Slot.CanExecute(null))
                Slot.Execute(null);
        }
    }
}

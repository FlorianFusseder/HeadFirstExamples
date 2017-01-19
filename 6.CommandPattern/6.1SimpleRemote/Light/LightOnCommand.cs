using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleRemote
{
    public class LightOnCommand : ICommand
    {
        private Light light;
        public event EventHandler CanExecuteChanged;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public bool CanExecute(object parameter)
        {
            return light?.On == false;
        }

        public void Execute(object parameter)
        {
            light?.SwitchOn();
        }
    }
}

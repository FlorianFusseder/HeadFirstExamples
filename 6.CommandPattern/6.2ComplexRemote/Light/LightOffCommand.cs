using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComplexRemote
{
    class LightOffCommand : ICommand
    {
        private Light light;

        public event EventHandler CanExecuteChanged;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public bool CanExecute(object parameter)
        {
            return light?.On == true;
        }

        public void Execute(object parameter)
        {
            light?.SwitchOff();
        }
    }
}

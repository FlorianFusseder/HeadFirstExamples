using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComplexRemote
{
    public class LightOnCommand : ICommand
    {
        private Light light;
        public event EventHandler CanExecuteChanged;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public bool CanExecute()
        {
            return light?.On == false;
        }

        public void Execute()
        {
            light?.SwitchOn();
        }

        public void Undo()
        {
            light?.SwitchOff();
        }
    }
}

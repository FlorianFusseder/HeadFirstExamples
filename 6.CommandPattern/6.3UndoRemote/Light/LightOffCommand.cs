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

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public bool CanExecute()
        {
            return light?.On == true;
        }

        public void Execute()
        {
            light?.SwitchOff();
        }

        public void Undo()
        {
            light?.SwitchOn();
        }
    }
}

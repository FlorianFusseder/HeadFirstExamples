using System;
using System.Windows.Input;

namespace ComplexRemote
{
    public class FanOnCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;
        private CeilingFan ceilingFan;

        public FanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public bool CanExecute(object parameter)
        {
            return ceilingFan?.On == false;
        }

        public void Execute(object parameter)
        {
            ceilingFan?.StartFan();
        }
    }
}
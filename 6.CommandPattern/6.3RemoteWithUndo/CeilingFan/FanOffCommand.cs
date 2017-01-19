using System;
using System.Windows.Input;

namespace ComplexRemote
{
    internal class FanOffCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private CeilingFan ceilingFan;

        public FanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public bool CanExecute(object parameter)
        {
            return ceilingFan?.On == true; 
        }

        public void Execute(object parameter)
        {
            ceilingFan?.StopFan();
        }
    }
}
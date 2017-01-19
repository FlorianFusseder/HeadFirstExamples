using System;
using System.Windows.Input;

namespace ComplexRemote
{
    public class StereoStopCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Stereo stereo;

        public StereoStopCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public bool CanExecute(object parameter)
        {
            return stereo?.On == true;
        }

        public void Execute(object parameter)
        {
            stereo?.StereoStop();
        }
    }
}
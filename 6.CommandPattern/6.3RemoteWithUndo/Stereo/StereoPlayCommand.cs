using System;
using System.Windows.Input;

namespace ComplexRemote
{
    internal class StereoPlayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Stereo stereo;

        public StereoPlayCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public bool CanExecute(object parameter)
        {
            return stereo?.On == false;
        }

        public void Execute(object parameter)
        {
            stereo?.ChooseCD();
            stereo?.SetVolume(.1);
            stereo?.ChooseCD();
            stereo?.StereoStart();
        }
    }
}
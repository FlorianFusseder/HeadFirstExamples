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

        public bool CanExecute()
        {
            return stereo?.On == true;
        }

        public void Execute()
        {
            stereo?.StereoStop();
        }

        public void Undo()
        {
            stereo?.SetVolume(.1);
            stereo?.ChooseCD();
            stereo?.StereoStart();
        }
    }
}
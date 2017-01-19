using System;
using System.Windows.Input;

namespace ComplexRemote
{
    class StereoPlayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Stereo stereo;

        public StereoPlayCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public bool CanExecute()
        {
            return stereo?.On == false;
        }

        public void Execute()
        {
            stereo?.SetVolume(.1);
            stereo?.ChooseCD();
            stereo?.StereoStart();
        }

        public void Undo()
        {
            stereo?.StereoStop();
        }
    }
}
using System;
using System.Windows.Input;

namespace ComplexRemote
{
    public class GarageOpenCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;
        private Garage garage;

        public GarageOpenCommand(Garage garage)
        {
            this.garage = garage;
        }

        public bool CanExecute(object parameter)
        {
            return garage?.Open == false;
        }

        public void Execute(object parameter)
        {
            garage.SwitchOpen();
        }
    }
}
using System;
using System.Windows.Input;

namespace ComplexRemote
{
    public class GarageOpenCommand : ICommand
    {

        private Garage garage;

        public GarageOpenCommand(Garage garage)
        {
            this.garage = garage;
        }

        public bool CanExecute()
        {
            return garage?.Open == false;
        }

        public void Execute()
        {
            garage.SwitchOpen();
        }

        public void Undo()
        {
            garage.SwitchClose();
        }
    }
}
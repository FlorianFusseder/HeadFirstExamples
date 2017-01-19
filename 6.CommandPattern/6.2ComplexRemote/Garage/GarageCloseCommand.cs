using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComplexRemote
{
    class GarageCloseCommand : ICommand
    {
        private Garage garage;

        public event EventHandler CanExecuteChanged;

        public GarageCloseCommand(Garage garage)
        {
            this.garage = garage;
        }

        public bool CanExecute(object parameter)
        {
            return garage?.Open == true;
        }

        public void Execute(object parameter)
        {
            garage?.SwitchClose();
        }
    }
}

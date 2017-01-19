using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexRemote
{
    class MultiOffMacroCommand : ICommand
    {

        public List<ICommand> ExecuteList { get; set; }

        public MultiOffMacroCommand()
        {
            ExecuteList = null;
        }

        public bool CanExecute()
        {
            return ExecuteList?.Count > 0;
        }

        public void Execute()
        {
            foreach (var item in ExecuteList)
                if (item.CanExecute())
                    item.Execute();
        }

        public void Undo()
        {
            foreach (var item in ExecuteList)
                item.Undo();
        }
    }
}

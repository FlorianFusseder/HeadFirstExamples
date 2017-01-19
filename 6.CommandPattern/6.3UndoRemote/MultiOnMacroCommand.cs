using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexRemote
{
    public class MultiOnMacroCommand : ICommand
    {
        public List<ICommand> ExecuteList { get; set; }

        public MultiOnMacroCommand()
        {
            ExecuteList = null;
        }

        public void Execute()
        {
            foreach (var item in ExecuteList)
                if (item.CanExecute())
                    item.Execute();
        }

        public bool CanExecute()
        {
            return ExecuteList?.Count > 0;
        }

        public void Undo()
        {
            foreach (var item in ExecuteList)
                item.Undo();
        }
    }
}

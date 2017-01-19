using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComplexRemote
{
    class UndoRemoteControl
    {
        private ICommand[] OnCommand { get; set; }
        private ICommand[] OffCommand { get; set; }
        private Stack<ICommand> UndoStack { get; set; }

        public UndoRemoteControl()
        {
            OnCommand = new ICommand[7];
            OffCommand = new ICommand[7];
            UndoStack = new Stack<ICommand>();
        }

        public void SetNewCommand(ICommand onCommand, ICommand offCommand)
        {
            int index = Array.FindIndex(OnCommand, m => m == null);
            SetNewCommand(onCommand, offCommand, index);
        }

        public void SetNewCommand(ICommand onCommand, ICommand offCommand, int index)
        {
            OnCommand[index] = onCommand;
            OffCommand[index] = offCommand;
        }

        public void PressOnButton(int b)
        {
            if (OnCommand?[b]?.CanExecute() == true)
            {
                OnCommand[b].Execute();
                UndoStack.Push(OnCommand[b]);
            }
            else
            {
                Console.WriteLine($"Could not be Operate OnButton {b}");
            }
        }

        public void PressOffButton(int b)
        {
            if (OffCommand?[b]?.CanExecute() == true)
            {
                OffCommand[b].Execute();
                UndoStack.Push(OffCommand[b]);
            }
            else
            {
                Console.WriteLine($"Could not be Operate OffButton {b}");
            }
        }

        public void PressUndoButton()
        {
            if (UndoStack?.Count > 0)
                UndoStack.Pop().Undo();
            else
                Console.WriteLine($"Undostack Empty");
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"{new string('_', 34)}RemoteControl{new string('_', 34)}");

            for (int i = 0; i < OnCommand.Length; i++)
                builder.AppendLine($"{i}. On: {OnCommand?[i]?.GetType().Name.ToString() ?? "N/A",-25} Off: {OffCommand?[i]?.GetType().Name.ToString() ?? "N/A"}");


            builder.AppendLine($"UndoButton: { ((UndoStack != null && UndoStack.Count > 0) ? UndoStack.Peek().GetType().Name.ToString() : "N/A")}");
            builder.AppendLine(new string('_', 81));
            return builder.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComplexRemote
{

    public enum Button
    {
        on1,
        on2,
        on3, 
        on4,
        on5,
        on6,
        on7,
        off1,
        off2,
        off3,
        off4,
        off5,
        off6,
        off7
    };

    class ComplexRemoteControl
    {
        private ICommand[] OnCommand { get; set; }
        private ICommand[] OffCommand { get; set; }

        public ComplexRemoteControl()
        {
            OnCommand = new ICommand[7];
            OffCommand = new ICommand[7];
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

        public void PressButton(Button b)
        {
            var button = (int)b;

            if (button > 6 && OffCommand?[button - 7]?.CanExecute(null) == true)
                OffCommand?[button - 7]?.Execute(null);
            else if(button < 7 && button > -1 && OnCommand?[button]?.CanExecute(null) == true)
                OnCommand?[button]?.Execute(null);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"{new string('_', 34)}RemoteControl{new string('_', 34)}");

            for (int i = 0; i < OnCommand.Length; i++)
                builder.AppendLine($"{i}. On: {OnCommand?[i]?.GetType().Name.ToString() ?? "N/A", -25} Off: {OffCommand?[i]?.GetType().Name.ToString() ?? "N/A"}");

            builder.AppendLine(new string('_', 81));
            return builder.ToString();
        }
    }
}

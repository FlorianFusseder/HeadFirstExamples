using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace ComplexRemote
{
    class Program
    {
        static void Main(string[] args)
        {
            var Remote = new UndoRemoteControl();

            var livingRoomLight = new Light("Living Room Light");
            var kitchenRoomLight = new Light("Kitchen Room Light");
            var ceilingFan = new CeilingFan("Ceiling Fan");
            var garage = new Garage("Garage Bmw");
            var stereo = new Stereo("Stereo Player");

            var livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);
            var livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);

            var kitchenRoomLightOffCommand = new LightOffCommand(kitchenRoomLight);
            var kitchenRoomLightOnCommand = new LightOnCommand(kitchenRoomLight);

            var ceilingFanOffCommand = new FanOffCommand(ceilingFan);
            var ceilingFanOnCommand = new FanOnCommand(ceilingFan);

            var garageCloseCommand = new GarageCloseCommand(garage);
            var garageOpenCommand = new GarageOpenCommand(garage);

            var stereoPlayCommand = new StereoPlayCommand(stereo);
            var stereoStopCommand = new StereoStopCommand(stereo);

            var fanLow = new FanLowCommand(ceilingFan);
            var fanMedim = new FanMediumCommand(ceilingFan);
            var fanHigh = new FanHighCommand(ceilingFan);

            Console.WriteLine(Remote);

            Remote.SetNewCommand(livingRoomLightOnCommand, livingRoomLightOffCommand);
            //Remote.SetNewCommand(garageOpenCommand, garageCloseCommand);
            //Remote.SetNewCommand(ceilingFanOnCommand, ceilingFanOffCommand);
            //Remote.SetNewCommand(fanLow, ceilingFanOffCommand);
            //Remote.SetNewCommand(fanMedim, ceilingFanOffCommand);
            //Remote.SetNewCommand(fanHigh, ceilingFanOffCommand);
            //Remote.SetNewCommand(stereoPlayCommand, stereoStopCommand);

            var leaveMacro = new MultiOffMacroCommand();
            var comeMacro = new MultiOnMacroCommand();

            leaveMacro.ExecuteList = new List<ICommand>
            {
                livingRoomLightOffCommand,
                kitchenRoomLightOffCommand,
                ceilingFanOffCommand,
                garageCloseCommand,
                stereoStopCommand,
            };

            comeMacro.ExecuteList = new List<ICommand>
            {
                livingRoomLightOnCommand,
                kitchenRoomLightOnCommand,
                ceilingFanOnCommand,
                garageOpenCommand,
                stereoPlayCommand,
            };

            Console.WriteLine(Remote);

            Remote.SetNewCommand(comeMacro, leaveMacro);


            Remote.PressOnButton(0);
            Console.WriteLine(Remote);

            Remote.PressOnButton(1);
            Console.WriteLine(Remote);

            Remote.PressOffButton(1);
            Console.WriteLine(Remote);

            Remote.PressUndoButton();
            Console.WriteLine(Remote);

            Remote.PressUndoButton();
            Console.WriteLine(Remote);

            Remote.PressUndoButton();
            Console.WriteLine(Remote);

            Remote.PressUndoButton();
            Console.WriteLine(Remote);

            Console.ReadLine();
        }
    }
}

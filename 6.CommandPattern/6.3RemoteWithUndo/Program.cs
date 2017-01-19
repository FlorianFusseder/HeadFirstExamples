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
            var Remote = new ComplexRemoteControl();

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

            Console.WriteLine(Remote);
            Console.WriteLine();
            Console.WriteLine();

            Remote.SetNewCommand(livingRoomLightOnCommand, livingRoomLightOffCommand);
            Remote.SetNewCommand(kitchenRoomLightOnCommand, kitchenRoomLightOffCommand);
            Remote.SetNewCommand(garageOpenCommand, garageCloseCommand);
            Remote.SetNewCommand(ceilingFanOnCommand, ceilingFanOffCommand);
            Remote.SetNewCommand(stereoPlayCommand, stereoStopCommand);

            Console.WriteLine(Remote);

            Remote.PressButton(Button.on1);
            Remote.PressButton(Button.on2);
            Remote.PressButton(Button.on3);
            Remote.PressButton(Button.on4);
            Remote.PressButton(Button.on5);

            Remote.PressButton(Button.off1);
            Remote.PressButton(Button.off2);
            Remote.PressButton(Button.off3);
            Remote.PressButton(Button.off4);
            Remote.PressButton(Button.off5);


            Console.ReadLine();
        }
    }
}

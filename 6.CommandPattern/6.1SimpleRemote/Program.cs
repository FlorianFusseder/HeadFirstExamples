using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRemote
{
    public class Program
    {

        static void Main(string[] args) 
        {
            var src = new SimpleRemoteControl();

            var light = new Light();
            var garage = new Garage();

            src.SetControl(new LightOnCommand(light));
            src.PressButton();
            Console.WriteLine();
            src.SetControl(new GarageOpenCommand(garage));
            src.PressButton();

            Console.ReadLine();
        }
    }
}

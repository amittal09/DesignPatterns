using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command.RemoteControl
{
   public class ZProgram
    {
       public static void Main()
       {
           SimpleRemoteControl remote = new SimpleRemoteControl();
           Light light = new Light("Home");
           LightOnCommand lightOnCommand = new LightOnCommand(light);
           remote.SetCommand(lightOnCommand);
           Console.WriteLine(remote.ButtonWasPressed());


       }
    }
}

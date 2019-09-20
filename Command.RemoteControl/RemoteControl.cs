using System;
using System.Text;

namespace DesignPatterns.Command.RemoteControl
{
	/// <summary>
	/// Summary description for RemoteControl.
	/// </summary>
	//
	// This is the invoker
	//
	public class Remote 
	{
		ICommand[] onCommands;
		ICommand[] offCommands;
 
		public Remote() 
		{
			onCommands = new ICommand[7];
			offCommands = new ICommand[7];
 
			ICommand noCommand = new NoCommand();
			for (int i = 0; i < 7; i++) 
			{
				onCommands[i] = noCommand;
				offCommands[i] = noCommand;
			}
		}
  
		public void SetCommand(int slot, ICommand onCommand, ICommand offCommand) 
		{
			onCommands[slot] = onCommand;
			offCommands[slot] = offCommand;
		}
 
		public object OnButtonWasPushed(int slot)
		{
			return onCommands[slot].Execute();
		}
 
		public object OffButtonWasPushed(int slot) 
		{
			return offCommands[slot].Execute();
		}
  
		public string toString() 
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("\n------ Remote Control -------\n");
			for (int i = 0; i < onCommands.Length; i++) 
			{
				sb.Append("[slot " + i + "] " + onCommands[i].GetType().Name
					+ "    " + offCommands[i].GetType().Name + "\n");
			}
			return sb.ToString();
		}
	}
}

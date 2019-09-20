using System;

namespace DesignPatterns.Command.RemoteControl
{
	/// <summary>
	/// Summary description for SimpleRemoteControl
	/// </summary>
	public class SimpleRemoteControl
	{
		ICommand slot;

		public SimpleRemoteControl()
		{}

		public object SetCommand(ICommand command)
		{
			slot = command;
			return slot;
		}

		public object ButtonWasPressed()
		{
			return slot.Execute();
		}
	}
}

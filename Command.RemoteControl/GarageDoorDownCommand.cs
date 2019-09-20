using System;

namespace DesignPatterns.Command.RemoteControl
{
	/// <summary>
	/// Summary description for GarageDoorOpenCommand.
	/// </summary>
	public class GarageDoorDownCommand : ICommand
	{
		GarageDoor garageDoor;

		public GarageDoorDownCommand(GarageDoor garageDoor)
		{
			this.garageDoor = garageDoor;
		}

		#region Command Members
		public object Execute()
		{
			return garageDoor.Down();
		}
		#endregion
	}
}

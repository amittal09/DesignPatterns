using System;

namespace DesignPatterns.Command.RemoteControl
{
	/// <summary>
	/// Summary description for GarageDoorOpenCommand.
	/// </summary>
	public class GarageDoorUpCommand : ICommand
	{
		GarageDoor garageDoor;

		public GarageDoorUpCommand(GarageDoor garageDoor)
		{
			this.garageDoor = garageDoor;
		}

		#region Command Members

		public object Execute()
		{
			return garageDoor.Up();
		}

		#endregion
	}
}

using System;

namespace DesignPatterns.Command.RemoteControl
{
	/// <summary>
	/// Summary description for CeilingFanOnCommand.
	/// </summary>
	public class CeilingFanOffCommand : ICommand
	{
		CeilingFan ceilingFan;

		public CeilingFanOffCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}

		#region Command Members

		public object Execute()
		{
			return ceilingFan.Off();
		}

		#endregion
	}
}

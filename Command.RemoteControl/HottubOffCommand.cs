using System;

namespace DesignPatterns.Command.RemoteControl
{
	/// <summary>
	/// Summary description for HottubOnCommand.
	/// </summary>
	public class HottubOffCommand : ICommand
	{
		Hottub hottub;

		public HottubOffCommand(Hottub hottub)
		{
			this.hottub = hottub;
		}

		#region Command Members
		public object Execute()
		{
			return hottub.Off();
		}
		#endregion
	}
}

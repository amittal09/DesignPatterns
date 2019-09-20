using System;

namespace DesignPatterns.Command.RemoteControl
{
	/// <summary>
	/// Summary description for NoCommand.
	/// </summary>
	public class NoCommand : ICommand
	{
		public NoCommand()
		{}

		#region Command Members
		public object Execute()
		{
			return null;
		}
		#endregion
	}
}

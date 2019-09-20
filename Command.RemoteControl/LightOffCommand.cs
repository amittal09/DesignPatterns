using System;

namespace DesignPatterns.Command.RemoteControl
{
	/// <summary>
	/// Summary description for LightOnCommand.
	/// </summary>
	public class LightOffCommand : ICommand
	{
		Light light;

		public LightOffCommand(Light light)
		{
			this.light = light;
		}

		#region Command Members

		public object Execute()
		{
			return light.Off();
		}

		#endregion
	}
}

using System;

namespace DesignPatterns.Command.RemoteControl
{
	/// <summary>
	/// Summary description for LightOnCommand.
	/// </summary>
	public class LightOnCommand : ICommand
	{
		Light light;

		public LightOnCommand(Light light)
		{
			this.light = light;
		}

		#region Command Members

		public object Execute()
		{
			return light.On();
		}

		#endregion
	}
}

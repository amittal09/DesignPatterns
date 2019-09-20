using System;

namespace DesignPatterns.Command.RemoteControl
{
	/// <summary>
	/// Summary description for LightOnCommand.
	/// </summary>
	public class LivingroomLightOffCommand : ICommand
	{
		Light light;

		public LivingroomLightOffCommand(Light light)
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

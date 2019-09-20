using System;

namespace DesignPatterns.Command.RemoteControl
{
	/// <summary>
	/// Command Pattern implemented interface
	/// </summary>
	public interface ICommand
	{
		object Execute();
	}
}

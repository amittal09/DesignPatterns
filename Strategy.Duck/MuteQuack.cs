using System;

namespace DesignPatterns.Strategy.Duck
{
	/// <summary>
	/// MuteQuack
	/// </summary>
	public class MuteQuack : IQuackBehavior
	{
		public string Quacking()
		{
			return "<<silence>>";
		}
	}
}

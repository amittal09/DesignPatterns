using System;

namespace DesignPatterns.Strategy.Duck
{
	/// <summary>
	/// Quack
	/// </summary>
	public class Quack : IQuackBehavior
	{
		public string Quacking()
		{
			return "Quack";
		}
	}
}

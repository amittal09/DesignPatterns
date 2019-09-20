using System;

namespace DesignPatterns.Strategy.Character
{
	/// <summary>
	/// King
	/// </summary>
	public class King : Character
	{
		public King()
		{
			weapon = new SwordBehavior();
		}
	}
}

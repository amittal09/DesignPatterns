using System;

namespace DesignPatterns.Strategy.Character
{
	/// <summary>
	/// Summary description for Knight.
	/// </summary>
	public class Knight : Character
	{
		public Knight()
		{
			weapon = new BowAndArrowBehavior();
		}
	}
}

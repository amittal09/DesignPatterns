using System;

namespace DesignPatterns.Strategy.Football
{
	/// <summary>
	/// Player
	/// </summary>
	public abstract class Player
	{
		protected IPlay pattern2Run;

		public Player()
		{}
	
		public string Pattern()
		{
			return pattern2Run.Movement();
		}
	}
}

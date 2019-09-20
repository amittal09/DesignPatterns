using System;

namespace DesignPatterns.Strategy.Duck
{
	/// <summary>
	/// FlyWithWings
	/// </summary>
	public class FlyWithWings : IFlyBehavior
	{
		public FlyWithWings()
		{}

		#region IFlyBehavior Members

		public object Fly()
		{
			return "I'm flying!!";
		}

		#endregion
	}
}

using System;

namespace DesignPatterns.Decorator.Starbuzz
{
	/// <summary>
	/// Summary description for HouseBlend.
	/// </summary>
	public class HouseBlend : Beverage
	{
		public HouseBlend()
		{}

		public override double Cost()
		{
			return .89;
		}

		public override string GetDescription()
		{
			return "House Blend Coffee";
		}

	}
}

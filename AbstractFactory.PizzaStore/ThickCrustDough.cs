using System;

namespace DesignPatterns.AbstractFactory.PizzaStore
{
	/// <summary>
	/// Summary description for ThickCrustDough.
	/// </summary>
	public class ThickCrustDough : IDough
	{
		#region Constructor
		public ThickCrustDough()
		{}
		#endregion//Constructor

		#region IDough Members
		public string toString()
		{
			return "Thick Crust Dough";
		}
		#endregion
	}
}

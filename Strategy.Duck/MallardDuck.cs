using System;

namespace DesignPatterns.Strategy.Duck
{
	/// <summary>
	/// Summary description for MallardDuck.
	/// </summary>
	public class MallardDuck : Duck
	{
		public MallardDuck()
		{
			QuackBehavior = new Quack();
			FlyBehavoir = new FlyWithWings();
		}

		public override object Display()
		{
			return "I'm a real Mallard duck";
			
		}
	}
}

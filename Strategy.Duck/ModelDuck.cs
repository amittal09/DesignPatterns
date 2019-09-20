namespace DesignPatterns.Strategy.Duck
{
	/// <summary>
	/// ModelDuck Object
	/// </summary>
	public class ModelDuck : Duck
	{
		public ModelDuck()
		{
			FlyBehavoir = new FlyNoWay();
			QuackBehavior = new Quack();
		}

		public override object Display()
		{
			return "I'm a model duck";
		}

	}
}


namespace DesignPatterns.Strategy.Duck
{
	/// <summary>
	/// RubberDuck object
	/// </summary>
	public class RubberDuck : Duck
	{
		public RubberDuck()
		{
            QuackBehavior = new Squeak();
            FlyBehavoir = new FlyNoWay();
		}
		
		public override object Display()
		{
			return "I'm a rubber duck";
		}
	}
}

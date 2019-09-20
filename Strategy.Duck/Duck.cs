namespace DesignPatterns.Strategy.Duck
{
	/// <summary>
	/// abstract base class of Ducks
	/// </summary>
	public abstract class Duck
	{
	    public IQuackBehavior QuackBehavior { get; set; }

	    public IFlyBehavior FlyBehavoir { get; set; }


	    public abstract object Display();

		public object PerformFly()
		{
			return FlyBehavoir.Fly();
		}

		public object PerformQuack()
		{
			return QuackBehavior.Quacking();
		}

		public string Swim()
		{
			return "All ducks float, even decoys!";
		}
	}
}

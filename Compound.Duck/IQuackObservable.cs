using System;

namespace DesignPatterns.Compound.Duck
{
	/// <summary>
	/// Summary description for IQuackObservable.
	/// </summary>
	public interface IQuackObservable
	{
		void RegisterObserver(IObserver observer);
		string NotifyObservers();
	}
}

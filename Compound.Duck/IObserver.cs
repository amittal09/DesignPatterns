using System;

namespace DesignPatterns.Compound.Duck
{
	/// <summary>
	/// Summary description for IObserver.
	/// </summary>
	public interface IObserver
	{
		string Update(IQuackObservable duck);
	}
}

using System;

namespace DesignPatterns.Observer.WeatherData
{
	/// <summary>
	/// Summary description for ISubject.
	/// </summary>
	public interface ISubject
	{
		void RegisterObserver(IObserver o);
		void RemoveObserver(IObserver o);
		void NotifyObserver();
	}
}

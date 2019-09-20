using System;

namespace DesignPatterns.State.GumballMachine
{
	/// <summary>
	/// Summary description for State.
	/// </summary>
	public interface State
	{
		string InsertQuarter();
		string EjectQuarter();
		string TurnCrank();
		string Dispense();
	}
}

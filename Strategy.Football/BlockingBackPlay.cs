using System;

namespace DesignPatterns.Strategy.Football
{
	/// <summary>
	/// Summary description for BlockingBack.
	/// </summary>
	public class BlockingBackPlay : IPlay
	{
		public BlockingBackPlay()
		{}

		#region IPlay Members

		public string Movement()
		{
			return "I am blocking any rushers that the line does not get";
		}

		#endregion
	}
}

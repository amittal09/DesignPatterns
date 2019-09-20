using System;

namespace DesignPatterns.Strategy.Football
{
	/// <summary>
	/// Summary description for RunningBack.
	/// </summary>
	public class RunningBack : Player
	{
		public RunningBack()
		{
			pattern2Run = new BlockingBackPlay();
		}
	}
}

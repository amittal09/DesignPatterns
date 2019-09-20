using System;

namespace DesignPatterns.Strategy.Football
{
	/// <summary>
	/// Summary description for Guard.
	/// </summary>
	public class Guard : Player
	{
		public Guard()
		{
			pattern2Run = new PullingBlockPlay();
		}
	}
}

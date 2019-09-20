using System;

namespace DesignPatterns.Iterator.Menu
{
	/// <summary>
	/// Summary description for Iterator.
	/// </summary>
	public interface Iterator
	{
		bool HasNext();
		object Next();
	}
}

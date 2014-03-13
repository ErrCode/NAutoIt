
using System;
using System.Runtime.InteropServices;
namespace nautoit
{
	/// <summary>
	/// Thown when AutoIt meets error condition
	/// </summary>
	[Serializable]
	public class AutoItException:ExternalException
	{
		public AutoItException(string message,int errorCode):base(message,errorCode)
		{
			
		}
	}
}

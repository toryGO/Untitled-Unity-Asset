using System;
using System.Threading.Tasks;

namespace UntitledAsset
{ 
	/// <summary>Represents a class for managing timeouts and executing actions after a timer expires.</summary>
	public class UnWaitToDo 
	{ 
		private static bool isTimeout = false;

		/// <summary>Starts a timer with the specified cooldown duration and executes an action after the timer expires.</summary>>
		/// <param name="cooldown">The duration of the timer in milliseconds.</param>
		/// <param name="doAfterTimer">The Action to execute after the timer expires (uses Expression lambda or Statement lambda).</param>
		internal static async Task StartUnWaitToDoFunc(int cooldown, Action doAfterTimer) 
		{ 
			isTimeout = false; 
			await Task.Delay(cooldown); 
			isTimeout = true; 
			doAfterTimer?.Invoke();
		}
    
		/// <summary>Checks if the timer has expired.</summary>>
		/// <returns>True if the timer has expired; otherwise, false.</returns>
		private static bool IsTimeout() 
		{
			return isTimeout;
		}
	}
}



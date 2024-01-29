using Random = System.Random;

namespace UntitledAsset
{
	/// <summary>
	/// Represents a class for shuffle array.
	/// </summary>
	public class UnRandom
	{
		// The static Random object for generating random numbers.
		static Random random = new Random();
		
		///  <summary>A generic method to shuffle an array of any type.</summary>
		/// <param name="array">Your array to shuffle</param>
		/// <typeparam name="T">Type of your array</typeparam>>
		internal void ShuffleArrays<T>(T[] array) 
		{
			int arrayLength = array.Length;
			for (int i = arrayLength - 1; i > 0; i--)
			{
				// Generate a random index between 0 and i (inclusive).
				int randomIndex = random.Next(i + 1);
				
				// Swap the elements at i and the random index.
				(array[i], array[randomIndex]) = (array[randomIndex], array[i]);
			}
		}
	}
}
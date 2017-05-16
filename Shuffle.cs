using UnityEngine;
using System.Collections;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Deck mydeck = new Deck();
			foreach (Card c in mydeck.Cards)
			{
				//.WriteLine(c);
			}
			//Console.WriteLine("How Many Times Do You Want To Shuffle?");
		}
	}
}

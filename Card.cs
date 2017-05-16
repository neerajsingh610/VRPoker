using UnityEngine;
using System.Collections;

namespace ConsoleApplication1
{
	class Card
	{
		private Suits suit;

		private string cardvalue;


		public Card()
		{
		}
		public Card(Suits suit2, string cardvalue2)
		{
			suit = suit2;
			cardvalue = cardvalue2;
		}
		public override string ToString()
		{
			return string.Format("{0} of {1}", cardvalue, suit);
		}
		public string getValue(){
			return cardvalue;
		}
	}
}

using System;
namespace tic_tac_toe
{

	public class Spieler
    {
		public string name { get; set; }
		public char buchstabe { get; set; } // x | o
		public string type { get; set; } // humen | bot

		private Random Random;

        public Spieler(string name, char buchstabe, string type)
		{
			this.name = name;
			this.buchstabe = buchstabe;
			this.type = type;
			this.Random = new Random();
		}

        public int position(char[] availablePosition)
		{
            var random = this.Random.Next(1, availablePosition.Length-1);
			var choice = availablePosition[random];
			return int.Parse(choice.ToString());
		}
    }
}


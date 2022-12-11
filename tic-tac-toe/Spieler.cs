using System;
namespace tic_tac_toe
{

	public class Spieler
    {
		public string name { get; set; }
		public char buchstabe { get; set; } // x | o
		public string type { get; set; } // humen | bot

        public Spieler(string name, char buchstabe, string type)
		{
			this.name = name;
			this.buchstabe = buchstabe;
			this.type = type;
		}

        public string position(string[] availablePosition)
		{
			return "";
		}
    }
}


using System;
namespace tic_tac_toe
{
	public class GameManger
	{
        static int player = 1;
        static int choice;
        static int flag = 0;

        public Tisch _tisch;
        public Spieler? _user;
        public Spieler _bot;


        public GameManger()
		{
			this._tisch = new Tisch();
            this._bot = new Spieler("Bot", 'O', "bot");
		}

		public void start(){
            Console.WriteLine("Schreib deine Name!");
            var _usrName = Console.ReadLine();
            this._user = new Spieler(_usrName?? "User", 'X', "user");

            do
            {
                Console.Clear();
                if (player % 2 == 0)
                {
                    Console.WriteLine("{0} ist dran",this._bot.name); // Bot
                }
                else
                {
                    Console.WriteLine("{0} ist dran", this._user.name); // User
                }

                Console.WriteLine("\n");
                this._tisch.printTisch();

                try
                {
                    if(player % 2 == 1)
                    {
                        choice = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        choice = this._bot.position(this._tisch.availablePosition());
                    }
                }
                catch
                {
                    Console.WriteLine("Es müssen nur Zahlen eingegeben werden!");
                    Console.WriteLine("Bitte warte 2 Sekunden Board wird wieder geladen.....");
                    Thread.Sleep(2000);
                }
                
                if (this._tisch.checkIsAvailablePosition(choice))
                {
                    if (player % 2 == 0)
                    {
                        this._tisch.positions[choice] = this._bot.buchstabe;
                        player++;
                    }
                    else
                    {
                        this._tisch.positions[choice] = this._user.buchstabe;
                        player++;
                    }
                }
                else
                {
                    if(choice <= 9)
                    {
                        Console.WriteLine("Entschuldigung, die Zeile {0} ist bereits mit {1} markiert",
                            choice, this._tisch.positions[choice]);
                    }
                    else
                    {
                        Console.WriteLine("Die Nummer existiert nicht!");
                    }
                    Console.WriteLine("Bitte warte 2 Sekunden Board wird wieder geladen.....");
                    Thread.Sleep(2000);
                }
                flag = this._tisch.checkWin();
            }
            while (flag != 1 && flag != -1);

            Console.Clear();
            this._tisch.printTisch();

            if (flag == 1)
            {
                if((player % 2) + 1 == 1)
                {
                    Console.WriteLine("{0} hat gewonnen", this._user.name);
                }
                else
                {
                    Console.WriteLine("{0} hat gewonnen", this._bot.name);
                }
                
            }
            else
            {
                Console.WriteLine("Zeichnen");
            }
            Console.ReadLine();
        }
	}
}


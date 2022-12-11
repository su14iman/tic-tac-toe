using System;
namespace tic_tac_toe
{
	public class Tisch
	{
		public char[] positions = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

		public int checkWin(){
            if (this.positions[1] == this.positions[2] 
				&& this.positions[2] == this.positions[3])
            {
                return 1;
            }
            else if (this.positions[4] == this.positions[5] 
				&& this.positions[5] == this.positions[6])
            {
                return 1;
            }
            else if (this.positions[6] == this.positions[7] 
				&& this.positions[7] == this.positions[8])
            {
                return 1;
            }
            else if (this.positions[1] == this.positions[4] 
				&& this.positions[4] == this.positions[7])
            {
                return 1;
            }
            else if (this.positions[2] == this.positions[5] 
				&& this.positions[5] == this.positions[8])
            {
                return 1;
            }
            else if (this.positions[3] == this.positions[6] 
				&& this.positions[6] == this.positions[9])
            {
                return 1;
            }
            else if (this.positions[1] == this.positions[5] 
				&& this.positions[5] == this.positions[9])
            {
                return 1;
            }
            else if (this.positions[3] == this.positions[5] 
				&& this.positions[5] == this.positions[7])
            {
                return 1;
            }
            else if (this.positions[1] != '1' 
				&& this.positions[2] != '2' && this.positions[3] != '3' 
				&& this.positions[4] != '4' && this.positions[5] != '5' 
				&& this.positions[6] != '6' && this.positions[7] != '7' 
				&& this.positions[8] != '8' && this.positions[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
		}

		public char[] availablePosition(){
            return this.positions.ToList()
                .FindAll(x => x != 'X' && x != 'O' && x != '0')
                .ToArray();
        }

		public bool checkIsAvailablePosition(int positionIndex){
            if(positionIndex <= 9)
            {
                var value = this.positions[positionIndex];
                if (value != 'X' && value != 'O') return true;
            }
            return false;
		}

		public void printTisch(){
			Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", this.positions[1], this.positions[2], this.positions[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", this.positions[4], this.positions[5], this.positions[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", this.positions[7], this.positions[8], this.positions[9]);
            Console.WriteLine("     |     |      ");
        }

	}
}


namespace Tic_Tac_Toe_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] vB = new string[3, 3]; //visual Board
            int[,] iB = new int[3, 3]; //visual Board

            Board board = new Board();
            WinChecker checkWinner = new WinChecker();
            board.Reset();
            board.PrintBoard();
            board.PrintChoices();
            
        }
    }
}

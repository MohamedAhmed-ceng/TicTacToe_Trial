/*10.Modify the tic-tac-toe game from the previous set of exercises. Now, instead of asking the user to
provide the whole state of the game at once, the user should place each symbol one move at a time
– just like in a normal tic-tac-toe game – X and O in turns. For now, you don’t have to check if
anyone has won – just write “Game over!” when the board is filled. Just remember to prevent the
user from making an illegal move!*/

using System;
using System.Threading;
namespace Tic_Tac_Toe_Trial

{
    class TicTacToe_Trial

    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int endGameCondidition = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tic-tac-toe! \n");
            do
            {
                Board();
                try
                {
                    Console.WriteLine("");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    if (arr[choice] != 'X' && arr[choice] != 'O')
                    {
                        if (player % 2 == 0)
                        {
                            arr[choice] = 'O';
                            Console.WriteLine($"O's move > {choice} \n");
                            player++;
                        }
                        else
                        {
                            arr[choice] = 'X';
                            Console.WriteLine($"X's move > {choice} \n");
                            player++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not allowed! The square {0} is already reserved for {1}", choice, arr[choice]);
                        Console.WriteLine("\n");
                    }
                    endGameCondidition = CheckBoard();
                }
                catch
                {
                    Console.WriteLine("Please insert a valid number between 1 and 9");
                    Console.WriteLine("\n");
                }
                finally
                {
                    CheckBoard();
                }
            }
            while (endGameCondidition ==0);

            Board();

            if (endGameCondidition == 1)
            {
                Console.WriteLine("Game Over!");
            }
            Console.ReadLine();
        }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        private static int CheckBoard()
        {
            if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' &&
                arr[4] != '4' && arr[5] != '5' && arr[6] != '6' &&
                arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return 1;
            }
            else
            {
                return 0;
            }   
        }       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard_round_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;


            Console.WriteLine("Enter the size of the Chessboard");
            string userLines = Console.ReadLine();


            if (int.TryParse(userLines, out int boardSize))

                //Loop through the rows
                for (int row = 0; row < boardSize; row++)
                {
                    //loop through the cols
                    for (int col = 0; col < boardSize; col++)
                    //Alternate between "♫" and "♥"
                    {
                        if ((row + col) % 2 == 0)
                        {
                            Console.Write("♫");
                        }
                        else
                        {
                            Console.Write("♥");
                        }
                    }
                    //NEXT LINE after each row
                    Console.WriteLine();
              }
        }
    }
}

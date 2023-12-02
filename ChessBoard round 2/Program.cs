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

                
            Console.WriteLine("Please select a number");
            string userLines = Console.ReadLine();
            int.TryParse(userLines, out int userBoard);

            for (int col = 0; col < userBoard; col++) 
            {
                Console.WriteLine("®");
                for (int row = 0; row < userBoard; row++ )
                {
                    Console.WriteLine("Δ");
                }
            }

                Console.WriteLine("Δ");
            Console.WriteLine("Hello!");
             
            
        }
    }
}

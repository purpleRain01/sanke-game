using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetWindowSize(80, 25);
            int top = 38, left = 12;
            Console.SetCursorPosition(top, left);
            Console.WriteLine("*");
            Random r1 = new Random();
            
          
            int[] position = new int[] { 38, 12, r1.Next(0,20), 1};


            try
            {
                Snake snake = new Snake();
                bool result=snake.UpdatePos(position);

            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("game over");
            }
              

          
           
            for(int i=0;i<4;i++)
            {
                Console.Clear();
                Console.SetCursorPosition(15, 15);
                System.Threading.Thread.Sleep(100);
                Console.WriteLine("Game  over");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                System.Threading.Thread.Sleep(100);
            }
            Console.ReadLine();
        }


        public static void BonusGen()
        {

        }

    }
}

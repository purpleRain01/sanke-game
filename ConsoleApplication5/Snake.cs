using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Snake
    {

        public bool UpdatePos(int[] pos)
        {
            char direction = 'k';
            int t = 100;
            while (pos[1] > 0 && pos[1] < 24 && pos[0] > 0 && pos[0] < 79)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        direction = 'U';
                        
                        pos[1] -= 1;
                    }
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        direction = 'D';
                       
                        pos[1] += 1;   
                    }
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        direction = 'L';
                       
                        pos[0] -= 1; 
                    }
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        direction = 'R';
                      
                        pos[1] += 1;
                    }
                }


                else
                {

                }
                switch (direction)
                {
                    case 'R':
                        pos[0] += 1;
                        t = 50;
                        break;
                    case 'L':
                        pos[0] -= 1;
                        t = 50;
                        break;
                    case 'D':
                        pos[1] += 1;
                        t = 100;
                        break;
                    case 'U':
                        pos[1] -= 1;
                        t = 100;
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.SetCursorPosition(pos[0], pos[1]);
                for(int i = 0; i < pos[3]; i++)
                {
                    Console.Write("+");
                }
               
                bonus(ref pos);
                Console.SetCursorPosition(pos[2], pos[2]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write('#');
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(0, 0);
                Console.Write("score:" + pos[3]);
                System.Threading.Thread.Sleep(t);
            }
            return false;
        }


        public void bonus(ref int[] pos)
        {
            if (pos[0] == pos[2] && pos[1] == pos[2])
            {
                pos[3] += 1;
                Random random = new Random();
                int number = random.Next(0, 10 );
                pos[2] = number; 
            }
       
        }
    }
}

using System;

namespace Jogo_da_velha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            xxx
            xxx
            xxx
            */
            /*variaveis*/
            string[] a=new string[] {"x","x","x"};
            string[] b=new string[] { "x", "x"};
            //criar um loop do jogo
            while (true)
            {
                //coluna
                for(int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i]);
                    
                    for (int j=0; j < b.Length; j++)
                    {
                        Console.Write("|"+b[j]);
                    }
                    
                    for (int k = 0; k < 1; k++)
                    {
                        Console.WriteLine("");
                        for (int l = 0; l < 5; l++)
                        {
                            
                            Console.Write("_");
                        }
                    }
                    Console.WriteLine();
                }
                /*
                //Mexer o cursor
                while (!Console.KeyAvailable)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (Console.CursorTop>0)
                            {
                                Console.CursorTop--;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (Console.CursorTop > -1)
                            {
                                Console.CursorTop++;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (Console.CursorLeft > -1)
                            {
                                Console.CursorLeft++;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (Console.CursorLeft > 0)
                            {
                                Console.CursorLeft--;
                            }
                            break;
                        case ConsoleKey.Backspace:
                            
                    }
                }*/
                break;
            }
                
            //criar matriz tridimensional
        }
    }
}

using System;

namespace con_or_pars
{
    class Program
    {
        static void Main(string[] args)
        {
            //A part
            for (int i = 1; i <= 9; i++)
            {
               
                for (int x = 0; i > x; x++)
                {
                    if (x == 1 & i == 3)
                    {
                        Console.Write("  ");
                        continue;                        
                    }
                    if (x == 1 & i == 4)
                    {
                        Console.Write("  ");
                        continue;
                    }



                    Console.Write(x+ " ");                  
                }
                for (int x = i; x <9; x++)
                {
                    Console.Write("  ");                  
                }
                for (int a = i; a <= 9; a++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");              
            }
            //C part
            for (int i = 1; i <= 9; i++)
            {
                for (int z = 9; i < z; z--)
                {
                    Console.Write("  ");
                }
                for (int x = 0; i > x; x++)
                {
                    Console.Write("*" + " ");
                }
                for (int p = 1; p<i; p++)
                {
                    Console.Write("  ");
                }
                for (int y = i; y <=9 ; y++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine("");
            }            
        }
    }
}

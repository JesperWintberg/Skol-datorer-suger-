using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar 4 Arrays för dom 4 olika delarna i en kortlek
            int[] hearts = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] clubs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] diamonds = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] spades = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //Start av spel 
            Console.WriteLine("Hej och välkommen till detta Black jack spel");
            Console.WriteLine("Om du vill börja spelet skriv in ett Y om du vill avsluta programet skriv ett N.");
            string start =Console.ReadLine();
            start.ToLower();

            //skapar random variabel 
            Random kort = new Random();


            //Start frågor innnan spelet börjar          
             for (int i = 0; i <1; i++)
             {
                if (start == "y")
                {
                    Console.WriteLine("Startar");
                }

                else if(start == "n")
                {
                    Console.WriteLine("stänger av program");
                    break;
                }

                else
                {
                    Console.WriteLine("Error");
                    break;
                }
             }

        }
    }
}


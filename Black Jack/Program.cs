using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar 2 Arrays,
            int[] value = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] suits = { "Hjärter", "Ruter", "Klöver", "Spader" };

            //skapar random variabel 
            Random Player = new Random();
            Random PC = new Random();

            
            int rndmvalue = value[Player.Next(0, 11)];
            string rndmsuit = suits[Player.Next(0,4)];
           
            int rndmvalue2=value[Player.Next(0,11)]; 
            string rndmsuit2 = suits[Player.Next(0,4)]; 

            int rndmvaluepc = value[PC.Next(0,11)];
            string rndmsuitpc = suits[PC.Next(0,4)];
            
            int rndmvaluepc2 = value[PC.Next(0,11)]; 

            //Start av spel 
            Console.WriteLine("Hej och välkommen till detta Black jack spel");
            Console.WriteLine("Om du vill börja spelet skriv in ett Y om du vill avsluta programet skriv ett N.");
            string start =Console.ReadLine();
            start.ToLower();


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

            for(int k = 0; k <1; k++)
            {
                Console.WriteLine("Nu kommer du få två kort");
                Console.WriteLine($"Du fick en {rndmsuit} {rndmvalue} och en {rndmsuit2} {rndmvalue2}");
                Console.WriteLine($"Du har nu {rndmvalue + rndmvalue2} poäng");
                Console.WriteLine($"Datorn har {rndmvaluepc + rndmvaluepc2} poäng");
                Console.WriteLine("Vill du dra ett nytt kort (y/n)");
                string val1 = Console.ReadLine();               

                int g = rndmvalue + rndmvalue2;
                int l = rndmvaluepc + rndmvaluepc2;

                //skapr ny random variabel för "runda 2"
                int rdmvalue3 = value[Player.Next(0, 11)];
                string rndmsuit3= suits[PC.Next(0, 4)];

                if (val1 == "y")
                {
                    Console.WriteLine($"Du drog ett {rndmsuit3} {rdmvalue3}");
                    Console.WriteLine($"Du har ny {g + rdmvalue3} poäng");
                    Console.WriteLine($"Datorn har {l} poäng");
                }

                else if (val1 == "n")
                {
                    Console.WriteLine($"Du har fotfarande {g} poäng");
                    Console.WriteLine($"Datorn drog en {rndmsuit3} {rdmvalue3}");
                    Console.WriteLine($"Datorn fick {l + rdmvalue3} poäng");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}


using System;
using System.Collections.Concurrent;

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


            for(int k = 0; k <1; k++)
            {
                //Runda 1
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
                    //Runda 2 "Väg 1" 
                    Console.WriteLine($"Du drog ett {rndmsuit3} {rdmvalue3}");
                    Console.WriteLine($"Du har ny {g + rdmvalue3} poäng");
                    Console.WriteLine($"Datorn har {l} poäng");
                    Console.WriteLine("Vill du dra ett nytt kort (y/n)");
                    string val2 = Console.ReadLine();   

                    int u = g + rdmvalue3;
                    
                    
                    if (g > 21)
                    {
                        Console.WriteLine("Datorn har vunnit");
                    }

                    if(val2 == "y")
                    {
                        Console.WriteLine();
                    }
                }

                else if (val1 == "n")
                {
                    //Runda 2 "Väg 2,Slut"
                    Console.WriteLine($"Du har fotfarande {g} poäng");
                    Console.WriteLine($"Datorn drog en {rndmsuit3} {rdmvalue3}");
                    Console.WriteLine($"Datorn fick {l + rdmvalue3} poäng");

                    int e = l + rdmvalue3;

                    if (e > 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Du har vunnit");
                        break;
                    }
                    if (e > g)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Datorn vann du förlorade");
                        break;
                    }
                    else if (e < g)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Du har Vunnit");
                        break;
                    }

                }
            }
        }
    }
}


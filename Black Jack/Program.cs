using System;
using System.Net.Http.Headers;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] suits = { "Klöver", "Spader", "Knäckt", "Hjärter" };

            Random random = new Random();

            bool sant = true;
            bool spelregler = false;
            bool avslutning = false;

            int rndmvalue = number[random.Next(0, 11)];
            int rndmvalue2 = number[random.Next(0, 11)];

            string rndmsuits = suits[random.Next(0, 4)];
            string rndmsuits2 = suits[random.Next(0, 4)];

            Console.WriteLine("Välkommen till Black jack");
            Console.WriteLine("1. Spela Black Jack");
            Console.WriteLine("2. See förra vinnaren");
            Console.WriteLine("3. Spelets regler");
            Console.WriteLine("4. Stänga av programet");
            Console.WriteLine("Skriv här: ");
            string start = Console.ReadLine();
            int start2 = int.Parse(start);

            switch (start2)
            {
                case 1:
                    sant = true;
                    break;
                case 2:
                    break;
                case 3:
                    spelregler = true;
                    break;
                case 4:
                    avslutning = true;

            }
            while (avslutning = true)
            {
                Console.WriteLine("Tack för du har spelat");
                Console.WriteLine("Ha en bra dag");
            }


            while (spelregler = true)
            {
                Console.WriteLine("I Black Jack så är ditt mål att nå 21 poäng eller så nära du bara kan.");
                Console.WriteLine("Du får inte komma över 21 poäng för du förlorar du");
                Console.WriteLine("Du kommer börja dra kort när du känner dig klar så kommer datorn att dra sinna kort");
                Console.WriteLine("Lycka till");
                Console.WriteLine("Vill du starta spelet (y/n)");
                string val4 = Console.ReadLine();

                if (val4 == "y")
                {
                    sant = true;
                }
                else if(val4 == "n")
                {
                    avslutning=true;    
                }

                break;
            }


            Console.WriteLine($"Dina startkort kommer att vara {rndmsuits} {rndmvalue} och {rndmsuits2} {rndmvalue2}");
            Console.WriteLine($"Du kommer nu att ha {rndmvalue + rndmvalue2} poäng");
            Console.WriteLine("Vill du ta ett nytt kort (y/n)");
            string val = Console.ReadLine();
            val.ToLower();

            if (val == "y")
            {
                sant = true;
            }

            if (val == "n")
            {
                sant = false;
            }

            int startplayer = rndmvalue + rndmvalue2;
            int endplayer = startplayer;

            while (sant)
            {
                int rndmvalue5 = number[random.Next(0, 11)];
                string rndmsuits5 = suits[random.Next(0, 4)];
               
                if (endplayer == startplayer)
                {
                    endplayer = startplayer + rndmvalue5;
                }

                else
                {
                    endplayer = endplayer + rndmvalue5;    
                }


                if (endplayer > 21)
                {
                    Console.WriteLine("Du har förlorat");
                    Console.WriteLine($"Du fick {endplayer} poäng");
                    break;
                }

                if (endplayer == 21)
                {
                    Console.WriteLine("Grattis du har vunnit");
                    Console.WriteLine($"Du fick {endplayer} poäng");
                    Console.Write("Skriv in ditt namn: ");
                    string namn = Console.ReadLine();
                    break;
                }

                Console.WriteLine($"Du fick ett {rndmsuits5} {rndmvalue5}");
                Console.WriteLine($"Du har nu {endplayer} poäng");
                Console.WriteLine("Vill du dra ett nytt kort? (y/n)");
                string val2 = Console.ReadLine();
                val2.ToLower();

                if (val2 == "n")
                {
                    sant = false;
                }
            }

            while (!sant)
            {
                int rndmvalue3=number[random.Next(0, 11)];
                int rndmvalue4 = number[random.Next(0, 11)];

                int rndmvalue5 = number[random.Next(0, 11)];

                int PCstart = rndmvalue3 + rndmvalue4;
                int PCend = rndmvalue5 + PCstart;

                if (PCend >= 17)
                {
                    if (endplayer > PCend)
                    {
                        Console.WriteLine("Grattis du vann");
                        Console.WriteLine($"Datorn fick {PCend} poäng");
                        Console.WriteLine($"Du fick {endplayer} poäng");
                        Console.Write("Skriv in ditt namn: ");
                        string namn = Console.ReadLine();
                        break;
                    }

                    if (PCend > endplayer)
                    {
                        Console.WriteLine("Datron vann");
                        Console.WriteLine($"Datorn fick {PCend} poäng");
                        Console.WriteLine($"Du fick {endplayer} poäng");
                        break;
                    }

                    if (PCend == 21)
                    {
                        Console.WriteLine("Datron vann");
                        Console.WriteLine($"Datorn fick {PCend} poäng");
                        Console.WriteLine($"Du fick {endplayer} poäng");
                        break;
                    }

                    if(PCend > 21)
                    {
                        Console.WriteLine("Grattis du vann");
                        Console.WriteLine($"Datorn fick {PCend} poäng");
                        Console.WriteLine($"Du fick {endplayer} poäng");
                        Console.Write("Skriv in ditt namn: ");
                        string namn = Console.ReadLine();
                    }
                }

            }

        }
    }
}




using System;
using System.Runtime.InteropServices;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till nummergissings spelet");
            Console.WriteLine();
           

            
        }

        public static void CheckGuessEasy()
        {
            Random r = new Random();
            int rättnummer = r.Next(1, 20);
            bool win = false;
            int maxGuess = 5;
            int count = 0;


            do

            {
                if (count == maxGuess)
                {
                    Console.WriteLine("Slut på gissningar.....");

                    break;
                }


                Console.WriteLine("Gissa ett nummer mellan 1 och 20 ");



                int guess = int.Parse(Console.ReadLine());


                if (guess > rättnummer)

                {

                    Console.WriteLine("För högt! Gissa lägre....");
                    count++;


                }

                else if (guess < rättnummer)
                {

                    Console.WriteLine("För lågt!  Gisssa högre");
                    count++;

                }

                else if (guess == rättnummer)
                {
                    Console.WriteLine("DU VANN!!!! ");
                    count++;


                    win = true;

                    Console.WriteLine("Vill du spela igen? ja eller nej"); //Försök komma på ett sätt att starta om spelet 
                    string UserDeciPlay = Console.ReadLine().ToUpper();    //Jag vill att användaren skriver ja så kommer vi tillbka till 
                                                                           // svårighetsgrad väljaren och om nej skrivs " Tack för att du spelade ut"
                    if (UserDeciPlay.ToLower() == "ja")



                    {

                        Console.Clear();

                        ChoseDif();





                    }
                    else
                    {
                        Console.WriteLine("Tack för att du spelade");
                    }




                }




            } while (win == false);

            Console.ReadKey();





        }

        public static void CheckGuessMedium()
        {
            Random r = new Random();
            int rättnummer = r.Next(1, 50);
            bool win = false;
            int maxGuess = 10;
            int count = 0;


            do

            {
                if (count == maxGuess)
                {
                    Console.WriteLine("Slut på gissningar.....");

                    break;
                }


                Console.WriteLine("Gissa ett nummer mellan 1 och 50 du har " + maxGuess + " försök på dig");



                int guess = int.Parse(Console.ReadLine());


                if (guess > rättnummer)

                {

                    Console.WriteLine("För högt! Gissa lägre....");
                    count++;


                }

                else if (guess < rättnummer)
                {

                    Console.WriteLine("För lågt!  Gisssa högre");
                    count++;

                }

                else if (guess == rättnummer)
                {
                    Console.WriteLine("DU VANN!!!!");
                    count++;


                    win = true;
                    Console.WriteLine("Vill du spela igen? ja eller nej"); //Försök komma på ett sätt att starta om spelet 
                    string UserDeciPlay = Console.ReadLine().ToUpper();    //Jag vill att användaren skriver ja så kommer vi tillbka till 
                                                                           // svårighetsgrad väljaren och om nej skrivs " Tack för att du spelade ut"
                    if (UserDeciPlay.ToLower() == "ja")



                    {

                        Console.Clear();

                        ChoseDif();





                    }
                    else
                    {
                        Console.WriteLine("Tack för att du spelade");
                    }


                }




            } while (win == false);

            Console.ReadKey();




        }

        public static void CheckGuessHard()
        {
            Random r = new Random();
            int rättnummer = r.Next(1, 100);
            bool win = false;
            int maxGuess = 15;
            int count = 0;


            do

            {
                if (count == maxGuess)
                {
                    Console.WriteLine("Slut på gissningar.....");

                    break;
                }


                Console.WriteLine("Gissa ett nummer mellan 1 och 100 du har " + maxGuess + " Försök på dig");



                int guess = int.Parse(Console.ReadLine());


                if (guess > rättnummer)

                {

                    Console.WriteLine("För högt! Gissa lägre....");
                    count++;


                }

                else if (guess < rättnummer)
                {

                    Console.WriteLine("För lågt!  Gisssa högre");
                    count++;

                }

                else if (guess == rättnummer)
                {
                    Console.WriteLine("DU VANN!!!! ");
                    count++;

                    win = true;
                    Console.WriteLine("Vill du spela igen? ja eller nej"); //Försök komma på ett sätt att starta om spelet 
                    string UserDeciPlay = Console.ReadLine().ToUpper();    //Jag vill att användaren skriver ja så kommer vi tillbka till 
                                                                           // svårighetsgrad väljaren och om nej skrivs " Tack för att du spelade ut"
                    if (UserDeciPlay.ToLower() == "ja")



                    {

                        Console.Clear();

                        ChoseDif();





                    }
                    else
                    {
                        Console.WriteLine("Tack för att du spelade");
                    }

                }

            } while (win == false);

            Console.ReadKey();
        }



    }
}

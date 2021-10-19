using System;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            string menyval = "";
            while (menyval != "2")
            {
                Console.WriteLine("Välkommen till Gissa talet");
                Console.WriteLine("1. spela");
                Console.WriteLine("2. quit");
                Console.WriteLine();
                menyval = Console.ReadLine();


                switch (menyval)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("gissa ett tal från 1-10");
                        
                        Random slump = new Random();
                        int tal = slump.Next(1, 11);
                        Console.WriteLine();
                        int answer = int.Parse(Console.ReadLine());
                        int gisning = 1;
                       

                        while (answer != tal)
                        {
                            if (answer >= tal)
                            {
                                Console.WriteLine();
                                Console.WriteLine("fel, talet är för hög");
                                Console.WriteLine();
      

                            }
                             else if (answer <= tal)
                            {
                                Console.WriteLine();
                                Console.WriteLine("fel, talet är för låg");
                                Console.WriteLine();
                                
                            }
                            
                            answer = int.Parse(Console.ReadLine());
                            gisning++;

                        }
                        Console.WriteLine();
                        Console.WriteLine($"svar:{tal}"); 
                        Console.WriteLine();
                        Console.WriteLine($"rätt, du har svarat rätt i {gisning} gisningen/gisningar");
                        Console.WriteLine();
                        Console.WriteLine("Tryck 2 för att avsluta");
                        Console.WriteLine("tryck 1 för att tillbaka till meny");
                        Console.WriteLine();
                        menyval = Console.ReadLine();
                        Console.WriteLine();
                        break;


                    case "2":
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("fel val");
                        Console.WriteLine("försök igen");
                        Console.WriteLine();
                        break;





                }
            }
        }

    }
}

using System;

namespace Random_Number_Generator_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new System.Random();
            int value = random.Next(0, 100);
            double value2 = random.NextDouble(); 

            var byteArray = new byte[256];
            random.NextBytes(byteArray);
            int a;
            string b;
            // Console.WriteLine(value); // Output of Value aka The Hidden Number
            
            int Tries = 1;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Guess Number Between 1 to 100");
            a = 0;
            int frequency = 3000;
            int duration = 800;
            while (a != value)
            {
                Console.ForegroundColor = ConsoleColor.White;
               
                    a = int.Parse(Console.ReadLine());
              
                   

                    if (a > value)
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Guess Lower");
                 
                    }
                    else if (a < value)
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Guess Higher");
                    
                    }

                    else if (a == value)
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bravo, you did it! Now get yourself a cookie and go outside.");
                    
                    Console.Beep(frequency, duration);



                    }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Tries:" + Tries++);
           
               
                

                
            }

        }
    }
}

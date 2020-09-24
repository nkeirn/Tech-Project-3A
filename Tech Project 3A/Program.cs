using System;

namespace Tech_Project_3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            Console.ReadLine();
            

            try
            {
                string input = Console.ReadLine();
                Console.WriteLine("hello" + input);
                
                
            }
            catch
            {
                Console.WriteLine("Please enter your name again.");
                Console.WriteLine("Press any key to exit the program and try again...");

            }
        }
    }
}

using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)

        {

            double length_1;
            double width_1;
            

                string input10 = null;

                do
                {
                    Console.WriteLine("Hello, Please enter the length:");
                    length_1 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    Console.WriteLine("Please enter the width:");
                    width_1 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    Console.WriteLine("The area is  " + (length_1 * width_1));

                    Console.WriteLine("");

                    Console.WriteLine("The Perimeter is " + (2 * length_1 + 2 * width_1));

                    Console.WriteLine("");

                    Console.WriteLine("Would you like to continue? (Yes/No)");

                    input10 = Console.ReadLine();



                } while (input10 != "No") ;
                
                   

                

                
           

          
        }
    }
}

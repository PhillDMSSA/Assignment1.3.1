using System;
using System.Runtime.InteropServices;

namespace Assignment1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.3.1

           do
            {

                Console.WriteLine("We are going to calcualte the area of a triangle, square, or rectangle.");
                Console.WriteLine("Select the one you wish to calcualte: \n\t 1) Triangle \n\t 2) Sqaure \n\t 3) Rectangle ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        AreaOfTriangle();
                        break;
                    case 2:
                        AreaOfSquare();
                        break;
                    case 3:
                        AreaOfRectangle();
                        break;


                }

                Console.WriteLine("Do you want to select another shape? (Y/N): ");
                
            }
                while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine();

            Console.WriteLine("\t\t\t\t\tEnd of code. Thank you!");

        }

        //1.3.1

        


        static double AreaOfTriangle()
        {
            Console.Write("Enter the base of the triangle: ");
            double baseTri = Convert.ToDouble(Console.ReadLine());

           Console.Write("Enter the height of the triangle: ");
            double heightTri = Convert.ToDouble(Console.ReadLine());

            double areaTri = 0.5 * baseTri * heightTri;

            Console.WriteLine($"The area of the triangle is:  {areaTri}");

            return areaTri;
        }
        static double AreaOfSquare()
        {
            Console.WriteLine("Enter the lenth of the square: ");
            double lengthSqr = Convert.ToDouble(Console.ReadLine());

            double areaSqr = lengthSqr * lengthSqr;

            Console.WriteLine($"The area of the square is: {areaSqr}");

            return areaSqr;
        }
        static double AreaOfRectangle()
        {
            Console.WriteLine("Enter the length of the rectangle: ");
            double lengthRec = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            double widthRec = Convert.ToDouble(Console.ReadLine());

            double areaRec = widthRec * widthRec;

            Console.WriteLine($"The area of the rectangle is: {areaRec}");

            return areaRec;

        }

       
    }
       
       




    
}

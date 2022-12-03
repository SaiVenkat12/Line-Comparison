using System;
namespace Line
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values for first line: ");
            Console.WriteLine("Enter the Co-ordinates of x1,x2");

            Console.Write("x1: ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-ordinates of y1,y2");

            Console.Write("y1: ");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values for second line: ");
            Console.WriteLine("Enter the Co-ordinates of x3,x4");

            Console.Write("x3: ");
            double x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x4: ");
            double x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Co-ordinates of y3,y4");

            Console.Write("y3: ");
            double y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y4: ");
            double y4 = Convert.ToInt32(Console.ReadLine());

            double len1 = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            Console.WriteLine("The Lenth of Line 1 : " + len1);

            double Len2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("The Length of line 2 : " + Len2);

            if(len1 == Len2 )
            {
                Console.WriteLine("Line1 is equal to Line2");
            }
            else
            {
                Console.WriteLine("Line1 is not equal to Line2");
            }
        }
    }
}
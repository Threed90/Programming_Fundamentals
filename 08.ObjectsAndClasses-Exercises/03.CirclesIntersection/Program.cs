using System;
using System.Linq;

namespace _03.CirclesIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = ReadCircle();
            Circle circle2 = ReadCircle();

            if(Circle.isIntersect(circle1,circle2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static Circle ReadCircle()
        {
            double[] circleParameters = Console.ReadLine().Split().Select(double.Parse).ToArray();

            return new Circle(circleParameters[0], circleParameters[1], circleParameters[2]);
        }
    }
}

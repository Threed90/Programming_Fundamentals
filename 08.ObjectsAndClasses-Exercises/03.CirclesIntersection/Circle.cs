using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CirclesIntersection
{
    
    class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }

        public Circle(double x, double y, double radius)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }

        /// <summary>
        /// calculate, if two circles are intersected and return bool value.
        /// </summary>
        public static bool isIntersect(Circle firstCircle, Circle secondCircle)
        {
            double distance = Math.Sqrt(Math.Pow(firstCircle.X - secondCircle.X, 2) + Math.Pow(firstCircle.Y - secondCircle.Y, 2));
            double radiusConcat = firstCircle.Radius + secondCircle.Radius;
            if(radiusConcat>=distance)
            {
                return true;
            }
            return false;
        }
    }
}

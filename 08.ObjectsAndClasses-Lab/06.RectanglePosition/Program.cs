using System;
using System.Linq;

namespace _06.RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectagle1 = ReadRectangle();
            Rectangle rectagle2 = ReadRectangle();

            if(Rectangle.isInside(rectagle1,rectagle2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        private static Rectangle ReadRectangle()
        {
            int[] rectangle = Console.ReadLine().Split().Select(int.Parse).ToArray();

            return new Rectangle(rectangle[0], rectangle[1], rectangle[2], rectangle[3]);
        }
    }

    class Rectangle
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int X2
        {
            get
            {
                
                return Math.Abs(this.X1) + this.Width;
            }
        }
        public int Y2
        {
            get
            {
                return Math.Abs(Y1) + Height;
            }
        }
        

        public Rectangle(int x1, int y1, int width, int height)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.Width = width;
            this.Height = height;
        }

        
        public static bool isInside(Rectangle firstRect, Rectangle secondRect)
        {
            if(firstRect.X1>=secondRect.X1 && firstRect.Y1<=secondRect.Y1 && 
                firstRect.X2<=secondRect.X2 && firstRect.Y2<=secondRect.Y2)
            {
                return true;
            }
            return false;
        }

       
        
    }
}

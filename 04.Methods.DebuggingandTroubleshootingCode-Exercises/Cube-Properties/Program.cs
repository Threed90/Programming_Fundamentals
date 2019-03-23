using System;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameterForCalculation = Console.ReadLine();

            Console.WriteLine($"{GetCubeParameterForCalculation(cubeSide, parameterForCalculation):f2}");
        }
        /// <summary>
        /// Write a side's value of cube and type of parameters as string("area", "volume", 
        /// "face" - for face diagonal, "space" - for space diagonal) to calculate them.
        /// </summary>
        /// <returns></returns>
        static double GetCubeParameterForCalculation(double side, string parameterName)
        {
            double parameter = 0;
            if (parameterName.ToLower() == "area")
            {
                parameter = 6 * Math.Pow(side, 2);
                
            }
            else if(parameterName.ToLower() == "volume")
            {
                parameter = Math.Pow(side, 3);
                
            }
            else if (parameterName.ToLower() == "face")
            {
                parameter= Math.Sqrt(side * side + side * side);
                
            }
            else if(parameterName.ToLower() == "space")
            {
                parameter = side * Math.Sqrt(3);
                
            }
            return parameter;
        }
    }
}

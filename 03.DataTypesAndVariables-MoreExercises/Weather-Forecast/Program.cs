using System;

namespace Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberForPrediction = Console.ReadLine();

            bool isSunny = sbyte.TryParse(numberForPrediction, out sbyte sbyteNum);
            bool isCloudy = int.TryParse(numberForPrediction, out int intNum);
            bool isWindy = long.TryParse(numberForPrediction, out long longNum);
            
            if (isSunny)
            {
                Console.WriteLine("Sunny");
            }
            else if (isCloudy)
            {
                Console.WriteLine("Cloudy");
            }
            else if (isWindy)
            {
                Console.WriteLine("Windy");
            }
            else
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}

using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double doubleRoom = 0;
            double suit = 0;

            switch (mounth)
            {
                case "may":
                case "october":
                    studio = 50;
                    doubleRoom = 65;
                    suit = 75;
                    break;
                case "june":
                case "september":
                    studio = 60;
                    doubleRoom = 72;
                    suit = 82;
                    break;
                case "july":
                case "august":
                case "december":
                    studio = 68;
                    doubleRoom = 77;
                    suit = 89;
                    break;
            }

            if (nights > 7)
            {
                switch (mounth)
                {
                    case "may":
                        studio *= 0.95;
                        break;
                    case "october":
                        studio *= 0.95;
                        break;

                }
            }
            if (nights > 14)
            {
                switch (mounth)
                {
                    case "june":
                        doubleRoom *= 0.90;
                        break;
                    case "september":
                        doubleRoom *= 0.90;
                        break;
                    case "july":
                    case "august":
                    case "december":
                        suit *= 0.85;
                        break;
                }
            }
            if (nights > 7 && (mounth == "september" || mounth == "october"))
            {


                Console.WriteLine($"Studio: {studio * (nights-1):f2} lv.{Environment.NewLine}Double: {doubleRoom * nights:f2} lv.{Environment.NewLine}Suite: {suit * nights:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Studio: {studio * nights:f2} lv.{Environment.NewLine}Double: {doubleRoom * nights:f2} lv.{Environment.NewLine}Suite: {suit * nights:f2} lv.");

            }
        }
    }
}

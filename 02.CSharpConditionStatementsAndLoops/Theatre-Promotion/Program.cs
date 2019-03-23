using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            int TicketPrice = 0;

            if (((age >= 0 && age <= 18 || age > 64 && age <= 122) && typeOfDay == "weekday") || (typeOfDay == "holiday" && age > 18 && age <= 64))
            {
                TicketPrice = 12;
            }
            else if (age > 18 && age <= 64 && typeOfDay == "weekday")
            {
                TicketPrice = 18;
            }
            else if ((age >= 0 && age <= 18 || age > 64 && age <= 122) && typeOfDay== "weekend")
            {
                TicketPrice = 15;
            }
            else if(age > 18 && age <= 64 && typeOfDay == "weekend")
            {
                TicketPrice = 20;
            }
            else if(age >= 0 && age <= 18 && typeOfDay == "holiday")
            {
                TicketPrice = 5;
            }
            else if (age > 64 && age <= 122 && typeOfDay == "holiday")
            {
                TicketPrice = 10;
            }
            
            if (age >= 0 && age <= 122)
            {
                Console.WriteLine(TicketPrice+"$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}

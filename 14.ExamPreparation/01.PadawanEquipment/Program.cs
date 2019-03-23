using System;

namespace _01.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightSabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double sabersTotal = (Math.Ceiling(students + (students*0.1)))*lightSabersPrice;
            double robesTotal = students * robesPrice;
            double beltsTotal = (students - (students / 6)) * beltsPrice;

            double total = sabersTotal + robesTotal + beltsTotal;

            if(money>= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total-money:f2}lv more.");
            }
        }
    }
}

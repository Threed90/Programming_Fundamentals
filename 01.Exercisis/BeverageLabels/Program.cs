using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent100ml = int.Parse(Console.ReadLine());
            double sugarContent100ml = double.Parse(Console.ReadLine());

            double totalEnergy = ((double)energyContent100ml / 100) * volume;
            double totalSugar = ((double)sugarContent100ml / 100) * volume;




            Console.WriteLine($"{volume}ml {productName}:{Environment.NewLine}{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}

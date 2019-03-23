using System;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPicktures = int.Parse(Console.ReadLine());
            int filterTimeForOnePicture = int.Parse(Console.ReadLine());
            int percentageOfGoodPictures = int.Parse(Console.ReadLine());
            int uploadTimeforOnePicture = int.Parse(Console.ReadLine());

            long filterTime = numberOfPicktures * (long)filterTimeForOnePicture;
            long goodPictures = (long)Math.Ceiling(numberOfPicktures * (percentageOfGoodPictures / 100.00));
            long uploadTime = goodPictures * (long)uploadTimeforOnePicture;
            long totalTimeInSeconds = filterTime + uploadTime;

            //long seconds = totalTimeInSeconds % 60L;
            //long totalMinutes = totalTimeInSeconds / 60L;
            //long minutes = totalMinutes % 60L;
            //long totalHours = totalMinutes / 60L;
            //long hours = totalHours % 24L;
            //long totalDays = totalHours / 24L;

            TimeSpan time = TimeSpan.FromSeconds(totalTimeInSeconds);
            string neededTime = time.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(neededTime);

        }
    }
}

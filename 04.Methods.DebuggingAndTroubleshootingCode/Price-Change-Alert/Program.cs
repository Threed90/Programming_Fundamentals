using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());

        double threshold = double.Parse(Console.ReadLine());

        double firstPrice = double.Parse(Console.ReadLine());
        

        for (int i = 0; i < numberOfPrices-1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());

            double diffrenceInPercent = PercentDiffrence(firstPrice, currentPrice);
            bool isMajorPriceChange = isMajorChange(diffrenceInPercent, threshold);


            string priceMessage = GetPriceChanges(firstPrice, currentPrice, diffrenceInPercent, isMajorPriceChange);
            Console.WriteLine(priceMessage);

            firstPrice = currentPrice;
        }
    }

    static string GetPriceChanges(double firstPrice, double currentPrice, double diffrence, bool isMajorChange)
    {
        string priceMessage = "";
        if (diffrence == 0)
        {
            priceMessage = string.Format("NO CHANGE: {0}", firstPrice);
        }
        else if (!isMajorChange)
        {
            priceMessage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, currentPrice, diffrence*100);
        }
        else if (isMajorChange && diffrence>0)
        {
            priceMessage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice,currentPrice, diffrence*100);
        }
        else if (isMajorChange && diffrence<0)
        {
            priceMessage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, currentPrice, diffrence*100);
        }
        return priceMessage;
    }

    static bool isMajorChange(double percentValue, double threshold)
    {
        if (Math.Abs(percentValue) >= Math.Abs(threshold))
        {
            return true;
        }
        return false;
    }

    static double PercentDiffrence(double firstValue, double secondValue)
    {
        
        if (firstValue == 0)
        {
            double percentDiffrents = 0;
            return percentDiffrents;
        }
        else
        {
            return  ((secondValue - firstValue) / firstValue);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01.SnowBall
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowBallsNumber = int.Parse(Console.ReadLine());

            //decimal total = -1;
            //int snowBallSnow = 0;
            //int snowBallTime = 0;
            //int snowBallQuality = 0;

            List<Tuple<BigInteger, int, int, int>> allTokens = new List<Tuple<BigInteger, int, int, int>>();

            for (int i = 0; i < snowBallsNumber; i++)
            {
                int snowBallSnow1 = int.Parse(Console.ReadLine());
                int snowBallTime1 = int.Parse(Console.ReadLine());
                int snowBallQuality1 = int.Parse(Console.ReadLine());

                string result = GetResult(snowBallSnow1, snowBallTime1, snowBallQuality1);

                allTokens.Add(new Tuple<BigInteger, int, int, int>(BigInteger.Parse(result), snowBallSnow1, snowBallTime1, snowBallQuality1));
                
                //if (total < result)
                //{
                //    total = result;
                //    snowBallSnow = snowBallSnow1;
                //    snowBallTime = snowBallTime1;
                //    snowBallQuality = snowBallQuality1;
                //}
                //else if (total == result)
                //{
                //    total = result;
                //    snowBallQuality = Math.Max(snowBallQuality, snowBallQuality1);
                //}
            }

            Tuple<BigInteger, int, int, int> total = allTokens.OrderByDescending(x => x.Item1).First();

            Console.WriteLine($"{total.Item2} : {total.Item3} = {total.Item1} ({total.Item4})");
        }

        private static string GetResult(int snowBallSnow1, int snowBallTime1, int snowBallQuality1)
        {
            BigInteger snow = BigInteger.Pow(snowBallSnow1, snowBallQuality1);
            BigInteger time = BigInteger.Pow(snowBallTime1, snowBallQuality1);
            int counter = 0;

            StringBuilder result = new StringBuilder();

            result.Append(snow / time);


            BigInteger left = snow - time * (snow / time);
            result.Append(".");

            if (left == 0)
            {
                result.Append(0);

                return /*decimal.Parse(*/result.ToString().TrimEnd('0').TrimEnd('.');
            }
            else if (left > 0)
            {
                while (left > 0)
                {
                    left *= 10;
                    if (left / time > 0)
                    {
                        result.Append(left / time);
                        left -= time * (left / time);
                        counter++;
                        if (counter > 19)
                        {
                            break;
                        }
                    }
                    else if (left / time == 0)
                    {
                        result.Append(0);
                        continue;
                    }
                }
            }

            return /*decimal.Parse(*/result.ToString().TrimEnd('0').TrimEnd('.');
        }
    }
}

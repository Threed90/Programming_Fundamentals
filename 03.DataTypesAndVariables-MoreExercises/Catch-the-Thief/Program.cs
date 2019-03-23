using System;

namespace Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string thiefIdType = Console.ReadLine().ToLower();
            int numberOfIDs = int.Parse(Console.ReadLine());

            long thiefIdChecker = long.MinValue;

            for (int idCounter = 0; idCounter < numberOfIDs; idCounter++)
            {
                //long forEachID = long.Parse(Console.ReadLine());
                string forEachID = Console.ReadLine();

                bool isSbyte = sbyte.TryParse(forEachID, out sbyte sbyteNum);
                bool isInteger = int.TryParse(forEachID, out int intNum);
                bool isLong = long.TryParse(forEachID, out long longNum);
                if (isSbyte && thiefIdType == "sbyte") //(forEachID >= sbyte.MinValue && forEachID<= sbyte.MaxValue && thiefIdType == "sbyte" )
                {
                   if (sbyteNum> thiefIdChecker)
                    {
                        thiefIdChecker = sbyteNum;
                    }
                }
                else if (isInteger && thiefIdType == "int") //(forEachID>= int.MinValue && forEachID <= int.MaxValue && thiefIdType == "int")
                {
                    if (intNum > thiefIdChecker)
                    {
                        thiefIdChecker = intNum;
                    }
                }
                else if (isLong && thiefIdType == "long" ) //(thiefIdType == "long")
                {
                    if (longNum > thiefIdChecker)
                    {
                        thiefIdChecker = longNum;
                    }
                }
            }
            
                Console.WriteLine(thiefIdChecker);
            
        }
    }
}

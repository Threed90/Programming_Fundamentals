using System;

namespace Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoatSymbol = char.Parse(Console.ReadLine());
            char secondBoatSymbol = char.Parse(Console.ReadLine());
            int boatsMovements = int.Parse(Console.ReadLine());

            int firstBoatUpgrade = Convert.ToInt32(firstBoatSymbol);
            int secondBoatUpgrade = Convert.ToInt32(secondBoatSymbol);

            int firstBoatTotalMoves = 0;
            int secondBoatTotalMoves = 0;

            for (int movementsCounter = 1; movementsCounter <= boatsMovements; movementsCounter++)
            {
                if (firstBoatTotalMoves >= 50)
                {
                    Console.WriteLine(Convert.ToChar(firstBoatUpgrade));
                    return;
                }
                else if (secondBoatTotalMoves >= 50)
                {
                    Console.WriteLine((char)secondBoatUpgrade);
                    return;
                }

                string boatMove = Console.ReadLine();

                

                if (boatMove == "UPGRADE")
                {
                    firstBoatUpgrade += 3;
                    secondBoatUpgrade += 3;
                }
                else
                {
                    if (movementsCounter %2 == 0)
                    {
                        secondBoatTotalMoves += boatMove.Length;
                    }
                    else
                    {
                        firstBoatTotalMoves += boatMove.Length;
                    }
                }
            }
            if (firstBoatTotalMoves > secondBoatTotalMoves)
            {
                Console.WriteLine(Convert.ToChar(firstBoatUpgrade));
            }
            else if (secondBoatTotalMoves>firstBoatTotalMoves)
            {
                Console.WriteLine((char)secondBoatUpgrade);
            }
        }
    }
}

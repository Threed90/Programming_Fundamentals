using System;

namespace Mounth_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounthNumber = int.Parse(Console.ReadLine());

            string mounthName = string.Empty;

              switch (mounthNumber)
                {
                    case 1:
                        mounthName = "January";
                            break;
                    case 2:
                        mounthName = "February";
                            break;
                    case 3:
                        mounthName = "March";
                            break;
                    case 4:
                        mounthName = "April";
                            break;
                    case 5:
                        mounthName = "May";
                            break;
                    case 6:
                        mounthName = "June";
                            break;
                    case 7:
                        mounthName = "Jule";
                            break;
                    case 8:
                        mounthName = "August";
                            break;
                    case 9:
                        mounthName = "September";
                            break;
                    case 10:
                        mounthName = "October";
                            break;
                    case 11:
                        mounthName = "November";
                            break;
                    case 12:
                        mounthName = "December";
                            break;
                    default:
                    mounthName = "Error!";
                            break;
                }

                Console.WriteLine(mounthName);
            
            
        }
    }
}

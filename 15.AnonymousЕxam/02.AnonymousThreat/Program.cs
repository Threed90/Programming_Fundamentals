using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();
            string commandAll = Console.ReadLine();

            while (commandAll != "3:1")
            {
                string[] commandElements = commandAll.Split();

                if (commandElements[0] == "merge")
                {
                    int startIndex = GetIndex(int.Parse(commandElements[1]), elements.Count);
                    int endIndex = GetIndex(int.Parse(commandElements[2]), elements.Count);
                    StringBuilder holder = new StringBuilder();
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        holder.Append(elements[i]);
                    }
                    elements.RemoveRange(startIndex, endIndex - startIndex + 1);
                    elements.Insert(startIndex, holder.ToString());
                }
                else if (commandElements[0] == "divide")
                {
                    int index = int.Parse(commandElements[1]);
                    int parts = int.Parse(commandElements[2]);
                    string[] array = new string[parts];
                    int lenght = elements[index].Length / parts;

                    for (int i = 0; i < parts; i++)
                    {
                        if(i == parts-1)
                        {
                            array[i] = elements[index].Substring(i * lenght);
                        }
                        else
                        {
                            array[i] = elements[index].Substring(i * lenght, lenght);
                        }
                    }

                    elements.Remove(elements[index]);
                    elements.InsertRange(index, array);
                }

                commandAll = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }

        private static int GetIndex(int index, int count)
        {
            if (index < 0)
            {
                return 0;
            }
            else if (index >= count)
            {
                return count - 1;
            }
            return index;
        }
    }
}

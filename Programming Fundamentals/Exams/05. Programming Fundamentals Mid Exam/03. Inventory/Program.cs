using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] cmdArgs = Console.ReadLine().Split(" - ").ToArray();
            string command = cmdArgs[0];
            string item = cmdArgs[1];
            string[] itemsToCombine = cmdArgs[1].Split(":");
            string oldItem = itemsToCombine[0];
            while (command != "Craft!")
            {
                if (cmdArgs[0] == "Combine Items")
                {
                    for (int i = 0; i < items.Count; i++)
                    {


                        if (items[i].Contains(oldItem))
                        {
                            int index = items.IndexOf(oldItem);
                            items.Insert(index +1, itemsToCombine[1]);
                            break;
                        }
                    }
                }
               
                else
                {
                    if (command == "Collect")
                    {
                        items.Add(item);
                    }
                }
                for (int i = 0; i < items.Count; i++)
                {


                    if (items[i].Contains(item))
                    {
                        if (command == "Drop")
                        {
                            items.RemoveAt(i);
                        }
                        if (command == "Renew")
                        {
                            items.Remove(item);
                            items.Add(item);
                        }
                    }
                }
                cmdArgs = Console.ReadLine().Split(" - ").ToArray();
                if (cmdArgs[0] == "Craft!")
                {
                    break;
                }
                oldItem.Trim(' ');
                command = cmdArgs[0];
                item = cmdArgs[1];
                itemsToCombine = cmdArgs[1].Split(":");
                oldItem = itemsToCombine[0];
            }

            items.RemoveAll(c => c == " ");
            //Console.WriteLine(string.Join(", ",items));
            foreach (var o in items)
            {
                Console.WriteLine(o);
            }
        }



    }
}


using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] chatCommands = Console.ReadLine().Split(" ");
            List<string> finalChat = new List<string>();
            string command = chatCommands[0];
            while (command != "end")
            {
                if (command == "Chat")
                {
                    finalChat.Add(chatCommands[1]);

                }
                if (command == "Delete" && finalChat.Contains(chatCommands[1]))
                {
                    finalChat.Remove(chatCommands[1]);
                }
                if (command == "Edit" && finalChat.Contains(chatCommands[1]))
                {

                    int index = finalChat.IndexOf(chatCommands[1]);
                    finalChat.RemoveAt(index);
                    finalChat.Insert(index, chatCommands[2]);
                }
                if (command == "Pin")
                {
                    string currentMessage = chatCommands[1];
                    finalChat.Remove(chatCommands[1]);
                    finalChat.Add(currentMessage);
                }
                if (command == "Spam")
                {
                    for (int i = 1; i < chatCommands.Length ; i++)
                    {
                        string currentMessage = chatCommands[i];
                        finalChat.Add(currentMessage);

                    }



                }
              

                chatCommands = Console.ReadLine().Split(" ");
                command = chatCommands[0];
            }


            Console.WriteLine(string.Join(Environment.NewLine, finalChat));


        }
    }
}

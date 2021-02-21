using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string guests = Console.ReadLine();
            HashSet<string> hashRegular = new HashSet<string>();
            HashSet<string> hashVIP = new HashSet<string>();
            while (true)
            {
                if (guests == "PARTY")
                {
                    break;
                }
                    char character = guests[0];
                if (char.IsDigit(character))
                {
                    hashVIP.Add(guests);
                }
                else
                {
                    hashRegular.Add(guests);
                }

                guests = Console.ReadLine();
            }
            string guestsThatCame = Console.ReadLine();
            while (true)
            {
                if (guestsThatCame == "END")
                {
                    break;
                }
                char character = guestsThatCame[0];
                if (char.IsDigit(character))
                {
                    hashVIP.Remove(guestsThatCame);
                }
                else
                {
                    hashRegular.Remove(guestsThatCame);

                }
                guestsThatCame = Console.ReadLine();
            }
            int sum = hashRegular.Count + hashVIP.Count;
            Console.WriteLine(sum);
            foreach (var item in hashVIP)
            {
                Console.WriteLine(item);
            }
            foreach (var regular in hashRegular)
            {
                Console.WriteLine(regular);
            }
        }
    }
}

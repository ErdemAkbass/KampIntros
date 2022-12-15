using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(06, "Ankara");
            dictionary.Add(34, "İstanbul");
            dictionary.Add(35, "İzmir");
            dictionary.Add(69, "Bayburt");
           

            Console.WriteLine(dictionary.Count);
        }
    }
}

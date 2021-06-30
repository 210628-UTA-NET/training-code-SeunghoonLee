using System;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Collection
    {
        //Generic field
        static List<string> strings = new List<string>();

        //Non-generic field
        static ArrayList arrays = new ArrayList();

        public static void CollectionMain()
        {
            Console.WriteLine("Collection Demo");
            Console.WriteLine("List Demo");
            
            strings.Add("First element");
            strings.Add("Second element");
            strings.Add("Third element");

            foreach(string item in strings)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i < strings.Count; i+=2)
            {
                Console.WriteLine("Current index is " + i);
                Console.WriteLine(strings[i]);
            }

            int x = 0;
            while(x < strings.Count)
            {
                Console.WriteLine(strings[x]);
                x++;
            }

            Console.WriteLine("ArrayList Demo");
            arrays.Add(5);
            arrays.Add("Some string");
            arrays.Add(true);

            foreach(var item in arrays)
            {
                Console.WriteLine(item);
            }

        }

        
    }
}
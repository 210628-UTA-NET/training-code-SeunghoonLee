using System;
using System.Linq;

namespace HelloWorld
{
    public class LINQ
    {
        public static void LINQMain()
        {
            Console.WriteLine("LINQ Demo"); 
            int[] numbers = new int[]{1,2,3,4,5};

            //Query Syntax way
            //It is very similar to SQL statement
            var queryResult = (from num in numbers
                               where num%2 == 0
                               select num);
            foreach(var num in queryResult)
            {
                Console.WriteLine(num);
            }

            //Method Syntax way
            queryResult = numbers.Where(num => num%2 == 0);
            foreach(var num in queryResult)
            {
                Console.WriteLine(num);
            }
        }
    }
}
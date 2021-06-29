using System;
using HouseFunction;

namespace HelloWorld
{
    class Program
    {
        private static string _first = "Hello";
        private static string _last = "World!";

        static void Main(string[] args)
        {
            Console.WriteLine("Whatever I want");

            Test obj = new Test();
            obj.SomeMethod();

            Console.WriteLine(_first + _last);
            Console.WriteLine(obj.SomeMethod());

            House objHouse = new House();
            Console.WriteLine(objHouse.getColor());
            objHouse.setColor("Blue");
            Console.WriteLine(objHouse.getColor());
            objHouse.Price = 8000;
            Console.WriteLine(objHouse.Price);
            objHouse.Name = "Seunghoon's House";
            Console.WriteLine(objHouse.Name);

        }
    }

    class Test
    {
        public string SomeMethod()
        {
            return "Hello World SomeMethod";
        }
    }
}

using System;
using HouseFunction;

/*
    Naming conventions in C#
        We use PascalCase for most of the naming convention
        We use camelCase for naming fields
*/

namespace HelloWorld
{
    class Program
    {
        // We can use underscore for private fields to reference them easier in our code
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

            Console.WriteLine("Hello" == "Hello");

            Collection.CollectionMain();

            OOP.OOPMain();

            BoxingandUnboxing.BoxingAndUnboxingMain();

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

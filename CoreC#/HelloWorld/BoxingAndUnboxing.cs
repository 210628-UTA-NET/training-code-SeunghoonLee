using System;

namespace HelloWorld
{
    public class BoxingandUnboxing
    {
        public static void BoxingAndUnboxingMain()
        {
            Console.WriteLine("Boxing and Unboxing Demo");
            {
                //Implicit Conversion
                int num = 123;
                Console.WriteLine(typeof(int));
                double doubled = num;
                Console.WriteLine(doubled);

                //Exiplicit Conversion
                //Example of using a Cast
                doubled = 123.456;
                num = (int)doubled;
                Console.WriteLine(num);

                //Boxing
                //It is when a value type gets casted into an object
                //What happens is that the valule is wrapped to give it a reference type behavior
                //It is an example of implicit conversion(no special syntax)
                object obj = num;
                Console.WriteLine(typeof(object));
                Console.WriteLine(obj);

                //Unboxing
                //It is when you extract the value type from object and just get the value directly instead
                //A syntax is needed(cast)
                //It is an example of explicit conversion
                num = (int)obj;
                Console.WriteLine(num);
            }
        }
    }
}
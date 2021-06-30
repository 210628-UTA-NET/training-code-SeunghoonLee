using System;

namespace HelloWorld
{
    public class Animal
    {
        public string Name { get; set;}
        public string Color { get; set; }

        public Animal()
        { }
        
        public Animal(string p_name, string p_color)
        {
            Name = p_name;
            Color = p_color;
        }

        //virtual tells the compiler that this method will be overridden by the derived class
        public virtual void Speak()
        {
            Console.WriteLine("Speaking");
        }
    }

    public class Dog : Animal
    {
        private readonly int price_1;
        public const int price_2 = 800;

        public Dog() 
        {
            price_1 = 1000;
        }

        public Dog(string p_name, string p_color) : base(p_name, p_color)
        { }

        // Method overriding example
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Barking");
        }

        // Method overloading example
        public void Speak(string p_talk)
        {
            Console.WriteLine(p_talk);
        }
    }

    public class OOP
    {
        public static void OOPMain()
        {
            Console.WriteLine("OOP Demo");

            // The three ways to pass data to your new object
            // Create a new dog object
            Dog dog1 = new Dog();
            dog1.Name = "Choco";
            dog1.Color = "White";

            Dog dog2 = new Dog()
            {
                Name = "Merry",
                Color = "Bronwn"
            };

            Dog dog3 = new Dog("Minnie", "Mixed");

            dog1.Speak();
            dog2.Speak();
            dog3.Speak();
            dog1.Speak("The dog is speaking OMG");
        }
    }
}
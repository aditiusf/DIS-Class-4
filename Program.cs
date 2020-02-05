using System;

namespace DIS_Class_3
{
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig1 : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Cars : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }
    class Person
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Car
    {
        string color = "red";
        int maxSpeed = 200;
        string color1;
        int maxSpeed1;
        public string model;
        int year;

        // Create a class constructor for the Car class
        public Car()
        {
            model = "Maruti"; // Set the initial value for model
        }
       
      

        public void fullThrottle()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        enum Level
        {
            Low,
            Medium,
            High
        }

        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
            DemoClass myObjs = new DemoClass();
            myObjs.myMethod();
            myObjs.myOtherMethod();
            Pig1 myPig1 = new Pig1();  // Create a Pig object
            myPig1.animalSound();
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();


            Cars myCar = new Cars();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
            Person Obj = new Person();
            Obj.Name = "Liam";
            Console.WriteLine(Obj.Name);

            Car myObj = new Car();
            
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Car1 myObj4 = new Car1();
            myObj.color1 = "blue";
            myObj.maxSpeed1 = 300;
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
            Ford.model = "Mustang";
            Ford.color1 = "yellow";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color1 = "white";
            Opel.year = 2005;

            myObj.fullThrottle();  // Call the method

      

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            Console.WriteLine(myObj.color1);
            Console.WriteLine(myObj.maxSpeed1);
            Console.WriteLine(myObj4.color);
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}

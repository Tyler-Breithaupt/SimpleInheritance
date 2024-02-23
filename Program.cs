using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 
    class Monkey : Animal
    {
        public string type;
        public int age;
        public string tailType;

        // constructor
        public Monkey()
            :base()
        {
            age = 0;
        }
        // parameterized constructor
        public Monkey(string name, string type, int age, string tailType)
            :base(name)
        {
            this.type = type;
            this.age = age;
            this.tailType = tailType;
        }
        public void getType()
        {
            Console.WriteLine($"I am a {type}");
        }
        public void getAge()
        {
            Console.WriteLine($"I am {age} years old");
        }
        public void getTailType()
        {
            Console.WriteLine($"I have a {tailType} tail");
        }
    }

    class Lion : Animal
    {
        public string type;
        public int numOfLegs;
        public string coatColor;

        // constructor
        public Lion()
            :base()
        {
            numOfLegs = 0;
        }
        // parameterized constructor
        public Lion(string name, string type, int numOfLegs, string coatColor)
            :base(name)
        {
            this.type = type;
            this.numOfLegs = numOfLegs;
            this.coatColor = coatColor;
        }
        public void getType()
        {
            Console.WriteLine($"I am a {type}");
        }
        public void getNumOfLegs()
        {
            Console.WriteLine($"I have {numOfLegs} legs");
        }
        public void getCoatColor()
        {
            Console.WriteLine($"My coat color is {coatColor}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Monkey myMonkey = new Monkey();
            myMonkey.name = "Bodie";
            myMonkey.type = "Monkey";
            myMonkey.age = 4;
            myMonkey.tailType = "long";
            myMonkey.display();
            myMonkey.getType();
            myMonkey.getAge();
            myMonkey.getTailType();

            Lion myLion = new Lion();
            myLion.name = "Scar";
            myLion.type = "Lion";
            myLion.numOfLegs = 4;
            myLion.coatColor = "black";
            myLion.display();
            myLion.getType();
            myLion.getNumOfLegs();
            myLion.getCoatColor();

            //derived class object using parameterized constructor
            Monkey George = new Monkey("George", "Monkey", 5, "short");
            George.display();
            George.getType();
            George.getAge();
            George.getTailType();

            Lion Simba = new Lion("Simba", "Lion", 4, "red");
            Simba.display();
            Simba.getType();
            Simba.getNumOfLegs();
            Simba.getCoatColor();
        }

    }
}


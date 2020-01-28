using System;

namespace populationControl2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.Clear();
            
                person1.name = "henk jan peter dirk";
                person1.eyeColour = "Green";
                person1.length = 235;
                person1.age = 101;
                person1.countryOfBirth = "Netherlands";
                person1.bsn = 777777777;

            Person person2 = new Person();
                person2.name = "Gieles gijs";
                person2.eyeColour = "Blue";
                person2.length = 198;
                person2.age = 70;
                person2.countryOfBirth = "Netherlands";
                person2.bsn = 888888888;

            Person person3 = new Person();
                person3.name = "Bob Cornelis Jacobus Hoogenboom de vries";
                person3.eyeColour = "Greenish";
                person3.length = 1980;
                person3.age = 180;
                person3.countryOfBirth = "Netherlandsh";
                person3.bsn = 999999999;

            Person person4 = new Person();
                person4.name = "keanu reeves";
                person4.eyeColour = "Brown";
                person4.length = 186;
                person4.age = 55;
                person4.countryOfBirth = "California";
                person4.bsn = 222222222;

            Person person5 = new Person();
                person5.name = "Michiel Antonius Adrianus Beelen";
                person5.eyeColour = "Blue";
                person5.length = 171;
                person5.age = 42;
                person5.countryOfBirth = "Netherlands";
                person5.bsn = 123456789;

            Console.WriteLine(person1.name);
            Console.WriteLine(person2.name);
            Console.WriteLine(person3.name);
            Console.WriteLine(person4.name);
            Console.WriteLine(person5.name);

        }
    }
}

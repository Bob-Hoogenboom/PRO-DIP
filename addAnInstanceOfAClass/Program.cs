using System;

namespace classAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Erwin", "DIP", "C1.53");
            Teacher t2 = new Teacher("Erik", "PRO", "C1.13");
            Teacher t3 = new Teacher("Alex", "DVTA", "C2.01");
            Teacher t4 = new Teacher("Theo", "PRO1", "C1.08");

            Parent p1 = new Parent("Hugo's parents", "Hugo");
            Parent p2 = new Parent("Björn's parents", "Björn");
            Parent p3 = new Parent("Roos's parents", "Roos");

            Student s1 = new Student("Hugo", "Media-developer");
            Student s2 = new Student("Björn", "Game-developer");
            Student s3 = new Student("Roos", "Game-Artist");

        }
    }
}

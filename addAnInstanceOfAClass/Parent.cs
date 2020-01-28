using System;
namespace classAssignment
{
    public class Parent : Person
    {
        public Parent(string name, string student) : base(name){
            //constructor
            Console.WriteLine(" You're child is "+student);
        }
    }
}
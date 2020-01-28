using System;
namespace classAssignment
{
    public class Teacher:Person
    {
        private string classRoom;
        private string course;
        public Teacher(string name, string course, string classRoom):base(name){
            this.course = course;
            this.classRoom = classRoom;
            Console.WriteLine("you teach " + course +" in classRoom: " + classRoom);
        }
    }
}
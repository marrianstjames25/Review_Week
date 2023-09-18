using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student("Simon",12,3.4);
            student.age = 14;
            student.age = 98;
            student.Name = "Test";

        }
    }
    class Student
    {
        private string _name; //Auto Implemented Property
        public int age;
        //public int phoneNum { get; set; }
        public double GPA;

        //Explicitly
        public string Name
        {
            get
            {
                if (age > 18)
                {
                    return _name;
                }
                else
                {
                    return "Student is underage";
                }
            }
            set
            {
                if (age  != 0) 
                {
                _name = value;}
            }
        }

        public Student(string name, int age, double GPA)
        {
            this.age = 16;
            this.GPA = GPA;
            Name = name;
            IntroStudent();

        }

        public void IntroStudent()
        {
            Console.WriteLine($"Hello my name is{Name}, I am {age} yo and I my GPA is {GPA}");
        }


    }

}
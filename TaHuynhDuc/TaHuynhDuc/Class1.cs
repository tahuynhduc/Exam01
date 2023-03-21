using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaHuynhDuc
{
    public class Student
    {
        public int Id;
        public string Name;
        public string Gender;
        public int Age;
        public DateTime DateOfBirth { get; set; }
        public int Class;
        public float Mark1;
        public float Mark2;
        public float Mark3;

        public Student(int id, string name , string gender, int age, int clas ,float mark1,float mark2,float mark3)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Mark1 = mark1;
            this.Mark2 = mark2;
            this.Mark3 = mark3;
        }
        public float mark_AVG()
        {
            return (Mark1 + Mark2 + Mark3) / 3;
        }
    }
    public class TestStudent
    {
        public int id { get; set; }
        public string name{ get; set; }
        public void Student()
        {
            Console.WriteLine($"input ID");
            Console.ReadLine(id);
            Console.WriteLine($"input name");
            Console.ReadLine(name);
            Console.WriteLine($"input gender");
            Console.ReadLine();
            Console.WriteLine($"input date of birth");
            Console.ReadLine();
            Console.WriteLine($"input class");
            Console.ReadLine();
        }
        public void SearchStudent()
        {
            Console.WriteLine("Input name of student you want search:");
            Console.ReadLine();
        }
        
    }
        
}

using System.Reflection;
using System.Security.Claims;
using System.Xml.Linq;
using TaHuynhDuc;

namespace kt
{
    class program
    {
        static void Main(string[] args)
        {
            //Student st = new Student(1, "test1", "male", 12, 12, 5, 6, 7);
            //Console.WriteLine("input mark 1");
            //st.Mark1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("input mark 2");
            //st.Mark2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("input mark 3");
            //st.Mark3 = float.Parse(Console.ReadLine());
            //Console.WriteLine("input ID");
            //st.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("input Name");
            //st.Name = Console.ReadLine();
            //Console.WriteLine("input Gender");
            //st.Gender = Console.ReadLine();
            //Console.WriteLine("input Date of birth");
            //st.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            //if (st.Mark1 > 0 && st.Mark2 > 0 && st.Mark3 > 0 && st.Mark1 < 100 && st.Mark2 < 100 && st.Mark3 < 100)
            //{
            //    Console.WriteLine(st.mark_AVG());
            //}
            //else { Console.WriteLine("nhap sai"); }

            TestStudent test = new TestStudent();

            Console.WriteLine(test.Student);






            Console.Read();
        }
    }
}
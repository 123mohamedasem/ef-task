using studentsystem3.data;

namespace studentsystem3.models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            context.studnts.Add(new student { student_id = 2, name = "Alice", phonenumber = "1234567890", registeredon = DateTime.Now });
            context.studnts.Add(new student { student_id = 3, name = "Ali", phonenumber = "123456770", registeredon = DateTime.Now });
            context.SaveChanges();
            List<student> students = context.studnts.ToList();
            foreach (var item in students)
            {
                Console.WriteLine($"student_id:{item.student_id},name{item.name}");
            }

            context.courses.Add(new course { course_id = 1, name = "mostafa", price = 50 });
            context.courses.Add(new course { course_id = 4, name = "mohamed", price = 66 });
            context.courses.Add(new course { course_id = 8, name = "mohaned", price = 50 });
            context.courses.Add(new course { course_id = 2, name = "eslam", price = 66 });
            context.SaveChanges();


            context.homeworks.Add(new homework { homework_id = 1, content = "science" });
            context.homeworks.Add(new homework { homework_id = 4, content = "math" });
            context.SaveChanges(true);


            context.resourcess.Add(new resources { id = 4, name = "google" });
            context.resourcess.Add(new resources { id = 8, name = "microsoft" });
            context.SaveChanges();









        }

    }


}


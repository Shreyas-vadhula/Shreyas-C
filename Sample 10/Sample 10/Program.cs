using System;

namespace Sample_10
{
    class Student
    {
         public int RollNumber { get; set; }
         public String Name { get; set; }
         public String Gender { get; set; }
         static void Main()
         {
          Student student = new Student();
            student.RollNumber = 1;
            student.Name = "shreyas";
            student.Gender = "Male";
            Console.WriteLine(student.RollNumber+"\t"+ student.Name + "\t" + student.Gender);
            Console.ReadLine();
         }

    }
}

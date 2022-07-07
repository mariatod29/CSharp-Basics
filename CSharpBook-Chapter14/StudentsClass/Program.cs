using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
//Напишете клас StudentTest, който да тества функционалността на класа Student.
class StudentTest
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Student[] students = new Student[2] { new Student("Todor", "Lazarov", "Todorov", 4, "Electronics", "Technical University - Varna", "t.ltodorov@gmail.com", 08864675213),
            new Student("Maria", "Todorova", "Todorova", 3, "CST", "Technical University - Sofia","mtodorova@blubito.com",08887657533) };
        foreach (var item in students)
        {
            Console.WriteLine(item.ToString());
        }
    }
    // public static studentCount
    //{
    //  get { return new Student("Angel", "Zhelyazkov", "Krastev", 4, "Business", "Economics University Varna", "akr@mail.com", 08946613466); }
    //}
}
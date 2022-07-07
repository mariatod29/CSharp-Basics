using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

public class Student
{
    //Дефинирайте клас Student, който съдържа следната информация за студентите: трите имена, курс, специалност, университет, електронна поща и телефонен номер.
    string firstName;
    string middleName;
    string lastName;
    int course;
    string program;
    string university;
    string email;
    decimal phoneNumber;
    //Добавете статично поле в класа Student, в което се съхранява броя на създадените обекти от този клас.
    static int _count;

    //Декларирайте няколко конструктора за класа Student, които имат различни списъци с параметри (за цялостната информация за даден студент или част от нея).
    public Student(string firstName, string middleName, string lastName, int course, string program, string university, string email, decimal phoneNumber)
    {
        this.firstName = firstName;
        this.middleName = middleName;
        this.lastName = lastName;
        this.course = course;
        this.program = program;
        this.university = university;
        this.email = email;
        this.phoneNumber = phoneNumber;
    }
    //Данните, за които няма входна информация да се инициализират съответно с null или 0.
   /* public Student(string firstName, string middleName) : this(firstName, middleName, null, 0, null, null, null, 0m)
    {
    }
    public Student(string firstName, string middleName, string lastName) : this(firstName, middleName, lastName, 0, null, null, null, 0m)
    {
    }
    public Student(string firstName, string middleName, string lastName, int course) : this(firstName, middleName, lastName, course, null, null, null, 0m)
    {
    }
    public Student(string firstName, string middleName, string lastName, int course, string program) : this(firstName, middleName, lastName, course, program, null, null, 0m)
    {
    }
    public Student(string firstName, string middleName, string lastName, int course, string program, string university) : this(firstName, middleName, lastName, course, program, university, null, 0m)
    {
    }
    public Student(string firstName, string middleName, string lastName, int course, string program, string university, string email) : this(firstName, middleName, lastName, course, program, university, email, 0m)
    {
    } */
    //Модифицирайте текущия код на класа Student така, че да капсулирате данните в класа чрез свойства.
    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (String.IsNullOrEmpty(value) | (String.IsNullOrWhiteSpace(value))) throw new ArgumentException("Invalid first name input!");
            this.firstName = value;
        }
    }
    public string MiddleName
    {
        get { return this.middleName; }
        set
        {
            if (String.IsNullOrEmpty(value) | (String.IsNullOrWhiteSpace(value))) throw new ArgumentException("Invalid middle name input!");
            this.middleName = value;
        }
    }
    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (String.IsNullOrEmpty(value) | (String.IsNullOrWhiteSpace(value))) throw new ArgumentException("Invalid last name input!");
            this.lastName = value;
        }
    }
    public int Course
    {
        get { return this.course; }
        set
        {
            if (value < 0) throw new ArgumentException("Negative course can not be accepted!");
            this.course = value;
        }
    }
    public string Program
    {
        get { return this.program; }
        set
        {
            if (String.IsNullOrEmpty(value) | (String.IsNullOrWhiteSpace(value))) throw new ArgumentException("Invalid program input!");
            this.program = value;
        }
    }
    public string University
    {
        get { return this.middleName; }
        set
        {
            if (String.IsNullOrEmpty(value) | (String.IsNullOrWhiteSpace(value))) throw new ArgumentException("Invalid university input!");
            this.university = value;
        }
    }
    public string Email
    {
        get { return this.email; }
        set
        {
            if (String.IsNullOrEmpty(value) | (String.IsNullOrWhiteSpace(value))) throw new ArgumentException("Invalid email input!");
            this.email = value;
        }
    }
    public decimal PhoneNumber
    {
        get { return this.phoneNumber; }
        set
        {
            if (value < 0) throw new ArgumentException("Negative course can not be accepted!");
            this.phoneNumber = value;
        }
    }
    
    //Добавете метод в класа Student, който извежда пълна информация за студента.
    public static void StudentOutput(Student myStudent)
    {
        Console.WriteLine(myStudent.ToString());
    }
    public override string ToString()
    {
        StringBuilder StudentInfo = new StringBuilder();
        StudentInfo.AppendLine(String.Format("Student's first name: {0}", this.firstName));
        StudentInfo.AppendLine(String.Format("Student's middle name: {0}", this.middleName));
        StudentInfo.AppendLine(String.Format("Student's last name: {0}", this.lastName));
        StudentInfo.AppendLine("Student's course: " + this.course);
        StudentInfo.AppendLine("Student's program: " + this.program);
        StudentInfo.AppendLine("Student's university: " + this.university);
        StudentInfo.AppendLine("Student's email: " + this.email);
        StudentInfo.AppendLine("Student's phone number: " + this.phoneNumber);
        return StudentInfo.ToString();
    }
}
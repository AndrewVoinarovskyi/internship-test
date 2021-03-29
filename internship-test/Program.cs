using System;
using System.Collections.Generic;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Alex Vitrov", new Knowledge(10.2));
            Student student2 = new Student("Julia Veselkina", new Knowledge(9.8));
            Student student3 = new Student("Maria Perechrest", new Knowledge(10.1));

            University university = new University("CH.U.I.");
            university.AddStudent(student1);
            university.AddStudent(student2);
            university.AddStudent(student3);


            Internship internship = new Internship("Interlink");
            internship.AddStudents(university);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}

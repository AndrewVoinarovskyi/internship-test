using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {

        List<Student> students = new List<Student>(1);
        string name;

        public Internship(string name)
        {
            this.name = name;
        }
        public string GetStudents()
        {
            
            string namesOfStudents = "";
            foreach (var student in students)
            {
                namesOfStudents += $"{student.name}\n";
            }
            return namesOfStudents;
        }

        public void AddStudents(University university)
        {
            foreach (var student in university.students)
            {
                double middleKnowledge = university.GetMiddleKnowledge();
                if(student.knowledge.level > middleKnowledge)
                {
                students.Add(student);
                }
            }
        }
    }
}
using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest
{

    public class University
    {
        string name;
        public List<Student> students = new List<Student>(1);
        
        public University(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public double GetMiddleKnowledge()
        {
            double allKnowledge = 0;
            foreach(var student in students)
            {
                allKnowledge += student.knowledge.level;
            }
            return allKnowledge / students.Count;
        }
    }
}

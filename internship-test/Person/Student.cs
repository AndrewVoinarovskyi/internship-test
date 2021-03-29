namespace InternshipTest.Person
{
    public class Student
    {

        public string name;
        public Knowledge knowledge;

        public Student(string name, Knowledge knowledge)
        {
            this.name = name;
            this.knowledge = knowledge;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
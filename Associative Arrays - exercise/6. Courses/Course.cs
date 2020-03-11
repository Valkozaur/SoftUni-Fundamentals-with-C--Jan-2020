namespace _6._Courses
{
    using System.Collections.Generic;

    public class Course
    {
        public Course(string name)
        {
            this.Name = name;
            this.RegisteredStudents = new List<string>();
        }

        public string Name { get; set; }

        public List<string> RegisteredStudents { get; set; }
    }
}

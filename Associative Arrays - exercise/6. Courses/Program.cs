using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _6._Courses
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var courses = new List<Course>();

            while (true)
            {
                var splitInput = Console.ReadLine()
                    .Split(" : ");

                if (splitInput[0] == "end")
                {
                    break;
                }

                var courseName = splitInput[0];
                var courseParticipant = splitInput[1];

                var course = courses.FirstOrDefault(x => x.Name == courseName);
                if (course == null)
                {
                    var newCourse = new Course(courseName);
                    newCourse.RegisteredStudents.Add(courseParticipant);
                    courses.Add(newCourse);
                }
                else
                {
                    course.RegisteredStudents.Add(courseParticipant);
                }
            }

            courses = courses
                .OrderByDescending(x => x.RegisteredStudents.Count)
                .ToList();

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Name}: {course.RegisteredStudents.Count}");
                foreach (var participant in course.RegisteredStudents.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {participant}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.__SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = Console.ReadLine()
                .Split(", ")
                .ToList();
            while (true)
            {
                var commandArgs = Console.ReadLine()
                    .Split(":");
                var command = commandArgs[0];

                if (command == "course start")
                {
                    break;
                }

                var lessonTitle = commandArgs[1];
                var exerciceTitle = $"{lessonTitle}-Exercice";

                switch (command)
                {
                    case "Add":

                        AddACourse(courses, lessonTitle);
                        break;

                    case "Insert":

                        var index = int.Parse(commandArgs[2]);
                        InsertACourse(courses, lessonTitle, index);
                        break;

                    case "Remove":

                        RemoveACourse(courses, lessonTitle, exerciceTitle);
                        break;

                    case "Swap":
                        var secondLessonTitle = commandArgs[2];
                        exerciceTitle = SwapLessons(courses, lessonTitle, exerciceTitle, secondLessonTitle);
                        break;

                    case "Exercise":
                        InsertExercice(courses, lessonTitle, exerciceTitle);
                        break;
                }
            }

            var counter = 1;
            foreach (var lesson in courses)
            {
                Console.WriteLine($"{counter++}.{lesson}");
            }
        }

        private static string SwapLessons(List<string> courses, string lessonTitle, string exerciceTitle, string secondLessonTitle)
        {
            if (LessonExists(courses, lessonTitle) && LessonExists(courses, secondLessonTitle))
            {
                var firstLessons = new List<string>();
                var firstLessonIndex = courses.IndexOf(lessonTitle);
                firstLessons.Add(lessonTitle);
                courses[firstLessonIndex] = null;

                if (IndexIsValid(courses, firstLessonIndex + 1) && courses[firstLessonIndex + 1] == exerciceTitle)
                {
                    firstLessons.Add(exerciceTitle);
                    courses[firstLessonIndex + 1] = null;
                }

                var secondLessons = new List<string>();
                var secondLessonIndex = courses.IndexOf(secondLessonTitle);
                secondLessons.Add(secondLessonTitle);
                courses[secondLessonIndex] = null;

                exerciceTitle = $"{secondLessonTitle}-Exercice";
                if (IndexIsValid(courses, secondLessonIndex + 1) && courses[secondLessonIndex + 1] == exerciceTitle)
                {
                    secondLessons.Add(exerciceTitle);
                    courses[secondLessonIndex + 1] = null;
                }

                courses.InsertRange(firstLessonIndex, secondLessons);
                courses.InsertRange(secondLessonIndex + secondLessons.Count, firstLessons);
                courses.RemoveAll(x => x == null);
            }

            return exerciceTitle;
        }

        private static void InsertExercice(List<string> courses, string lessonTitle, string exerciceTitle)
        {
            if (LessonExists(courses, lessonTitle) && !LessonExists(courses, exerciceTitle))
            {
                int indexOfLesson = courses.IndexOf(lessonTitle);
                courses.Insert(indexOfLesson + 1, exerciceTitle);
            }
            else if (!LessonExists(courses, lessonTitle))
            {
                courses.Add(lessonTitle);
                courses.Add(exerciceTitle);
            }
        }

        private static void AddACourse(List<string> courses, string lessonTitle)
        {
            if (!LessonExists(courses, lessonTitle))
            {
                courses.Add(lessonTitle);
            }
        }

        private static void InsertACourse(List<string> courses, string lessonTitle, int index)
        {
            if (!LessonExists(courses, lessonTitle) && IndexIsValid(courses, index))
            {
                courses.Insert(index, lessonTitle);
            }
        }

        private static void RemoveACourse(List<string> courses, string lessonTitle, string exerciceTitle)
        {
            int lessonIndex = courses.IndexOf(lessonTitle);
            if (lessonIndex != -1)
            {
                courses[lessonIndex] = null;
                if (IndexIsValid(courses, lessonIndex + 1) && courses[lessonIndex + 1] == exerciceTitle)
                {
                    courses[lessonIndex + 1] = null;
                }
            }

            courses.RemoveAll(x => x == null);
        }

        static bool LessonExists(List<string> courses, string lessonTitle)
        {
            return courses.Contains(lessonTitle);
        }

        static bool IndexIsValid(List<string> courses, int index)
        {
            return 0 <= index && index < courses.Count; ;
        }
    }
}

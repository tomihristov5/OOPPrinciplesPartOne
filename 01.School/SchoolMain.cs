// Problem 1. School classes
// We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher 
// teaches, a set of disciplines. Students have a name and unique class number. Classes have unique text identifier. 
// Teachers have a name. Disciplines have a name, number of lectures and number of exercises. Both teachers and students 
// are people. Students, classes, teachers and disciplines could have optional comments (free text block).
// Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, 
// define the class hierarchy and create a class diagram with Visual Studio.

namespace _01.School
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using _01.School.People;

    public class SchoolMain
    {
        public static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static void Main()
        {
            NewSchool school = new NewSchool("PGSAG");

            var class9b = new ClassOfStudents("Class 9b");
            var class11a = new ClassOfStudents("Class 11a");

            school.AddClasses(class9b);
            school.AddClasses(class11a);
            Console.WriteLine("School name: " + school.SchoolName);
            Console.WriteLine("Classes: ");
            PrintCollection(school.AllStudentClasses);

            class9b.AddStudents(new Student("Muncho", "Georgiev", 156489));
            class9b.AddStudents(new Student("Stamat", "Harabiyski", 156973));
            Console.WriteLine("Students from " + class9b + ":");
            PrintCollection(class9b.StudentSet);

            var listOfDisciplines = new List<Disciplines>();
            listOfDisciplines.Add(new Disciplines("Physics", 30, 30));
            listOfDisciplines.Add(new Disciplines("Chemistry", 15, 15));

            class9b.AddTeachers(new Teacher("Penka", "Chocheva", listOfDisciplines));
            class9b.AddTeachers(new Teacher("Shlioko", "Shliokov", listOfDisciplines));
            foreach (var teacher in class9b.TeacherSet)
            {
                Console.WriteLine("Teacher: " + teacher);
                PrintCollection(listOfDisciplines);
            }

            class9b.Comment = "We are complete idiots!";
            Console.WriteLine(class9b.Comment);
        }
    }
}

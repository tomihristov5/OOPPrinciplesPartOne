// Problem 2. Students and workers
// Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human 
// and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay 
// and a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper constructors and 
// properties for this hierarchy.
// Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
// Initialize a list of 10 workers and sort them by money per hour in descending order.
// Merge the lists and sort them by first name and last name.

namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using _02.StudentsAndWorkers.People;

    public class HumanMain
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
            var studentsList = new List<Student>();
            studentsList.Add(new Student("Ivan", "Mihaylov", 4));
            studentsList.Add(new Student("Georgi", "Mihaylov", 2));
            studentsList.Add(new Student("Don Kihot", "Panchov", 4));
            studentsList.Add(new Student("Muncho", "Ivanov", 5));
            studentsList.Add(new Student("Dyako", "Hristov", 4));
            studentsList.Add(new Student("Pesho", "Georgiev", 6));
            studentsList.Add(new Student("Gosho", "Stoyanov", 6));
            studentsList.Add(new Student("Tosho", "Mihaylov", 4));
            studentsList.Add(new Student("Pesho", "Ivanov", 3));
            studentsList.Add(new Student("Ivan", "Ivanov", 2));

            var sortetStudents = studentsList.OrderBy(st => st.Grade).ToList();
            PrintCollection(sortetStudents);
            Console.WriteLine();

            var workersList = new List<Worker>();
            workersList.Add(new Worker("Ivancho", "Mariykov", 180, 6));
            workersList.Add(new Worker("Mariyka", "Ivanchova", 250, 7));
            workersList.Add(new Worker("Gosho", "Marinov", 180, 5));
            workersList.Add(new Worker("Pesho", "Dyakov", 460, 6));
            workersList.Add(new Worker("Ivo", "Ivanov", 300, 8));
            workersList.Add(new Worker("Ivelina", "Nedyalkova", 180, 4));
            workersList.Add(new Worker("Hristo", "Hristov", 120, 6));
            workersList.Add(new Worker("Georgi", "Georgiev", 180, 8));
            workersList.Add(new Worker("Tosho", "Toshev", 600, 7));
            workersList.Add(new Worker("Ivancho", "Domuschiev", 180, 8));

            var sortedWorkers = workersList.OrderByDescending(x => x.MoneyPerHour());
            PrintCollection(sortedWorkers);
            Console.WriteLine();

            var humanList = new List<Human>();
            humanList.AddRange(studentsList);
            humanList.AddRange(workersList);

            PrintCollection(humanList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName));
        }
    }
}

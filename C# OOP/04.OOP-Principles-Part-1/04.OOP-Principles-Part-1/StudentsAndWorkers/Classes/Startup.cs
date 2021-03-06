﻿using StudentsAndWorkers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    class Startup
    {
        static void Main(string[] args)
        {
            var people = new List<IHuman>();

            var students = new List<Student>();
            students.Add(new Student("James", "Hetfield", 6));
            students.Add(new Student("Jimmy", "Hendrix", 5));
            students.Add(new Student("Kirk", "Hammet", 4));
            students.Add(new Student("Corey", "Taylor", 6));
            students.Add(new Student("Sully", "Erna", 6));
            students.Add(new Student("Ivan", "Geshov", 4));
            students.Add(new Student("Dave", "Lombardo", 5));
            students.Add(new Student("Todor", "Kableshkov", 2));
            students.Add(new Student("Hristo ", "Ivanov", 3));
            students.Add(new Student("Petko", "Todorov", 4));

            var workers = new List<Worker>();
            workers.Add(new Worker("Jimmy", "Page", 500, 8));
            workers.Add(new Worker("Milen", "Cvetkov", 500, 8));
            workers.Add(new Worker("Veselin", "Marinov", 540, 4));
            workers.Add(new Worker("Vasil", "Naidenov", 1500, 3));
            workers.Add(new Worker("Doncho", "Minkov", 800, 8));
            workers.Add(new Worker("Steven", "Cvetkov", 400, 8));
            workers.Add(new Worker("Ivan", "Petkov", 300, 12));
            workers.Add(new Worker("Stoyan", "Petkov", 500, 8));
            workers.Add(new Worker("Georgi", "Ivanov", 850, 8));
            workers.Add(new Worker("Todor", "Georgiev", 680, 8));


            var sortedStudentsGrade = students.OrderBy(x => x.Grade).ToList();

            var sortedWorkerMoney = workers.OrderBy(x => x.MoneyPerHour()).ToList();
            
            var sortedPeople = people.OrderBy(p => p.FName).ThenBy(p => p.LName);

            Console.WriteLine("Students sorted by grade: \n");

            foreach (var student in sortedStudentsGrade)
            {
                people.Add(student);
                Console.WriteLine($"{student.FName} {student.LName} - {student.Grade}");
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Workers sorted by money per hour: \n");

            foreach (var worker in sortedWorkerMoney)
            {
                people.Add(worker);
                Console.WriteLine($"{worker.FName} {worker.LName} - {worker.MoneyPerHour()}");
            }

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("All people sorted by their first and last name in alphabetical order: \n");

            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.FName} {person.LName}");
            }
                               
            
        }
    }
}

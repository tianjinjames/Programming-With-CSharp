﻿using System;
using System.Collections.Generic;

namespace Module_6_Assignment
{
    public class Student : Person
    {
        private Stack<int> Grades = new Stack<int>();

        public Stack<int> GradesAccessor
        {
            get { return Grades; }
            set { Grades = value; }
        }
        public static int registeredStudent = 0;
        public void TakeTest()
        {
            Console.WriteLine("Student takes tests.");
        }

        public Student(string s1, string s2, string s3)
        {
            firstName = s1;
            lastName = s2;
            birthday = s3;
            registeredStudent++;
        }
    }
}
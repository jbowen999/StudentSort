﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    public class Student
    {
        public string? name;
        public double gpa;

        public Student(string name, double gpa)
        {
            this.name = name;
            this.gpa = gpa;
        }
    }
}

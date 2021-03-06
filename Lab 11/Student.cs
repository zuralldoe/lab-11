﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Student : Person
    {

        private string program;
        private int year;
        private double fee;

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }

        public string Program
        {
            get
            {
                return program;
            }

            set
            {
                program = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }
        public override string ToString()
        {
            return "Student " + base.ToString() +", "+ "program="+program+", "+"year="+year+", " + "fee=" + fee;
        }

    }
}


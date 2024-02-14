using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_Hongfei
{
    public class Student : Person
    {
        public double GPA { get; set; }

        public Student(string name, int iD, double gpa) : base(name, iD)
        {
            GPA = gpa;
        }

        public override string GetDetails()
        {
            return $" Name : {Name}, ID: {ID}, GPA: {GPA}";
        }
    }
}

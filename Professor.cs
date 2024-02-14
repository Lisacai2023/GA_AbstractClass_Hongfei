using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_Hongfei
{
    internal class Professor : Person
    {
        public string Department { get; set; }

        public Professor(string name, int iD, string department) : base(name, iD)
        {
            Department=department;
        }


        public override string GetDetails()
        {
            return $"Name : {Name}, ID: {ID}, Department : {Department}";
        }
    }
}

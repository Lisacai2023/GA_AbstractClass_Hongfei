using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_Hongfei
{
    public abstract class Person
    {

        public string Name { get; set; }
        public int ID { get; set; }
        protected Person(string name, int iD)
        {
            Name=name;
            ID=iD;
        }

        public abstract string GetDetails();


    }
}

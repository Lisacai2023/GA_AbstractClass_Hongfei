using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_Hongfei
{
    public class Mascot : Person
    {
        public string Animals { get; set; }

        public Mascot(string name, int iD,string animals) : base(name, iD)
        {
            Animals=animals;
        }

        public override string GetDetails()
        {
            return $"Name: {Name}, ID: {ID}, Animals: {Animals}";
        }

    }
}

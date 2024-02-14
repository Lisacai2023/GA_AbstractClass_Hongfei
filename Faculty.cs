using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_Hongfei
{
    public class Faculty : Person
    {
        public string Role { get; set; }

        public Faculty(string name, int iD, string role) : base(name, iD)
        {
            Role=role;
        }

        public override string GetDetails()
        {
            return $"Name: {Name}, ID: {ID}, Role: {Role}";
        }
    }
}

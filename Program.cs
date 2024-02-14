namespace GA_AbstractClass_Hongfei
{
    //GA_AbstractClass
    //Hongfei
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- AbstractClass ----------");
            //Create a list to hold Person objects, renamed, as "schoolDatabase"
            List<Person> ShoolDatabase = new List<Person>();

            //Add two instances of each derived class
            ShoolDatabase.Add(new Student("Lisa Cai", 1001, 3.8));
            ShoolDatabase.Add(new Student("Tina zheng", 1002, 3.5));
            ShoolDatabase.Add(new Professor("Dr.Smith", 101, "Computer Science"));
            ShoolDatabase.Add(new Professor("Dr.Johnson", 102, "English"));
            ShoolDatabase.Add(new Faculty("Jane Brown", 201, "HR"));
            ShoolDatabase.Add(new Professor("Ella Wang", 202, "Admissions"));
            ShoolDatabase.Add(new Mascot("Bailey", 1, "Bear"));
            ShoolDatabase.Add(new Mascot("Blaze", 2, "Dragon"));

            foreach (var person in ShoolDatabase)
            {
                Console.WriteLine(person.GetDetails());
                Console.WriteLine();
            }

            Professor professor1 = new Professor("Dr.Smith", 101, "Computer Science");
            string professorInfo = professor1.GetDetails();
            Console.WriteLine("Profesor Information:");
            Console.WriteLine(professorInfo);
        }
    }
}

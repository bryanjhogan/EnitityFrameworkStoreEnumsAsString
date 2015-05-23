using System.Linq;

namespace StoreEnumStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new StringsForEnumsContext();
            var jSmith = new Person {FirstName = "James", LastName = "Smith", Gender = Gender.Male};

            context.Person.Add(jSmith);
            context.SaveChanges();

            var personFromDB = context.Person.FirstOrDefault();
        }
    }
}

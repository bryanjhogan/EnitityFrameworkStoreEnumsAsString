using System.Data.Entity;

namespace EnitityFrameworkStoreEnumsAsString
{
    public class StringsForEnumsContext : DbContext
    {
        public StringsForEnumsContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<StringsForEnumsContext>());
        }

        public DbSet<Person> Person { get; set; }
    }
}
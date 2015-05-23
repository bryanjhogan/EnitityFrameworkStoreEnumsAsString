using System.Data.Entity;

namespace StoreEnumStrings
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
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPOC.Data
{
    public class PersonDBContext: DbContext
    {
        public PersonDBContext()
            :base("Name=PersonDatabase")
        {
            Database.SetInitializer(new PersonDBInitializer());
        }
        public DbSet<Person> People { get; set; }
    }
}

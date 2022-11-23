using System.Collections.Generic;
using System.Linq;
using EntityFrameworkExample.AppDbContext;

namespace EntityFrameworkExample.Core
{
    public class PeopleRepository : IPeopleRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            using (var context = new PeopleDbContext())
            {
                var people = (from person 
                              in context.People 
                              where person.Years > 18 && person.Years < 50 
                              select person).ToList();

                return people;
            }
        }
    }
}

using System.Collections.Generic;

namespace EntityFrameworkExample.Core
{
    public interface IPeopleRepository
    {
        IEnumerable<Person> GetPeople();
    }
}

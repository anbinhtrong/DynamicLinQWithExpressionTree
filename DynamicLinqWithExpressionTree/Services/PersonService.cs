using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicLinqWithExpressionTree.Database;

namespace DynamicLinqWithExpressionTree.Services
{
    public class PersonService: IPersonService
    {
        private readonly AdventureWorks2014Context _dbContext;
        public PersonService()
        {
            _dbContext = new AdventureWorks2014Context();
        }
        public List<Person> GetPersonWithStartWith(string keyword)
        {
            return _dbContext.People.Where(t => t.FirstName.StartsWith(keyword)).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicLinqWithExpressionTree.Services;

namespace DynamicLinqWithExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonService personService = new PersonService();
            var people = personService.GetPersonWithStartWith("Da");
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}

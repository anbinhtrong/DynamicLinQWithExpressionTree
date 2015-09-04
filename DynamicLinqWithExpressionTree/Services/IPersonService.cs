using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicLinqWithExpressionTree.Database;

namespace DynamicLinqWithExpressionTree.Services
{
    public interface IPersonService
    {
        List<Person> GetPersonWithStartWith(string keyword);
    }
}

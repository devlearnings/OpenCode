using System.Collections.Generic;
using WinFormMVCDemo.Models;

namespace WinFormMVCDemo.Repository
{
    public interface IPersonReadRepository
    {
        List<Person> GetAllPersons();
    }
}
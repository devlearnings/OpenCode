using System.Collections.Generic;
using WinFormMVCDemo.Models;
using WinFormMVCDemo.Views;

namespace WinFormMVCDemo.Controllers
{
    public interface IPersonController
    {
        IView AddPersonView();
        void AddPerson(Person person);
        List<Person> GetPersons();
    }
}
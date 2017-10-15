using System.Collections.Generic;
using WinFormMVCDemo.Models;

namespace WinFormMVCDemo.Orchestrator
{
    public interface IPersonOrchestrator
    {
        void AddPerson(Person person);
        List<Person> GetPersons();
    }
}
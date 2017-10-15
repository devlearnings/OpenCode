using System.Collections.Generic;
using Autofac;
using WinFormMVCDemo.Models;
using WinFormMVCDemo.Orchestrator;
using WinFormMVCDemo.Views;

namespace WinFormMVCDemo.Controllers
{
    public class PersonController : IPersonController
    {
        private readonly IPersonOrchestrator _personOrchestrator;

        public PersonController()
        {
            _personOrchestrator = DependencyContainer.Container.Resolve<IPersonOrchestrator>();
        }

        public IView AddPersonView()
        {
            return new FrmPersonAdd(this,new Person());
        }

        public void AddPerson(Person person)
        {
            _personOrchestrator.AddPerson(person);
        }

        public List<Person> GetPersons()
        {
            return _personOrchestrator.GetPersons();
        }
    }

}

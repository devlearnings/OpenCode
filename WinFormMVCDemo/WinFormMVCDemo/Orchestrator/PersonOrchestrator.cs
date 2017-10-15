using System.Collections.Generic;
using WinFormMVCDemo.Models;
using WinFormMVCDemo.Repository;

namespace WinFormMVCDemo.Orchestrator
{
    public class PersonOrchestrator : IPersonOrchestrator
    {
        private readonly IPersonReadRepository _readRepository;
        private readonly IPersonWriteRepository _writeRepository;

        public PersonOrchestrator(IPersonReadRepository readRepository, IPersonWriteRepository writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        public void AddPerson(Person person)
        {
            _writeRepository.AddPerson(person);
        }

        public List<Person> GetPersons()
        {
            return _readRepository.GetAllPersons();
        }
    }
}

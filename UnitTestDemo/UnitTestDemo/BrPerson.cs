namespace UnitTestDemo
{
    public interface IBrPerson
    {
        DtoPerson GetPerson(int id);
        bool CanDrive(int id);
    }

    public class BrPerson : IBrPerson
    {
        private readonly IPerson _iperson;

        public BrPerson(IPerson person)
        {
            _iperson = person;
        }

        public DtoPerson GetPerson(int id)
        {
            return _iperson.GetPerson(id);
        }

        public bool CanDrive(int id)
        {
            var person = GetPerson(id);
            return person.Age >= 18;
        }
    }
}

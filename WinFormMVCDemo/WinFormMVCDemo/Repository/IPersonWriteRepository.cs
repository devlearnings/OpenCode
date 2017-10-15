using WinFormMVCDemo.Models;

namespace WinFormMVCDemo.Repository
{
    public interface IPersonWriteRepository
    {
        void AddPerson(Person person);
    }
}
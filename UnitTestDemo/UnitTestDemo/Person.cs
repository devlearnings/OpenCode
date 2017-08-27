using System.Linq;
using Dapper;

namespace UnitTestDemo
{
    public interface IPerson
    {
        DtoPerson GetPerson(int id);
    }

    public class Person : BaseData, IPerson
    {
        public DtoPerson GetPerson(int id)
        {
            string qry = "SELECT ID, Name, Age FROM Persons WHERE ID = @ID";
            return connection.Query<DtoPerson>(qry, new { ID = id }).FirstOrDefault();
        }
    }
}

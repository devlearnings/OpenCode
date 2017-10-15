using System.Collections.Generic;
using System.Linq;
using Dapper;
using WinFormMVCDemo.Models;

namespace WinFormMVCDemo.Repository
{
    public class PersonReadRepository : IPersonReadRepository
    {
        public List<Person> GetAllPersons()
        {
            using (var connection = SqlDbConnection.ConnectionFactory())
            {
                connection.Open();

                string query = "SELECT ID, Name, Age, Phone FROM Persons";

                return connection.Query<Person>(query).ToList();
            }
        }
    }
}

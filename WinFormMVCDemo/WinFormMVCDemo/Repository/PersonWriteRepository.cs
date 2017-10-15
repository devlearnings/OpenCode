using System.Data;
using Dapper;
using WinFormMVCDemo.Models;

namespace WinFormMVCDemo.Repository
{
    public class PersonWriteRepository : IPersonWriteRepository
    {
        public void AddPerson(Person person)
        {
            using (var connection = SqlDbConnection.ConnectionFactory())
            {
                connection.Open();

                string query = "INSERT INTO Persons (Name, Age, Phone) VALUES (@Name, @Age, @Phone)";

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Name", person.Name, DbType.String, ParameterDirection.Input);
                parameters.Add("@Age", person.Age, DbType.Int16, ParameterDirection.Input);
                parameters.Add("@Phone", person.Phone, DbType.String, ParameterDirection.Input);

                connection.Execute(query, parameters);
            }
        }
    }
}

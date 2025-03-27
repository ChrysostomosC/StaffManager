using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Database
    {
        private IMongoDatabase GetDb()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("EmployeesDB");
           return db;
        }
        public async Task SaveEmployee(Employee employee)
        {
            await GetDb().GetCollection<Employee>("Employees")
                .InsertOneAsync(employee);
        }
        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = await GetDb().GetCollection<Employee>("Employees")
                .Find(e => true)
                .ToListAsync();
            return employees;
        }
        public async Task<Employee> GetEmployById(string Id)
        {
            ObjectId _Id = new ObjectId(Id);
            var employee = await GetDb().GetCollection<Employee>("Employees")
                .Find(e => e.Id == _Id)
                .SingleOrDefaultAsync();
            return employee;
        }
    }
}

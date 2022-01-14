using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BestBuyBestPractices
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;

        public DapperDepartmentRepository(IDbConnection connection)
            {
            _connection = connection;
        }


        public IEnumerable<Department> GetAllDepartments()
        {
            var depos = _connection.Query<Department>("Select * From departments");

            return depos;
        }

        public void InsertDepartment(string newDepartmentName)
        {
            _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);",
          new { departmentName = newDepartmentName });
            
        }

        internal object GetAllProducts()
        {
            return _connection;
        }
    }
}

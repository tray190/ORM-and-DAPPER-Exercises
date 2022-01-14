using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPractices
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        public DapperProductRepository()
        {
            _connection = _connection;
        }

        public void CreateProduct(string name, double price, int categoryID)
        {
            _connection.Execute("Insert Into products(Name, Price, CategoryID) Values (@name, @price, @categoryID));",
                new { name = name, price = price, categoryID = categoryID }) ;
        }

        public IEnumerable<Product> GetAllProducts()
        {
           return _connection.Query<Product>("Select * From Products");
           
        }
    }
}

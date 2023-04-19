using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebApp.Models;
using WebApp.Models.ViewModel;

namespace WebApp.Data
{
    public class DataService : IDataService
    {
        private readonly IConfiguration _configuration;
        public IDbConnection Connection => new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        public DataService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public EmpProductModel GetData(int empId, int productId)
        {
            using (IDbConnection con = Connection)
            {
                var sql = "GetEmpProduct @EmpId, @productId";
                using (var result = con.QueryMultiple(sql, new
                {
                    empId,
                    productId
                }))
                {
                    var r1 = result.Read<dynamic>();
                    var r2 = result.Read<dynamic>();

                    
                    foreach (dynamic row in r1)
                    {
                        string firstName = row.FirstName;
                        string lastName = row.LastName;
                    
                    }

                    foreach (dynamic row in r2)
                    {
                        string productName = row.ProductName;
                        int catId = row.CatId;
                    }

                    EmpProductModel empProductModel = new EmpProductModel
                    {
                       
                    };

                    return empProductModel;
                }
            }
        }
    }
}
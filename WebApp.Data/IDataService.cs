using WebApp.Models.ViewModel;

namespace WebApp.Data
{
    public interface IDataService
    {
        EmpProductModel GetData(int empId, int productId);
    }
}

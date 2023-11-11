using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Models
{
    public interface ICustomerReponsitory
    {
        void AddEmployee(CustomerModel employeeModel);  
        void UpdateEmployee(CustomerModel customerModel);
        void DeleteEmployee(CustomerModel customerModel);
        void UpdateCustomer(CustomerModel customerModel);
        int checkEmail(string email);
        IEnumerable<CustomerModel> GetAllEmployees();
        IEnumerable<CustomerModel> GetCus(CustomerModel model,int id);
        IEnumerable<CustomerModel> GetInformation(CustomerModel model,int id);
        IEnumerable<StatialModel> GetAllValueWithTopCustomer(int top);
        IEnumerable<CartModel> GetAllValueFollowTime(DateTime start,DateTime end);
    } 
}
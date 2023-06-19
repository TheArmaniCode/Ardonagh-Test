using ArdonaghTest.Models;

namespace ArdonaghTest.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerModel> AddCustomer(List<CustomerModel> inCustomers, string inName, int inAge, string inPostcode, double inHeight);
        List<CustomerModel> EditCustomer(List<CustomerModel> inCustomers, int inCustomerID, string inName, int inAge, string inPostcode, double inHeight);
    }
}

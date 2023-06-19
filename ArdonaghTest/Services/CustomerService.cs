using ArdonaghTest.Interfaces;
using ArdonaghTest.Models;

namespace ArdonaghTest.Services
{
    public class CustomerService : ICustomerService
    {
        public List<CustomerModel> AddCustomer(List<CustomerModel> inCustomers, string inName, int inAge, string inPostcode, double inHeight)
        {
            var newCustomer = new CustomerModel();

            newCustomer.ID = inCustomers.Count;
            newCustomer.Name = inName;
            newCustomer.Age = inAge;
            newCustomer.Postcode = inPostcode;
            newCustomer.Height = inHeight;

            inCustomers.Add(newCustomer);

            return inCustomers;
        }

        public List<CustomerModel> EditCustomer(List<CustomerModel> inCustomers, int inCustomerID, string inName, int inAge, string inPostcode, double inHeight)
        {
            inCustomers[inCustomerID].Name = inName;
            inCustomers[inCustomerID].Age = inAge;
            inCustomers[inCustomerID].Postcode = inPostcode;
            inCustomers[inCustomerID].Height = inHeight;

            return inCustomers;
        }
    }
}

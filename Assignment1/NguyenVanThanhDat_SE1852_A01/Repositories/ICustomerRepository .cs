using BusinessObjects;

namespace Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAllCustomers();
        public void InitializeDataset();
        public Customer? GetCustomerById(int id);
        public Customer? GetCustomerByPhone(string phone);
        public bool SaveCustomer(Customer customer);
        public bool UpdateCustomer(Customer customer);
        public bool DeleteCustomer(int id);
        public List<Customer> SearchCustomers(string keyword);

    }
}

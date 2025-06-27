using BusinessObjects;

namespace Services
{
    internal interface IAuthService
    {
        public Employee? EmployeeLogin(string username, string password);
        public Customer? CustomerLogin(string phone);
        public bool IsEmployeeLoggedIn();
        public bool IsCustomerLoggedIn();
        public Employee? GetCurrentEmployee();
        public Customer? GetCurrentCustomer();
        public void Logout();
    }
}

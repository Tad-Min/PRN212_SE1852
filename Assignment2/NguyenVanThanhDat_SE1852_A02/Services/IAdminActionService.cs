using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IAdminActionService
    {

        #region report
        /// <summary>
        /// Generates a report of orders within the specified date range.
        /// </summary>
        /// <remarks>The method retrieves all orders that fall within the inclusive date range defined by
        /// <paramref name="startDate"/> and <paramref name="endDate"/>. If no orders are found, the method returns <see
        /// langword="null"/> instead of an empty list.</remarks>
        /// <param name="startDate">The start date of the range for which to generate the report. Must be earlier than or equal to <paramref
        /// name="endDate"/>.</param>
        /// <param name="endDate">The end date of the range for which to generate the report. Must be later than or equal to <paramref
        /// name="startDate"/>.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of orders within the
        /// specified date range,  or <see langword="null"/> if no orders are found.</returns>
        Task<List<Order>?> GenerateReport(DateTime startDate, DateTime endDate);
        /// <summary>
        /// Retrieves a list of all orders for reporting purposes.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of  <see cref="Order"/>
        /// objects representing the orders. Returns <see langword="null"/> if no orders are available.</returns>
        Task<List<Order>?> GetAllReport();
        #endregion

        #region profile
        /// <summary>
        /// Retrieves the profile of an employee based on the specified ID.
        /// </summary>
        /// <remarks>Use this method to fetch an employee's profile by their unique ID. If no employee is
        /// found with the given ID, the method returns <see langword="null"/>.</remarks>
        /// <param name="id">The unique identifier of the employee whose profile is to be retrieved. Must be a positive integer.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the employee profile if found;
        /// otherwise, <see langword="null"/>.</returns>
        Task<Employee?> GetProfileId(int id);
        /// <summary>
        /// Updates the profile information of the specified employee.
        /// </summary>
        /// <remarks>This method performs an asynchronous operation to update the employee's profile in
        /// the system.  Ensure that the <paramref name="employee"/> object contains valid and complete data before
        /// calling this method.</remarks>
        /// <param name="employee">The employee whose profile information is to be updated. Cannot be null.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the update
        /// was successful;  otherwise, <see langword="false"/>.</returns>
        Task<bool> UpdateProfile(Employee employee);
        #endregion

        #region Product
        /// <summary>
        /// Adds a new product to the system.
        /// </summary>
        /// <param name="product">The product to add. Must not be null and must contain valid data.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the product
        /// was successfully added; otherwise, <see langword="false"/>.</returns>
        Task<bool> AddProduct(Product product);
        /// <summary>
        /// Retrieves a list of products that match the specified product name.
        /// </summary>
        /// <param name="productName">The name of the product to search for. This parameter cannot be null or empty.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of  <see cref="Product"/>
        /// objects that match the specified name, or <see langword="null"/> if no products are found.</returns>
        Task<List<Product>?> GetAllProducts(string productName);
        /// <summary>
        /// Retrieves a product by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the product to retrieve. Must be a positive integer.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="Product"/>  if
        /// found; otherwise, <see langword="null"/>.</returns>
        Task<Product?> GetProductById(int id);
        /// <summary>
        /// Updates the specified product in the system.
        /// </summary>
        /// <param name="product">The product to update. Must not be <see langword="null"/> and must have a valid identifier.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the product
        /// was successfully updated;  otherwise, <see langword="false"/>.</returns>
        Task<bool> UpdateProduct(Product product);
        /// <summary>
        /// Deletes the product with the specified identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the product to delete. Must be a positive integer.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the product
        /// was successfully deleted;  otherwise, <see langword="false"/> if the product was not found or could not be
        /// deleted.</returns>
        Task<bool> DeleteProductById(int id);
        /// <summary>
        /// Retrieves all categories from the data source.
        /// </summary>
        /// <remarks>The returned list may be empty if there are no categories available in the data
        /// source.</remarks>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of  <see
        /// cref="Category"/> objects representing all categories, or <see langword="null"/> if no categories are found.</returns>
        Task<List<Category>?> GetAllCategories();
        #endregion

        #region order
        Task<bool> DeleteOrder(int id);
        Task<bool> UpdateOrder(Order order);
        Task<Order?> GetOrderById(int id);
        Task<List<Order>?> GetAllOrders();
        Task<bool> AddOrder(Order order);

        Task<bool> DeleteOrderDetailByOIdAndPId(int orderId, int productId);
        Task<bool> UpdateOrderDetail(OrderDetail orderDetail);
        Task<bool> AddOrderDetail(OrderDetail orderDetail);
        Task<OrderDetail?> GetOrderDetailsByOIdAndPIdAsync(int orderId, int productId);
        Task<List<OrderDetail>?> GetAllOrderDetailsByOId(int id);
        #endregion

        #region customer
        Task<List<Customer>?> GetAllCustomers();
        Task<Customer?> GetCustomerById(int id);
        Task<bool> DeleteCustomer(int id);
        Task<bool> UpdateCustomer(Customer customer);
        #endregion

    }
}

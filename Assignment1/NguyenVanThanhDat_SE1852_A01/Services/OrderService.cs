using BusinessObjects;
using Repositories;

namespace Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
            _productRepository = new ProductRepository();
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public void InitializeDataset()
        {
            _orderRepository.InitializeDataset();
        }

        public Order? GetOrderById(int id)
        {
            return _orderRepository.GetOrderById(id);
        }

        public List<Order> GetOrdersByCustomerId(int customerId)
        {
            return _orderRepository.GetOrdersByCustomerId(customerId);
        }

        public List<Order> GetOrdersByEmployeeId(int employeeId)
        {
            return _orderRepository.GetOrdersByEmployeeId(employeeId);
        }

        public bool SaveOrder(Order order)
        {
            if (order.CustomerId == null || order.EmployeeId == null || order.OrderDate == null)
            {
                return false;
            }

            return _orderRepository.SaveOrder(order);
        }

        public bool UpdateOrder(Order order)
        {
            if (order.CustomerId == null || order.EmployeeId == null || order.OrderDate == null)
            {
                return false;
            }

            return _orderRepository.UpdateOrder(order);
        }

        public bool DeleteOrder(int id)
        {
            return _orderRepository.DeleteOrder(id);
        }

        public List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            return _orderRepository.GetOrderDetailsByOrderId(orderId);
        }

        public bool SaveOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail.Quantity <= 0 || orderDetail.UnitPrice <= 0)
            {
                return false;
            }

            return _orderRepository.SaveOrderDetail(orderDetail);
        }

        public bool DeleteOrderDetail(int orderId, int productId)
        {
            return _orderRepository.DeleteOrderDetail(orderId, productId);
        }

        public List<Order> SearchOrders(string keyword)
        {
            return _orderRepository.SearchOrders(keyword);
        }

        public List<Order> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            return _orderRepository.GetAllOrders()
                .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                .OrderByDescending(o => o.OrderDate)
                .ToList();
        }

        public double CalculateOrderTotal(int orderId)
        {
            var orderDetails = GetOrderDetailsByOrderId(orderId);
            double total = 0;

            foreach (var detail in orderDetails)
            {
                double subtotal = detail.UnitPrice * detail.Quantity;
                double discount = subtotal * detail.Discount;
                total += subtotal - discount;
            }

            return total;
        }
    }
}

using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NguyenVanThanhDatWPF
{
    /// <summary>
    /// Interaction logic for OrderHistoryPage.xaml
    /// </summary>
    public partial class OrderHistoryPage : Page
    {
        private readonly AuthService _authService;
        private readonly OrderService _orderService;
        private readonly CustomerService _customerService;

        public OrderHistoryPage(AuthService authService)
        {
            InitializeComponent();

            _authService = authService;
            _orderService = new OrderService();
            _customerService = new CustomerService();

            _orderService.InitializeDataset();
            _customerService.InitializeDataset();

            var currentCustomer = _authService.GetCurrentCustomer();
            if (currentCustomer != null)
            {
                this.Title = $"{currentCustomer.CompanyName} ({currentCustomer.ContactName})";
            }

            LoadOrderHistory();
        }

        private void LoadOrderHistory()
        {
            var currentCustomer = _authService.GetCurrentCustomer();
            if (currentCustomer != null)
            {
                var orders = _orderService.GetOrdersByCustomerId(currentCustomer.CustomerId);
                dgOrderHistory.ItemsSource = orders.Select(order => new
                {
                    order.OrderId,
                    order.OrderDate,
                    TotalAmount = _orderService.CalculateOrderTotal(order.OrderId)
                }).ToList();
            }
        }
    }
}

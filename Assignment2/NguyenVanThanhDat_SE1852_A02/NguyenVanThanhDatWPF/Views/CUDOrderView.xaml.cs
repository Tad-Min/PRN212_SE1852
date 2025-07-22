using BusinessObjects;
using FontAwesome.Sharp;
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

namespace NguyenVanThanhDatWPF.Views
{
    /// <summary>
    /// Interaction logic for CUDOrderView.xaml
    /// </summary>
    public partial class CUDOrderView : UserControl
    {
        private readonly int? _orderId;
        public readonly int? _employeeId;
        private readonly IAdminActionService _service;
        private DateTime timeNow = DateTime.Now;
        public CUDOrderView(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
            _service = new AdminActionService();
            LoadOrder();
        }
        public CUDOrderView(int orderId, int employeeId)
        {
            InitializeComponent();
            _orderId = orderId;
            _employeeId = employeeId;
            _service = new AdminActionService();
            LoadOrder();
        }

        public async void LoadOrder()
        {
            try
            {
                if (_orderId != null) {
                    var order = await _service.GetOrderById(_orderId.Value);
                    if (order == null)
                    {
                        MessageBox.Show("Error  GetOrderById not found: ", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                        Window wd = Window.GetWindow(this);
                        wd.Close();
                    }
                    else
                    {
                        dpViewOrderId.Visibility = Visibility.Visible;
                        dpTypeOrderId.Visibility = Visibility.Collapsed;
                        btnUpdate.Visibility = Visibility.Visible;
                        btnAdd.Visibility = Visibility.Collapsed;

                        txbOrderId.Text = order.OrderId.ToString();
                        cbCustomer.ItemsSource = await _service.GetAllCustomers();
                        cbCustomer.DisplayMemberPath = "CustomerId";
                        cbCustomer.SelectedValuePath = "CustomerId";
                        cbCustomer.SelectedIndex = order.CustomerId;

                        txbEmployee.Text = order.EmployeeId.ToString();
                        txbOrderDate.Text = order.OrderDate.ToString();
                    }
                }
                else
                {
                    dpViewOrderId.Visibility = Visibility.Collapsed;
                    dpTypeOrderId.Visibility = Visibility.Visible;
                    btnUpdate.Visibility = Visibility.Collapsed;
                    btnAdd.Visibility = Visibility.Visible;


                    cbCustomer.ItemsSource = await _service.GetAllCustomers();
                    cbCustomer.DisplayMemberPath = "CustomerId";
                    cbCustomer.SelectedValuePath = "CustomerId";
                    txbEmployee.Text = _employeeId.ToString();
                    txbOrderDate.Text = timeNow.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error LoadOrder: " + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(!int.TryParse(txtOrderId.Text, out var orderId))
                {
                    MessageBox.Show("Error order Id must number", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else
                {
                    if ( await _service.GetOrderById(orderId) != null)
                    {
                        MessageBox.Show("Error order Id existed", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                }

                if (cbCustomer.SelectedValue == null)
                {
                    MessageBox.Show("Please select a Customer Id", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                var isadd = await _service.AddOrder(new Order
                {
                    OrderId = orderId,
                    CustomerId = (int)cbCustomer.SelectedValue,
                    EmployeeId = _employeeId.Value,
                    OrderDate = timeNow
                });
                if (isadd)
                {
                    MessageBox.Show("Add order successfull", "Add order!", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window wd = Window.GetWindow(this);
                    wd.Close();
                }
                else 
                {
                    MessageBox.Show("Add order successfull", "Add order!", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window wd = Window.GetWindow(this);
                    wd.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error add order: " + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                if (_orderId == null)
                {
                    MessageBox.Show("Error  GetOrderById not found: ", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Window wd = Window.GetWindow(this);
                    wd.Close();
                    return;
                }
                Order order = await _service.GetOrderById(int.Parse(_orderId.ToString()??""));
                if (order == null) 
                {
                    MessageBox.Show("Error GetOrderById not found: ", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Window wd = Window.GetWindow(this);
                    wd.Close();
                }
                else
                {
                    if (cbCustomer.SelectedValue == null)
                    {
                        MessageBox.Show("Please select a Customer Id", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    order.EmployeeId = (int)cbCustomer.SelectedValue;
                    var isadd = await _service.UpdateOrder(order);
                    if (isadd == true)
                    {
                        MessageBox.Show("Update order successfull", "Add order!", MessageBoxButton.OK, MessageBoxImage.Information);
                        Window wd = Window.GetWindow(this);
                        wd.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update order successfull", "Add order!", MessageBoxButton.OK, MessageBoxImage.Information);
                        Window wd = Window.GetWindow(this);
                        wd.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error update order: " + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

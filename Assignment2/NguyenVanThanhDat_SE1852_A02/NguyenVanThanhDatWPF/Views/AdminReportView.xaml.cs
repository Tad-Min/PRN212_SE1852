using Services;
using System.Windows;
using System.Windows.Controls;

namespace NguyenVanThanhDatWPF.Views
{
    /// <summary>
    /// Interaction logic for AdminReportView.xaml
    /// </summary>
    public partial class AdminReportView : UserControl
    {
        private readonly IAdminActionService _service;
        public AdminReportView()
        {
            InitializeComponent();
            _service = new AdminActionService();
            LoadReport();

        }
        public async void LoadReport()
        {
            try
            {
                dgReport.Items.Clear();
                var data = await _service.GetAllReport();
                dgReport.ItemsSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Load report detail: \n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private async void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime? start = dpStartDate.SelectedDate;
                DateTime? end = dpEndDate.SelectedDate;
                if (start == null || end == null)
                {
                    MessageBox.Show("Please choose time", "Time!!!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                var orders = await _service.GenerateReport(start ?? new DateTime(0, 0, 0), end ?? new DateTime(0, 0, 0));

                dgReport.ItemsSource = orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generate detail: \n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

using BusinessObjects;
using Services;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NguyenVanThanhDatWPF.Views
{
    /// <summary>
    /// Interaction logic for AdminProfileView.xaml
    /// </summary>
    public partial class AdminProfileView : UserControl
    {
        private readonly IAdminActionService _service;
        private readonly int _employeeId;
        public AdminProfileView(int employeeId)
        {
            InitializeComponent();
            _service = new AdminActionService();
            _employeeId = employeeId;
            LoadEmployee();
        }

        public async void LoadEmployee()
        {
            try
            {
                var employee = await _service.GetProfileId(_employeeId);
                if (employee == null) {
                    MessageBox.Show("Cant load profile", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    txtName.Text = employee.Name;
                    txtJobTitle.Text = employee.JobTitle;
                    txtAddress.Text = employee.Address;
                    dpBirthDate.Text = employee.BirthDate.ToString();

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error LoadEmployee detail: \n " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var name = txtName.Text;
            var jobTitle = txtJobTitle.Text;
            var address = txtAddress.Text;
            DateTime? birthDay = dpBirthDate.SelectedDate;

            if (string.IsNullOrWhiteSpace(name)) 
            {
                MessageBox.Show("Name can not null", "Name Null!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(jobTitle))
            {
                MessageBox.Show("Job Title can not null", "Job Title Null!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address can not null", "address Null!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if(birthDay == null)
            {
                MessageBox.Show("BirthDay can not empty", "address empty!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }else if ( DateTime.Now.Year - birthDay.Value.Year <18 || DateTime.Now.Year - birthDay.Value.Year > 100 )
            {
                MessageBox.Show("Age must >=18 and <100", "Age error!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var employee = await _service.GetProfileId(_employeeId);
            if (employee != null)
            {
                employee.Name = name;
                employee.JobTitle = jobTitle;
                employee.Address = address;
                employee.BirthDate = birthDay;
                var isUpdate = await _service.UpdateProfile(employee);
                if (isUpdate) 
                {
                    MessageBox.Show("Update Complete", "Update!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                MessageBox.Show("Update incomplete", "Update!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBox.Show("Not found your profile", "Empty profile!", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
    }
}

using System.Windows;
using System.Windows.Controls;

namespace NguyenVanThanhDatWPF
{
    /// <summary>
    /// Interaction logic for CUDWindow.xaml
    /// </summary>
    public partial class CUDWindow : Window
    {
        public CUDWindow()
        {
            InitializeComponent();
        }

        public CUDWindow(UserControl content)
        {
            InitializeComponent();
            MainContent.Content = content;
        }
    }
}

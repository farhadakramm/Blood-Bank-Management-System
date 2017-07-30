using System.Windows.Controls;

namespace Blood_Bank_Project_in_WPF
{
    /// <summary>
    /// Interaction logic for view_All.xaml
    /// </summary>
    public partial class view_All : Page
    {

        public view_All()
        {
            InitializeComponent();
            Grid_Frame.Content = new ViewDonorsDataGrid();
        }
        
        private void btn_viewDonors_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Grid_Frame.Content = new ViewDonorsDataGrid();
        }

        private void btn_viewAccepters_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Grid_Frame.Content = new ViewReceiversDataGrid();
        }
    }
}

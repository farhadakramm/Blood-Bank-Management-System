using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Blood_Bank_Project_in_WPF
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            LoadPieChart();
        }

        public List<Blood_Stock> groups { get; set; }
        public void LoadPieChart()
        {
            DataController dc = new DataController();
            groups = dc.SelectBloodStock();
            ((PieSeries)mcChart.Series[0]).ItemsSource = groups;
        }

        //private void LoadPieChartData()
        //{
        //    ((PieSeries)mcChart.Series[0]).ItemsSource =
        //        new KeyValuePair<string, int>[]{
        //    new KeyValuePair<string, int>("O+", 12),
        //    new KeyValuePair<string, int>("O-", 25),
        //    new KeyValuePair<string, int>("A+", 5),
        //    new KeyValuePair<string, int>("A-", 6),
        //    new KeyValuePair<string, int>("B+", 10),
        //    new KeyValuePair<string, int>("B-", 4),
        //    new KeyValuePair<string, int>("AB+", 6),
        //    new KeyValuePair<string, int>("AB-", 10), };
        //}
    }
}

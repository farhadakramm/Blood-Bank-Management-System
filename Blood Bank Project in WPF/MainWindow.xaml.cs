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

namespace Blood_Bank_Project_in_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txt_activeUser.Text = Login_Screen.activeUser;
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            btn_home.Background = Brushes.White;
            btn_home.Foreground = Brushes.Black;
            btn_about.Background = Brushes.CornflowerBlue;
            btn_about.Foreground = Brushes.White;
            btn_addDonor.Background = Brushes.CornflowerBlue;
            btn_addDonor.Foreground = Brushes.White;
            btn_donateBlood.Background = Brushes.CornflowerBlue;
            btn_donateBlood.Foreground = Brushes.White;
            btn_logout.Background = Brushes.CornflowerBlue;
            btn_logout.Foreground = Brushes.White;
            btn_searchPerson.Background = Brushes.CornflowerBlue;
            btn_searchPerson.Foreground = Brushes.White;
            btn_viewAll.Background = Brushes.CornflowerBlue;
            btn_viewAll.Foreground = Brushes.White;
            main_Frame.Content = new Home();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btn_home.Background = Brushes.White;
            btn_home.Foreground = Brushes.Black;
            main_Frame.Content = new Home();
        }

        private void btn_addDonor_Click(object sender, RoutedEventArgs e)
        {
            btn_about.Background = Brushes.CornflowerBlue;
            btn_about.Foreground = Brushes.White;
            btn_addDonor.Background = Brushes.White;
            btn_addDonor.Foreground = Brushes.Black;
            btn_donateBlood.Background = Brushes.CornflowerBlue;
            btn_donateBlood.Foreground = Brushes.White;
            btn_home.Background = Brushes.CornflowerBlue;
            btn_home.Foreground = Brushes.White;
            btn_logout.Background = Brushes.CornflowerBlue;
            btn_logout.Foreground = Brushes.White;
            btn_searchPerson.Background = Brushes.CornflowerBlue;
            btn_searchPerson.Foreground = Brushes.White;
            btn_viewAll.Background = Brushes.CornflowerBlue;
            btn_viewAll.Foreground = Brushes.White;
            main_Frame.Content = new Add_Person();
        }

        private void btn_donateBlood_Click(object sender, RoutedEventArgs e)
        {
            btn_about.Background = Brushes.CornflowerBlue;
            btn_about.Foreground = Brushes.White;
            btn_addDonor.Background = Brushes.CornflowerBlue;
            btn_addDonor.Foreground = Brushes.White;
            btn_donateBlood.Background = Brushes.White;
            btn_donateBlood.Foreground = Brushes.Black;
            btn_home.Background = Brushes.CornflowerBlue;
            btn_home.Foreground = Brushes.White;
            btn_logout.Background = Brushes.CornflowerBlue;
            btn_logout.Foreground = Brushes.White;
            btn_searchPerson.Background = Brushes.CornflowerBlue;
            btn_searchPerson.Foreground = Brushes.White;
            btn_viewAll.Background = Brushes.CornflowerBlue;
            btn_viewAll.Foreground = Brushes.White;
            main_Frame.Content = new Donate_Blood();
        }

        private void btn_searchPerson_Click(object sender, RoutedEventArgs e)
        {
            btn_about.Background = Brushes.CornflowerBlue;
            btn_about.Foreground = Brushes.White;
            btn_addDonor.Background = Brushes.CornflowerBlue;
            btn_addDonor.Foreground = Brushes.White;
            btn_donateBlood.Background = Brushes.CornflowerBlue;
            btn_donateBlood.Foreground = Brushes.White;
            btn_home.Background = Brushes.CornflowerBlue;
            btn_home.Foreground = Brushes.White;
            btn_logout.Background = Brushes.CornflowerBlue;
            btn_logout.Foreground = Brushes.White;
            btn_searchPerson.Background = Brushes.White;
            btn_searchPerson.Foreground = Brushes.Black;
            btn_viewAll.Background = Brushes.CornflowerBlue;
            btn_viewAll.Foreground = Brushes.White;
            main_Frame.Content = new Search_Person();
        }

        private void btn_viewAll_Click(object sender, RoutedEventArgs e)
        {
            btn_about.Background = Brushes.CornflowerBlue;
            btn_about.Foreground = Brushes.White;
            btn_addDonor.Background = Brushes.CornflowerBlue;
            btn_addDonor.Foreground = Brushes.White;
            btn_donateBlood.Background = Brushes.CornflowerBlue;
            btn_donateBlood.Foreground = Brushes.White;
            btn_home.Background = Brushes.CornflowerBlue;
            btn_home.Foreground = Brushes.White;
            btn_logout.Background = Brushes.CornflowerBlue;
            btn_logout.Foreground = Brushes.White;
            btn_searchPerson.Background = Brushes.CornflowerBlue;
            btn_searchPerson.Foreground = Brushes.White;
            btn_viewAll.Background = Brushes.White;
            btn_viewAll.Foreground = Brushes.Black;
            main_Frame.Content = new view_All();
        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            Login_Screen lgs = new Login_Screen();
            this.Close();
            lgs.Show();
        }

        private void btn_about_Click(object sender, RoutedEventArgs e)
        {
            About a = new About();
            a.Show();
        }
    }
}

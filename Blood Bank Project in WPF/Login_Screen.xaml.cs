using DataAccessLayer;
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
using System.Windows.Shapes;

namespace Blood_Bank_Project_in_WPF
{
    /// <summary>
    /// Interaction logic for Login_Screen.xaml
    /// </summary>
    public partial class Login_Screen : Window
    {
        public static string activeUser;

        DataController dc = new DataController();
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void btn_singin_click(object sender, RoutedEventArgs e)
        {
            Member member = dc.SelectLoginMember(txt_name.Text.Trim(), txt_pass.Password.Trim());
            if(member != null)
            {
                activeUser = txt_name.Text;
                MainWindow m = new MainWindow();
                    this.Close();
                    m.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_forgetpass_Click(object sender, RoutedEventArgs e)
        {
            Forget_Password fg = new Forget_Password();
            this.Close();
            fg.Show();
        }

        private void btn_signup_Click(object sender, RoutedEventArgs e)
        {
            SignUp sup = new SignUp();
            this.Close();
            sup.Show();
        }
        
    }
}

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
    /// Interaction logic for Forget_Password.xaml
    /// </summary>
    public partial class Forget_Password : Window
    {
        DataController dc = new DataController();
        public Forget_Password()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            Login_Screen lg = new Login_Screen();
            this.Close();
            lg.Show();
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            Member member = dc.SelectFrogotPasswordMember(txt_name.Text.Trim(), txt_email.Text.Trim());
            if (member != null)
            {
                bool updated = dc.updatePassword(txt_email.Text.Trim(), txt_newPassword.Password);
                if(updated)
                {
                    MessageBox.Show("Password Changed Successfully", "Password Changed", MessageBoxButton.OK, MessageBoxImage.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("An Error Occured while Changing Password Please Try again Later", "Password Change Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Email", "Password Change Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void clear()
        {
            txt_email.Text = "";
            txt_name.Text = "";
            txt_newPassword.Password = "";
        }
    }
}

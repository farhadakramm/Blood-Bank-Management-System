using System.Windows;
using DataAccessLayer;

namespace Blood_Bank_Project_in_WPF
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            Login_Screen lg = new Login_Screen();
            this.Hide();
            lg.Show();
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            Member m = new Member();
            m.MemberName = txt_name.Text.Trim();
            m.MemberEmail = txt_email.Text.Trim();
            m.MemberPhone = txt_mobile.Text.Trim();
            m.MemberPassword = txt_password.Password;
            DataController dc = new DataController();
            if (dc.NewMemberSignup(m))
            {
                MessageBox.Show("User Signed Up Successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Sign Up Error");
            }
        }

        public void clear()
        {
            txt_name.Text = "";
            txt_mobile.Text = "";
            txt_email.Text = "";
            txt_password.Password = "";
        }
    }
}

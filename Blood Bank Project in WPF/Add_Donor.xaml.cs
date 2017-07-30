using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Blood_Bank_Project_in_WPF
{
    /// <summary>
    /// Interaction logic for Add_Person.xaml
    /// </summary>
    public partial class Add_Person : Page
    {
        public Add_Person()
        {
            InitializeComponent();
            addBloodType();
            addEyeColors();
        }

        private void btn_clearall_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }
        
        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            String stid = donor_bloodGroup.Text;

            Donor d = new Donor();
            d.Donor_Name = donor_name.Text;
            d.Donor_Fname = donor_fname.Text;
            d.Donor_Age = (int) donor_age.Value;
            d.Donor_DOB = (DateTime) dpicker_dob.Value;
            d.Donor_Phone = donor_mobile.Text;
            d.Donor_Gender = (bool)donor_gender_male.IsChecked ? "Male" : "Female";
            d.Donor_CNIC = donor_cnic.Text;
            d.Donor_Email = donor_email.Text;
            d.Donor_City = donor_city.Text;
            d.Donor_Address = new TextRange(donor_address.Document.ContentStart, donor_address.Document.ContentEnd).Text;
            d.Donor_Height = (float) donor_height.Value;
            d.Blood_Type_ID = int.Parse(donor_bloodGroup.SelectedValue.ToString());
            d.Eye_Color_ID = int.Parse(donor_eyecolor.SelectedValue.ToString());
            d.Stock_ID = donor_bloodGroup.Text;
            d.donatedBefore = (bool)donated_before_yes.IsChecked ? "True" : "False";
            d.Donor_Disease = donor_disease.Text;
            d.donatedBefore_Date = (DateTime)dp_donationDate.Value;
            d.isSelfDonated =(bool) cb_isSelfDonated.IsChecked ? "True" : "False";

            DataController dc = new DataController();
            if(dc.InsertDonor(d))
            {
                MessageBox.Show("Donor Added Successfully");
                
                clear();
            }
            else
            {
                MessageBox.Show("Insertion Error");
            }
        }

        public void clear()
        {
            donor_name.Text = "";
            donor_mobile.Text = "";
            donor_height.Value = donor_height.Minimum;
            donor_gender_male.IsChecked = true;
            donor_email.Text = "";
            donor_fname.Text = "";
            donor_eyecolor.SelectedIndex = 0;
            donor_disease.Text = "";
            donor_cnic.Text = "";
            donor_city.Text = "";
            donor_bloodGroup.SelectedIndex = 0;
            donor_age.Value = donor_age.Minimum;
            donor_address.Document.Blocks.Clear();
            donated_before_yes.IsChecked = true;
            dp_donationDate.Value = dp_donationDate.DefaultValue;
            dpicker_dob.Value = dpicker_dob.DefaultValue;
            cb_isSelfDonated.IsChecked = false;
        }

        public List<Blood_Group> groups { get; set; }
        public void addBloodType()
        {
            DataController dc = new DataController();
            groups = dc.SelectAllBloodGroups();
            donor_bloodGroup.ItemsSource = groups;
        }

        public List<Eye_Color> colors { get; set; }
        public void addEyeColors()
        {
            DataController dc = new DataController();
            colors = dc.SelectAllEyeColors();
            donor_eyecolor.ItemsSource = colors;
        }
    }
}

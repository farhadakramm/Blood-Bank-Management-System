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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Blood_Bank_Project_in_WPF
{
    /// <summary>
    /// Interaction logic for ViewDonorsDataGrid.xaml
    /// </summary>
    public partial class ViewDonorsDataGrid : Page
    {
        DataController dc = new DataController();
        public ViewDonorsDataGrid()
        {
            InitializeComponent();
            viewDonors();
        }

        public void viewDonors()
        {


            //Name Column
            DataGridTextColumn cl_name = new DataGridTextColumn();
            cl_name.Header = "Name";
            cl_name.Binding = new Binding("Donor_Name");
            cl_name.Width = DataGridLength.Auto;
            cl_name.IsReadOnly = true;

            //Father Name Column
            DataGridTextColumn cl_fname = new DataGridTextColumn();
            cl_fname.Header = "Father Name";
            cl_fname.Binding = new Binding("Donor_Fname");
            cl_fname.Width = DataGridLength.Auto;
            cl_fname.IsReadOnly = true;

            //Age Column
            DataGridTextColumn cl_age = new DataGridTextColumn();
            cl_age.Header = "Age";
            cl_age.Binding = new Binding("Donor_Age");
            cl_age.Width = DataGridLength.Auto;
            cl_age.IsReadOnly = true;

            //Gender Column
            DataGridTextColumn cl_gender = new DataGridTextColumn();
            cl_gender.Header = "Gender";
            cl_gender.Binding = new Binding("Donor_Gender");
            cl_gender.Width = DataGridLength.Auto;
            cl_gender.IsReadOnly = true;

            //CNIC Column
            DataGridTextColumn cl_cnic = new DataGridTextColumn();
            cl_cnic.Header = "CNIC";
            cl_cnic.Binding = new Binding("Donor_CNIC");
            cl_cnic.Width = DataGridLength.Auto;
            cl_cnic.IsReadOnly = true;

            //Email Name Column
            DataGridTextColumn cl_email = new DataGridTextColumn();
            cl_email.Header = "Email";
            cl_email.Binding = new Binding("Donor_Email");
            cl_email.Width = DataGridLength.Auto;
            cl_email.IsReadOnly = true;

            //Phone Column
            DataGridTextColumn cl_phone = new DataGridTextColumn();
            cl_phone.Header = "Phone";
            cl_phone.Binding = new Binding("Donor_Phone");
            cl_phone.Width = DataGridLength.Auto;
            cl_phone.IsReadOnly = true;

            //Blood Group Column
            DataGridTextColumn cl_bgroup = new DataGridTextColumn();
            cl_bgroup.Header = "Blood_Group";
            cl_bgroup.Binding = new Binding("Stock_ID");
            cl_bgroup.Width = DataGridLength.Auto;
            cl_bgroup.IsReadOnly = true;

            //City Column
            DataGridTextColumn cl_city = new DataGridTextColumn();
            cl_city.Header = "City";
            cl_city.Binding = new Binding("Donor_City");
            cl_city.Width = DataGridLength.Auto;
            cl_city.IsReadOnly = true;

            //Address Column
            DataGridTextColumn cl_address = new DataGridTextColumn();
            cl_address.Header = "Address";
            cl_address.Binding = new Binding("Donor_Address");
            cl_address.Width = DataGridLength.Auto;
            cl_address.IsReadOnly = true;

            //Adding Columns to Grid
            dg_viewAll.Columns.Add(cl_name);
            dg_viewAll.Columns.Add(cl_fname);
            dg_viewAll.Columns.Add(cl_age);
            dg_viewAll.Columns.Add(cl_gender);
            dg_viewAll.Columns.Add(cl_cnic);
            dg_viewAll.Columns.Add(cl_email);
            dg_viewAll.Columns.Add(cl_phone);
            dg_viewAll.Columns.Add(cl_bgroup);
            dg_viewAll.Columns.Add(cl_city);
            dg_viewAll.Columns.Add(cl_address);

            //Adding the Donors from dtabase to a list and setting Itemsource
            List<Donor> donorList = dc.SelectAllDonors();
            dg_viewAll.ItemsSource = null;
            dg_viewAll.ItemsSource = donorList;
            dg_viewAll.Items.Refresh();
        }
    }
}

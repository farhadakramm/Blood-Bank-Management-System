using DataAccessLayer;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Data;

namespace Blood_Bank_Project_in_WPF
{
    /// <summary>
    /// Interaction logic for ViewReceiversDataGrid.xaml
    /// </summary>
    public partial class ViewReceiversDataGrid : Page
    {
        DataController dc = new DataController();
        public ViewReceiversDataGrid()
        {
            InitializeComponent();
            viewRecievers();
        }

        public void viewRecievers()
        {

            //Name Column
            DataGridTextColumn cl_name = new DataGridTextColumn();
            cl_name.Header = "Name";
            cl_name.Binding = new Binding("Receiver_Name");
            cl_name.Width = DataGridLength.Auto;
            cl_name.IsReadOnly = true;

            //Name Column
            DataGridTextColumn cl_fname = new DataGridTextColumn();
            cl_fname.Header = "Father Name";
            cl_fname.Binding = new Binding("Receiver_Fname");
            cl_fname.Width = DataGridLength.Auto;
            cl_fname.IsReadOnly = true;

            //Father Name Column
            DataGridTextColumn cl_cnic = new DataGridTextColumn();
            cl_cnic.Header = "CNIC";
            cl_cnic.Binding = new Binding("Receiver_CNIC");
            cl_cnic.Width = DataGridLength.Auto;
            cl_cnic.IsReadOnly = true;

            //Phone Column
            DataGridTextColumn cl_phone = new DataGridTextColumn();
            cl_phone.Header = "Phone";
            cl_phone.Binding = new Binding("Receiver_Phone");
            cl_phone.Width = DataGridLength.Auto;
            cl_phone.IsReadOnly = true;

            //Blood Group Column
            DataGridTextColumn cl_bQuantity = new DataGridTextColumn();
            cl_bQuantity.Header = "Donated Blood Quantity";
            cl_bQuantity.Binding = new Binding("Blood_Amount");
            cl_bQuantity.Width = DataGridLength.Auto;
            cl_bQuantity.IsReadOnly = true;

            //City Column
            DataGridTextColumn cl_donaionDate = new DataGridTextColumn();
            cl_donaionDate.Header = "Donation Date";
            cl_donaionDate.Binding = new Binding("Donation_Date");
            cl_donaionDate.Width = DataGridLength.Auto;
            cl_donaionDate.IsReadOnly = true;

            //Address Column
            DataGridTextColumn cl_disease = new DataGridTextColumn();
            cl_disease.Header = "Disease";
            cl_disease.Binding = new Binding("Disease");
            cl_disease.Width = DataGridLength.SizeToCells;
            cl_disease.IsReadOnly = true;

            //Adding Columns to Grid
            dg_viewAll.Columns.Add(cl_name);
            dg_viewAll.Columns.Add(cl_fname);
            dg_viewAll.Columns.Add(cl_cnic);
            dg_viewAll.Columns.Add(cl_phone);
            dg_viewAll.Columns.Add(cl_bQuantity);
            dg_viewAll.Columns.Add(cl_donaionDate);
            dg_viewAll.Columns.Add(cl_disease);

            //Adding the Donors from dtabase to a list and setting Itemsource
            List<Receiver> recieverList = dc.SelectAllReceivers();
            dg_viewAll.ItemsSource = recieverList;
            dg_viewAll.Items.Refresh();
        }
    }
}

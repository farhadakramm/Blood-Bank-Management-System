using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Blood_Bank_Project_in_WPF
{
    /// <summary>
    /// Interaction logic for Donate_Blood.xaml
    /// </summary>
    public partial class Donate_Blood : Page
    {
        DataController dc = new DataController();
        int donorID , recID;
        string donorEmailAddress;
        string donorStockID;
        string recieverName;
        string donorStockID2;

        public Donate_Blood()
        {
            InitializeComponent();
            addBloodType();
        }

        public List<Blood_Group> groups { get; set; }
        public void addBloodType()
        {
            List<Blood_Group> groups = dc.SelectAllBloodGroups();
            combo_bloodGroup.ItemsSource = groups;   
        }

        public void viewDonorListForDonation()
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

            //Blood Group Column
            DataGridTextColumn cl_bgroup = new DataGridTextColumn();
            cl_bgroup.Header = "Blood Group";
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

            //Adding Colums to dataGrid
            dg_donatetodonor.Columns.Add(cl_name);
            dg_donatetodonor.Columns.Add(cl_fname);
            dg_donatetodonor.Columns.Add(cl_age);
            dg_donatetodonor.Columns.Add(cl_gender);
            dg_donatetodonor.Columns.Add(cl_bgroup);
            dg_donatetodonor.Columns.Add(cl_city);
            dg_donatetodonor.Columns.Add(cl_address);

            //Getting the selected value and assigning the item source
            string group = combo_bloodGroup.Text;
            List<Donor> donors = dc.SelectDonorForABloodGroup(group);
            dg_donatetodonor.ItemsSource = donors;
        }


        //Method to Search Against the entered Name of the Donor and populate the Datagrid
        public void SelectDonorByName()
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

            //Blood Group Column
            DataGridTextColumn cl_bgroup = new DataGridTextColumn();
            cl_bgroup.Header = "Blood Group";
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

            //Adding Colums to dataGrid
            dGrid_addBlood_donorSearch.Columns.Add(cl_name);
            dGrid_addBlood_donorSearch.Columns.Add(cl_fname);
            dGrid_addBlood_donorSearch.Columns.Add(cl_age);
            dGrid_addBlood_donorSearch.Columns.Add(cl_gender);
            dGrid_addBlood_donorSearch.Columns.Add(cl_bgroup);
            dGrid_addBlood_donorSearch.Columns.Add(cl_city);
            dGrid_addBlood_donorSearch.Columns.Add(cl_address);

            //Getting the selected value and assigning the item source
            string name = txt_donorName.Text;
            List<Donor> donorsByName = dc.SelectDonorForAName(name);
            dGrid_addBlood_donorSearch.ItemsSource = donorsByName;
        }


        //Method to get the selected Row ID using the Selection Changed Method of the Datagrid  
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is Donor)
            {
                donorID = ((e.AddedItems[0] as Donor).DonorID);
                donorEmailAddress = ((e.AddedItems[0] as Donor).Donor_Email.ToString());
                donorStockID = ((e.AddedItems[0] as Donor).Stock_ID);
            }
        }
        

        //Method to Search Donors Against Entered Name
        private void btn_addBlood_donorSearch_Click(object sender, RoutedEventArgs e)
        {
            dGrid_addBlood_donorSearch.Columns.Clear();
            SelectDonorByName();
        }


        //Method to search Donor against Selected Blood Group
        private void btn_SearchByGroup_Click(object sender, RoutedEventArgs e)
        {
            dg_donatetodonor.Columns.Clear();
            viewDonorListForDonation();
        }

        private void dGrid_addBlood_donorSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.AddedItems.Count > 0 && e.AddedItems[0] is Donor)
            {
                txt_donorinfoName.Text = ((e.AddedItems[0] as Donor).Donor_Name.ToString());
                txt_donorinfoEmail.Text = ((e.AddedItems[0] as Donor).Donor_Email.ToString());
                txt_donorinfoDisease.Text = ((e.AddedItems[0] as Donor).Donor_Disease.ToString());

                donorStockID2 = ((e.AddedItems[0] as Donor).Stock_ID.ToString());
            }
        }

        private void btn_doanteBlood_Click(object sender, RoutedEventArgs e)
        {
            Receiver r = new Receiver();
            r.Receiver_Name = txt_accepterName.Text;
            r.Receiver_Fname = txt_accepterFatherName.Text;
            r.Receiver_Phone = txt_accepterContact.Text;
            r.Receiver_CNIC = txt_accepterCNIC.Text;
            r.Blood_Amount = (int) ud_donationBloodAmount.Value;
            r.Donation_Date = (DateTime) dp_acceptanceDate.Value;
            r.Disease = txt_accepterDisease.Text;
            r.Donor_ID = donorID;

            recieverName = txt_accepterName.Text;
            Receiver re = dc.SelectReceiverForAName(recieverName);
            recID = re.Receiver_ID;

            Donated_Blood donatedBlood = new Donated_Blood();
            donatedBlood.Donor_ID = donorID;
            donatedBlood.Receiver_ID = recID;
            dc.InsertIntoDonatedBlood(donatedBlood);

            if (dc.InsertReceiver(r))
            {
                sendEmail(donorEmailAddress , txt_accepterName.Text);
                dc.updateBloodStockSubtracting(donorStockID, (int) ud_donationBloodAmount.Value);
                MessageBox.Show("Blood Donated Successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Insertion Error");
            }
        }

        private void btn_doanteClear_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txt_accepterName.Text = "";
            txt_accepterFatherName.Text = "";
            txt_accepterContact.Text = "";
            txt_accepterCNIC.Text = "";
            ud_donationBloodAmount.Value = ud_donationBloodAmount.Minimum;
            txt_accepterDisease.Text = "";
            dp_acceptanceDate.Value = dp_acceptanceDate.DefaultValue;
        }

        public void sendEmail(string email, String recName)
        {
            MailMessage mail = new MailMessage("farhadbhatti95@gmail.com", email, "BloodLine BloodBank appreceation Message", "the Blood You had donated is now donated to the "+recName+" successfully. Our Team and The Receiver appresiate your donation. Thaks Alot");
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("farhadbhatti95@gmail.com", "farhad3112");
            client.EnableSsl = true;
            client.Send(mail);
        }
        

        private void btn_addBlood_Click(object sender, RoutedEventArgs e)
        {
           
            bool updated =  dc.updateBloodStockAdding(donorStockID2, (int)up_donorBloodQuantity.Value);
            if(updated)
            {
                MessageBox.Show("Blood Donated SuccessFully", "Donation Made", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("There was an Error While Donation", "Donation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Clear();
        }

       public void Clear()
        {
            txt_donorinfoName.Text = "";
            txt_donorinfoEmail.Text = "";
            txt_donorinfoDisease.Text = "";
            up_donorBloodQuantity.Value = up_donorBloodQuantity.Minimum;
        }
    }
}

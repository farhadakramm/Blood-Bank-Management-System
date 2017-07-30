using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    class BloodBankDA
    {
        //Database Instance
        BloodBankDatabaseEntities db;


        //Constructor
        public BloodBankDA()
        {
            db = new BloodBankDatabaseEntities();
        }


        //Method for Selecting all members from Mmeber Table
        public List<Member> SelectAllMembers()
        {
            return db.Members.ToList();
        }


        //Method for Selecting all Donors from Donor Table
        public List<Donor> SelectAllDonors()
        {
            return db.Donors.ToList();
        }

        //Method for Selecting all Receivers from Donor Table
        public List<Receiver> SelectAllReceivers()
        {
            return db.Receivers.ToList();
        }


        //Method to insert a new Donor in Donor Table
        public bool InsertDonor(Donor d)
        {
            db.Donors.Add(d);
            return db.SaveChanges() > 0 ? true : false;
        }


        //Method to select all Blood Groups from Blood_Group Table in order to populate the Combobox
        public List<Blood_Group> SelectAllBloodGroups()
        {
            return db.Blood_Group.ToList();
        }


        //Method to Select Blood Stock in a List for Pie Chart
        public List<Blood_Stock> SelectBloodStock()
        {
            return db.Blood_Stock.ToList();
        }


        //Method to select all Eye Colors from Eye_Color Table in order to populate the Combobox
        public List<Eye_Color> SelectAllEyeColors()
        {
            return db.Eye_Color.ToList();
        }


        //Method to select the member form Member table who is trying to sign in 
        public Member SelectLoginMemebr(string user, string pass)
        {
            return db.Members.Where(x => (x.MemberName == user && x.MemberPassword == pass)).FirstOrDefault();
        }


        //MEthod to add a new Member through Sign Up in Member Table
        public bool NewMemberSignup(Member m)
        {
            db.Members.Add(m);
            return db.SaveChanges() > 0 ? true : false;

        }


        //Method to get the Member Details from Member table for changing the password
        public Member SelectFrogotPasswordMember(string user, string email)
        {
            return db.Members.Where(x => (x.MemberName == user && x.MemberEmail == email)).FirstOrDefault();
        }

        //Method to get Donor List matching a BloodType
        public List<Donor> SelectDonorForABloodGroup(string bgroup)
        {
            return db.Donors.Where(x => (x.Stock_ID == bgroup)).ToList();
        }

        //Method to get Donor List matching a Name
        public List<Donor> SelectDonorForAName(string name)
        {
            return db.Donors.Where(x => (x.Donor_Name == name)).ToList();
        }

        //Method to get Receiver List matching a Name
        public Receiver SelectReceiverForAName(string name)
        {
            return db.Receivers.Where(x => (x.Receiver_Name == name)).FirstOrDefault();
        }

        //Method to get Donor List matching an Age
        public List<Donor> SelectDonorForAge(int age)
        {
            return db.Donors.Where(x => (x.Donor_Age == age)).ToList();
        }

        //Method to get Donor List matching a Location
        public List<Donor> SelectDonorForLocation(string location)
        {
            return db.Donors.Where(x => (x.Donor_City == location)).ToList();
        }

        public bool InsertReceiver(Receiver r)
        {
            db.Receivers.Add(r);
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool InsertIntoDonatedBlood(Donated_Blood donatedBlood)
        {
            db.Donated_Blood.Add(donatedBlood);
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool updateBloodStockAdding(string ID , int quantity)
        {
            var stock = db.Blood_Stock.Where(x => x.Stock_ID_BType == ID).FirstOrDefault();
            if (stock != null)
            {
                stock.Blood_Quantity += quantity;
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        //Method to update Password
        public bool updatePassword(string email, string pass)
        {
            var member = db.Members.Where(x => x.MemberEmail  == email).FirstOrDefault();
            if (member != null)
            {
                member.MemberPassword = pass;
            }
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool updateBloodStockSubtracting(string ID, int quantity)
        {
            var stock = db.Blood_Stock.Where(x => x.Stock_ID_BType == ID).FirstOrDefault();
            if(stock != null)
            {
                stock.Blood_Quantity -= quantity;
            }
            return db.SaveChanges() > 0 ? true : false;
        }
    }
}

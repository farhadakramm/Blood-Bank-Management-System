using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataController
    {
        BloodBankDA bloodDA;

        public DataController()
        {
            bloodDA = new BloodBankDA();
        }

        public List<Member> SelectAllMembers()
        {
            return bloodDA.SelectAllMembers();
        }
        

        public List<Donor> SelectAllDonors()
        {
            return bloodDA.SelectAllDonors();
        }

        public List<Receiver> SelectAllReceivers()
        {
            return bloodDA.SelectAllReceivers();
        }


        public bool InsertReceiver(Receiver r)
        {
            return bloodDA.InsertReceiver(r);
        }

        public bool InsertDonor(Donor d)
        {
            return bloodDA.InsertDonor(d);
        }

        public bool NewMemberSignup(Member m)
        {
            return bloodDA.NewMemberSignup(m);

        }

        public List<Blood_Group> SelectAllBloodGroups()
        {
            return bloodDA.SelectAllBloodGroups();
        }

        public List<Eye_Color> SelectAllEyeColors()
        {
            return bloodDA.SelectAllEyeColors();
        }

        public List<Donor> SelectDonorForABloodGroup(String bgroup)
        {
            if (bloodDA.SelectDonorForABloodGroup(bgroup) == null)
            {
                return null;
            }
            else
            {
                return bloodDA.SelectDonorForABloodGroup(bgroup).ToList();
            }
        }

        public List<Donor> SelectDonorForAge(int age)
        {
            if (bloodDA.SelectDonorForAge(age) == null)
            {
                return null;
            }
            else
            {
                return bloodDA.SelectDonorForAge(age).ToList();
            }
        }

        public List<Donor> SelectDonorForLocation(string location)
        {
            if (bloodDA.SelectDonorForLocation(location) == null)
            {
                return null;
            }
            else
            {
                return bloodDA.SelectDonorForLocation(location).ToList();
            }
        }

        public List<Donor> SelectDonorForAName(String name)
        {
            if (bloodDA.SelectDonorForAName(name) == null)
            {
                return null;
            }
            else
            {
                return bloodDA.SelectDonorForAName(name).ToList();
            }
        }

        public Member SelectLoginMember(String user, String pass)
        {
            if(bloodDA.SelectLoginMemebr(user , pass) == null)
            {
                return null;
            }
            else
            {
                return bloodDA.SelectLoginMemebr(user, pass);
            }
        }

        public Member SelectFrogotPasswordMember(String user, String email)
        {
            if (bloodDA.SelectFrogotPasswordMember(user, email) == null)
            {
                return null;
            }
            else
            {
                return bloodDA.SelectFrogotPasswordMember(user,email);
            }
        }

        public List<Blood_Stock> SelectBloodStock()
        {
            return bloodDA.SelectBloodStock();
        }

        public bool updateBloodStockSubtracting(string ID, int quantity)
        {
            return bloodDA.updateBloodStockSubtracting(ID,quantity);
        }

        public bool updateBloodStockAdding(string ID, int quantity)
        {
            return bloodDA.updateBloodStockAdding(ID, quantity);
        }

        public bool updatePassword(string email, string pass)
        {
            return bloodDA.updatePassword(email, pass);
        }

        public Receiver SelectReceiverForAName(String name)
        {
            if (bloodDA.SelectReceiverForAName(name) == null)
            {
                return null;
            }
            else
            {
                return bloodDA.SelectReceiverForAName(name);
            }
        }

        public bool InsertIntoDonatedBlood(Donated_Blood donatedBlood)
        {
            return bloodDA.InsertIntoDonatedBlood(donatedBlood);
        }
    }
}

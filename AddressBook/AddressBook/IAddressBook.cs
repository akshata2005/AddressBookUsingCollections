using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    interface IAddressBook
    {
        public void AddContact(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string emailAddress);
        public void DisplayContact();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreateAddressBook : IAddressBook
    {
        private Dictionary<string, Contacts> addressBook = new Dictionary<string, Contacts>();
        public void AddContact(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string emailAddress)
        {
            Contacts contact = new Contacts();
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            contact.Zip = zip;
            contact.Email = emailAddress;
            contact.PhoneNumber = phoneNumber;
            addressBook.Add(contact.FirstName, contact);
        }
        public void DisplayContact()
        {
            foreach (KeyValuePair<string, Contacts> pair in addressBook)
            {
                Console.WriteLine("First Name : " + pair.Value.FirstName);
                Console.WriteLine("Address : " + pair.Value.Address);
                Console.WriteLine("City : " + pair.Value.City);
                Console.WriteLine("State : " + pair.Value.State);
                Console.WriteLine("Zip : " + pair.Value.Zip);
                Console.WriteLine("Phone Number : " + pair.Value.PhoneNumber);
                Console.WriteLine("Email : " + pair.Value.Email + "\n");
            }
   
        }
    }
}

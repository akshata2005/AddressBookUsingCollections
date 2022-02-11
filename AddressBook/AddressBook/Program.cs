using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Address Book System...!");
            CreateAddressBook addressBook = new CreateAddressBook();
            addressBook.AddContact("Kunal", "Sharma", "Dadar", " Mumbai", "Maharashtra", 400084, 9632587321, "kunal@gmail.com");
            addressBook.DisplayContact();
        }
    }
}

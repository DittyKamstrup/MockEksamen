using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen
{
    public class Owner
    {
        //AUTO PROPERTIES
        public string Address { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        
        //CONSTRUCTOR
        public Owner(string address, string name, string phone)
        {
            Address = address;
            Name = name;
            Phone = phone;

            if (address.Length < 6)
            {
                throw new ArgumentOutOfRangeException("Addresse skal være på minimum 6 tegn!");
            }

            if (name.Length < 4)
            {
                throw new ArgumentOutOfRangeException("Navn skal have minimum 4 tegn!");
            }

            if (phone.Length < 8 || phone.Length > 8)
            {
                throw new ArgumentOutOfRangeException("TelefonNr skal være på 8 tegn!");
            }
        }


    }
}

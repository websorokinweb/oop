using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.Classes
{
    internal class Address
    {
        public string city;
        public string street;
        public string houseNumber;
        public string postalCode;
        public string getAddress()
        {
            return $"{city}, {street}, {houseNumber}, {postalCode}";
        }

        public Address(string city, string street, string houseNumber, string postalCode)
        {
            this.city = city;
            this.street = street;
            this.houseNumber = houseNumber;
            this.postalCode = postalCode;
        }
    }
}

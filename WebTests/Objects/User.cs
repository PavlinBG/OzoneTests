using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTests.Objects
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public User(string firstName, string lastName, string email, string address, string city, string zipCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            City = city;
            ZipCode = zipCode;
        }
    }
}
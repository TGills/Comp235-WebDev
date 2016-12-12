using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab01{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private Address address;
        public Person(string firstName, string lastName, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }
        public Person(string firstName, string lastName, string phoneNumber, Address address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.phoneNumber = phoneNumber;
            this.ContactAddress = address;
        }
        public Address ContactAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


    }    
}
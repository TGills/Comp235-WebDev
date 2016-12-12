using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab01
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set;}           

        public Address(string txtStreet, string txtCity, string txtState, string txtZip)
        {
            Street = txtStreet;
            City = txtCity;
            State = txtState;
            Zip = txtZip;
        } 
    }
}
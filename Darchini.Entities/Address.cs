﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Darchini.Entities
{
    public class Address
    {
        public Address()
        {

        }
        public Address(string street, string locality, string city, string zipcode)
        {
            Street = street;
            Locality = locality;
            City = city;
            ZipCode = zipcode;
        }
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public int UserId { get; set; }
    }
}

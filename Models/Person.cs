﻿using System;
namespace redpostgres07.Models
{
    public class Person
    {
        public Person()
        {
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAddress { get; set; }
    }
}

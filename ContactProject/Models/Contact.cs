﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace ContactProject.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhonePrimary { get; set; }
        public string PhoneSecondary { get; set; }
        [DbDateRange]
        public DateTime? Birthday { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class DbDateRangeAttribute
    : RangeAttribute
    {
        public DbDateRangeAttribute()
            : base(typeof(DateTime), SqlDateTime.MinValue.Value.ToShortDateString(), SqlDateTime.MaxValue.Value.ToShortDateString())
        { }
    }
}
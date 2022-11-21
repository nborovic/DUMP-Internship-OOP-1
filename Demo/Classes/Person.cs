using System;
using System.Collections.Generic;
using DUMP_Internship_OOP_1.Enums;

namespace DUMP_Internship_OOP_1.Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<DrivingLicenseCategory> DrivingLicenseCategories { get; set; }
    }
}
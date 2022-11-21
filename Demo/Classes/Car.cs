using System;
using DUMP_Internship_OOP_1.Enums;

namespace DUMP_Internship_OOP_1.Classes
{
    public class Car
    {
        public Guid Id { get; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearOfManufacture { get; }
        public DateTime RegistrationEndDate { get; private set; }
        public DateTime InsuranceEndDate { get; private set; }
        public Person Owner { get; set; }

        public Car(int yearOfManufacture)
        {
            Id = Guid.NewGuid();
            YearOfManufacture = yearOfManufacture;
        }
        
        public bool CheckIsRegistered()
        {
            return RegistrationEndDate > DateTime.Now;
        }

        public bool CheckIsInsured()
        {
            return InsuranceEndDate > DateTime.Now;
        }

        public bool Register()
        {
            if (RegistrationEndDate > DateTime.Now) return false;

            RegistrationEndDate = DateTime.Now.AddYears(1);
            return true;
        }

        public bool Insure(int insuranceDurationInMonths)
        {
            if (InsuranceEndDate > DateTime.Now || RegistrationEndDate <= DateTime.Now) return false;

            InsuranceEndDate = DateTime.Now.AddMonths(insuranceDurationInMonths);
            return true;
        }
    }
}
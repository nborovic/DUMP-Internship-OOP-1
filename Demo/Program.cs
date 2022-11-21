using System;
using System.Collections.Generic;
using DUMP_Internship_OOP_1.Classes;
using DUMP_Internship_OOP_1.Enums;

namespace Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var car = new Car(2004)
            {
                Manufacturer = "Renault",
                Model = "Megane",
                Owner = new Person()
                {
                    FirstName = "Mate",
                    LastName = "Matic",
                    DateOfBirth = new DateTime(2000, 3, 15),
                    DrivingLicenseCategories = new List<DrivingLicenseCategory>()
                    {
                        DrivingLicenseCategory.A,
                        DrivingLicenseCategory.A1,
                        DrivingLicenseCategory.B
                    }
                }
            };
            
            Console.WriteLine($"Manufacturer: {car.Manufacturer}\n"
                            + $"Model: {car.Model}\n"
                            + $"Owner: {car.Owner.FirstName} {car.Owner.LastName}\n"
                            + $"Is registered: {car.CheckIsRegistered()}\n"
                            + $"Is insured: {car.CheckIsInsured()}");
            
            Console.WriteLine("Registering car...");
            Console.WriteLine($"Did car registration succeed: {car.Register()}");
            
            Console.WriteLine("Insuring car...");
            Console.WriteLine($"Did car insurance succeed: {car.Insure(15)}");
        }
    }
}
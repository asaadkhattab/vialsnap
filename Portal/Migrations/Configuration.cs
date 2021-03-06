//Configuration.cs
namespace Portal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Portal.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PortalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PortalContext context)
        {
            context.Pharmacies.AddOrUpdate(
                p => p.PharmacyId,
                new Pharmacy { PharmacyId = 1, Name = "Mountain Apothecare", City = "Paintsville", State = "KY" },
                new Pharmacy { PharmacyId = 2, Name = "CVS", City = "Los Angeles", State = "CA" },
                new Pharmacy { PharmacyId = 3, Name = "RiteAid", City = "Dayton", State = "OH" },
                new Pharmacy { PharmacyId = 4, Name = "Walgreen", City = "Seattle", State = "VA" },
                new Pharmacy { PharmacyId = 5, Name = "Family Pharmacy", City = "Charleston", State = "SC" },
                new Pharmacy { PharmacyId = 6, Name = "MedPlus", City = "Palm Spring", State = "WY" },
                new Pharmacy { PharmacyId = 7, Name = "SuperPharm", City = "Dayton", State = "PA" },
                new Pharmacy { PharmacyId = 8, Name = "WatsonPharm", City = "San Fransisco", State = "MD" },
                new Pharmacy { PharmacyId = 9, Name = "Drug Imporium", City = "Chicago", State = "IN" },
                new Pharmacy { PharmacyId = 10, Name = "Good Neighbor Pharmacy", City = "Honolulu", State = "HI" }
                );

            context.Medications.AddOrUpdate(
                m => m.MedicationId,
                new Medication { MedicationId = 1, Name = "Tylenol" },
                new Medication { MedicationId = 2, Name = "Adderall" },
                new Medication { MedicationId = 3, Name = "Advil" },
                new Medication { MedicationId = 4, Name = "Nexium" },
                new Medication { MedicationId = 5, Name = "Flonase" }
                );

            context.SaveChanges();

            context.Patients.AddOrUpdate(
                  pat => pat.PatientId,
                  new Patient { PatientId = 1, Prefix = "Mr", FirstName = "Asaad", MiddleName = "Y", LastName = "Khattab", Suffix = "III", AccountBalance = 99, MedicationId = 4 },
                  new Patient { PatientId = 2, Prefix = "Mrs", FirstName = "Emily", MiddleName = "N", LastName = "Green", Suffix = "PhD", AccountBalance = 9, MedicationId = 1 },
                  new Patient { PatientId = 3, Prefix = "Mr", FirstName = "Sam", MiddleName = "Y", LastName = "Farthing", Suffix = "Sr.", AccountBalance = 134, MedicationId = 3 },
                  new Patient { PatientId = 4, Prefix = "Mr", FirstName = "Avram", MiddleName = "C", LastName = "Hale", Suffix = "I", AccountBalance = 23, MedicationId = 1 },
                  new Patient { PatientId = 5, Prefix = "Mrs", FirstName = "Linda", MiddleName = "G", LastName = "Croft", Suffix = "IV", AccountBalance = 50, MedicationId = 2 }
                  );
 





        }
    }
}

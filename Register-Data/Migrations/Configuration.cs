namespace Register_Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Register_Data.MainDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Register_Data.MainDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            Family f1 = new Family { LastName = "Svensson" };
            Family f2 = new Family { LastName = "Andersson" };
            Family f3 = new Family { LastName = "Johansson" };
            Family f4 = new Family { LastName = "Olsson" };
            context.Familys.AddOrUpdate(f => f.LastName, f1, f2, f3, f4);
            context.SaveChanges();

            Person p1 = new Person()
            {
                Name = "Lennart",
                Age = 48,
                FamilyId = f1.FamilyId,
                Family = f1

            };

            Person p2 = new Person
            {
                Name = "Lena",
                Age = 42,
                FamilyId = f1.FamilyId,
                Family = f1

            };

            Person p3 = new Person
            {
                Name = "Leo",
                Age = 9,
                FamilyId = f1.FamilyId,
                Family = f1
            };

            Person p4 = new Person
            {
                Name = "Lova",
                Age = 4,
                FamilyId = f1.FamilyId,
                Family = f1
            };

            context.Persons.AddOrUpdate(p => new { p.Name, p.Age, p.FamilyId }, p1, p2, p3, p4);
            context.SaveChanges();

            Car c1 = new Car
            {
                Name = "Volvo V70",
                Year = 2013,
                RegistratioNnumber = "ABC 123",
                FamilyId = f1.FamilyId,
                Family = f1,
            };
            Car c2 = new Car
            {
                Name = "Ford Fiesta",
                Year = 2005,
                RegistratioNnumber = "FDR 265",
                FamilyId = f1.FamilyId,
                Family = f1

            };
            context.Cars.AddOrUpdate(c => new { c.Name, c.Year, c.RegistratioNnumber, c.FamilyId }, c1, c2);
            context.SaveChanges();

            Estate e1 = new Estate
            {
                Address = "Stora vägen 4",
                County = "Väsby",
                FamilyId = f1.FamilyId,
                Family = f1,

            };
            Estate e2 = new Estate
            {
                Address = "Svampvägen 68",
                County = "Kista",
                FamilyId = f1.FamilyId,
                Family = f1,
            };


            context.Estates.AddOrUpdate(e => new { e.Address, e.County, e.FamilyId }, e1, e2);
            context.SaveChanges();

            BankAsset b1 = new BankAsset
            {

                Asset = 147000m,
                Person = p1,
                PersonId = p1.PersonId
            };
            BankAsset b2 = new BankAsset
            {
                Asset = 53000m,
                Person = p2,
                PersonId = p2.PersonId
            };
            BankAsset b3 = new BankAsset
            {
                Asset = 9000m,
                PersonId = p3.PersonId,
                Person = p3
            };
            BankAsset b4 = new BankAsset
            {
                Asset = 4000m,
                PersonId = p4.PersonId,
                Person = p4,
            };

            context.BankAssets.AddOrUpdate(b => new { b.Asset, b.PersonId }, b1, b2, b3, b4);
            context.SaveChanges();

            Person p5 = new Person
            {
                Name = "Sture",
                Age = 35,
                FamilyId = f2.FamilyId,
                Family = f2
            };
            Person p6 = new Person
            {
                Name = "Stina",
                Age = 34,
                FamilyId = f2.FamilyId,
                Family = f2
            };
            Person p7 = new Person
            {
                Name = "Sixten",
                Age = 7,
                FamilyId = f2.FamilyId,
                Family = f2
            };


            context.Persons.AddOrUpdate(p => new { p.Name, p.Age, p.FamilyId }, p5, p6, p7);
            context.SaveChanges();

            Car c3 = new Car
            {
                Name = "Skoda Superb",
                Year = 2011,
                RegistratioNnumber = "NKD 560",
                FamilyId = f2.FamilyId,
                Family = f2,
            };
            context.Cars.AddOrUpdate(c => new { c.Name, c.Year, c.RegistratioNnumber, c.FamilyId }, c3);
            context.SaveChanges();
            Estate e3 = new Estate
            {
                Address = "Drottninggatan 38",
                County = "Göteborg",
                FamilyId = f2.FamilyId,
                Family = f2,
            };
            context.Estates.AddOrUpdate(e => new { e.Address, e.County, e.FamilyId }, e3);
            context.SaveChanges();

            BankAsset b5 = new BankAsset
            {
                Asset = 99000m,
                PersonId = p5.PersonId,
                Person = p5,
            };

            BankAsset b6 = new BankAsset
            {
                Asset = 88000,
                PersonId = p6.PersonId,
                Person = p6
            };



            context.BankAssets.AddOrUpdate(b => new { b.Asset, b.PersonId }, b5, b6);
            context.SaveChanges();

            Person p8 = new Person
            {
                Name = "Anders",
                Age = 32,
                FamilyId = f3.FamilyId,
                Family = f3,

            };
            Person p9 = new Person
            {
                Name = "Anna",
                Age = 34,
                FamilyId = f3.FamilyId,
                Family = f3
            };

            Person p10 = new Person
            {
                Name = "Adreas",
                Age = 5,
                FamilyId = f3.FamilyId,
                Family = f3
            };
            Person p11 = new Person
            {
                Name = "Axel",
                Age = 2,
                FamilyId = f3.FamilyId,
                Family = f3,
            };

            context.Persons.AddOrUpdate(p => new { p.Name, p.Age, p.FamilyId }, p8, p9, p10, p11);
            context.SaveChanges();

            Car c4 = new Car
            {
                Name = "Audi A6",
                Year = 2015,
                RegistratioNnumber = "KLO 989",
                FamilyId = f3.FamilyId,
                Family = f3,
            };

            context.Cars.AddOrUpdate(c => new { c.Name, c.Year, c.RegistratioNnumber, c.FamilyId }, c4);
            context.SaveChanges();

            Estate e4 = new Estate
            {
                Address = "Kungsgatan 12A",
                County = "Stockholm",
                FamilyId = f3.FamilyId,
                Family = f3,

            };
            Estate e5 = new Estate
            {
                Address = "Älgstigen 26",
                County = "Tyresö",
                FamilyId = f3.FamilyId,
                Family = f3
            };
            Estate e6 = new Estate
            {
                Address = "Calle Romero 14",
                County = "Spanien",
                FamilyId = f3.FamilyId,
                Family = f3
            };

            context.Estates.AddOrUpdate(e => new { e.Address, e.County, e.FamilyId }, e4, e5, e6);
            context.SaveChanges();

            BankAsset b8 = new BankAsset
            {
                Asset = 850000,
                PersonId = p8.PersonId,
                Person = p8
            };

            BankAsset b9 = new BankAsset
            {
                Asset = 550000,
                PersonId = p9.PersonId,
                Person = p9
            };

            BankAsset b10 = new BankAsset
            {
                Asset = 50000,
                PersonId = p10.PersonId,
                Person = p10,
            };
            BankAsset b11 = new BankAsset
            {
                Asset = 10000,
                PersonId = p11.PersonId,
                Person = p11,
            };

            context.BankAssets.AddOrUpdate(b => new { b.Asset, b.PersonId }, b9, b10, b11);
            context.SaveChanges();

            Person p12 = new Person
            {
                Name = "Mats",
                Age = 50,
                FamilyId = f4.FamilyId,
                Family = f4,
            };
            Person p13 = new Person
            {
                Name = "Malin",
                Age = 48,
                FamilyId = f4.FamilyId,
                Family = f4
            };

            context.Persons.AddOrUpdate(p => new { p.Name, p.Age, p.FamilyId }, p12, p13);
            context.SaveChanges();

            Estate e7 = new Estate
            {
                Address = "Lilla Nygatan 78",
                County = "Växjö",
                FamilyId = f4.FamilyId,
                Family = f4
            };

            context.Estates.AddOrUpdate(e => new { e.Address, e.County, e.FamilyId }, e7);
            context.SaveChanges();
            BankAsset b12 = new BankAsset
            {
                Asset = 1500000,
                PersonId = p12.PersonId,
                Person = p12
            };

            BankAsset b13 = new BankAsset
            {
                Asset = 987000,
                PersonId = p13.PersonId,
                Person = p13,
            };
            context.BankAssets.AddOrUpdate(b => new { b.Asset, b.PersonId }, b12, b13);
            context.SaveChanges();

        }
    }
}

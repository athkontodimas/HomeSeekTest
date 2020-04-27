namespace HomeSeek.Database.Migrations
{
    using HomeSeek.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeSeek.Database.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HomeSeek.Database.MyDatabase context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //================= Seeding Amenities =================
            //Amenities template = new Amenities() { Title = "", Duration = 0, PhotoUrl = "", Price = 0, ProductionYear = new DateTime(1, 1, 1), Rating = 0D, TrailerUrl = "", Watched = false ,Country=Country.United_States_of_America};
            Amenities a1 = new Amenities() { Wifi = true, Heating = true, Tv = true, AirConditioning = true, WorkSpace = true, FirstAidKit = true, Elevator = true, FreeParking = true};
            Amenities a2 = new Amenities() { Wifi = false, Heating = true, Tv = true, AirConditioning = true, WorkSpace = true, FirstAidKit = true, Elevator = true, FreeParking = true};
            Amenities a3 = new Amenities() { Wifi = true, Heating = false, Tv = true, AirConditioning = true, WorkSpace = true, FirstAidKit = true, Elevator = true, FreeParking = true};

            //================= Seeding Places =================
            //Place template = new Place() { Title = "", Duration = 0, PhotoUrl = "", Price = 0, ProductionYear = new DateTime(1, 1, 1), Rating = 0D, TrailerUrl = "", Watched = false ,Country=Country.United_States_of_America};
            Place p1 = new Place() { ApartmentName = "Apartment in Psichiko", City = "Athens", Address = "Kolokotroni 12", Price = 200, Description = "O,ti kalytero"};
            Place p2 = new Place() { ApartmentName = "Nea Makri Exohiko", City = "Athens", Address = "Pournara 22", Price = 500, Description = "Foveri thea"};
            Place p3 = new Place() { ApartmentName = "Villa in Mykonos", City = "Mykonos", Address = "Nammos 12", Price = 1000, Description = "Fthines potares"};


            //================= Seeding Reservations =================
            //Reservation template = new Reservation() { Title = "", Duration = 0, PhotoUrl = "", Price = 0, ProductionYear = new DateTime(1, 1, 1), Rating = 0D, TrailerUrl = "", Watched = false ,Country=Country.United_States_of_America};
            Reservation r1 = new Reservation() { CheckInDate = new DateTime(2020, 6, 1), CheckOutDate = new DateTime(2020, 6, 5), DaysOfStaying = 4, TotalPrice = 800};
            Reservation r2 = new Reservation() { CheckInDate = new DateTime(2020, 7, 11), CheckOutDate = new DateTime(2020, 7, 22), DaysOfStaying = 11, TotalPrice = 5500};
            Reservation r3 = new Reservation() { CheckInDate = new DateTime(2020, 8, 21), CheckOutDate = new DateTime(2020, 8, 30), DaysOfStaying = 9, TotalPrice = 9000};
            Reservation test = new Reservation() { CheckInDate = new DateTime(2020, 1, 3), CheckOutDate = new DateTime(2020, 1, 10), DaysOfStaying = 8, TotalPrice = 500 };

            //================= Seeding Reviews =================
            //Review template = new Review() { Title = "", Duration = 0, PhotoUrl = "", Price = 0, ProductionYear = new DateTime(1, 1, 1), Rating = 0D, TrailerUrl = "", Watched = false ,Country=Country.United_States_of_America};
            Review rev1 = new Review() { Accuracy = 10, Checkin = 9, Cleanliness = 10, Location = 10, Value = 10, SubDate = new DateTime(2020, 6, 6), OverallRating = 9.1 ,Comment = "ola teleia"};
            Review rev2 = new Review() { Accuracy = 9, Checkin = 10, Cleanliness = 9, Location = 10, Value = 10, SubDate = new DateTime(2020, 7, 23), OverallRating = 9.1 ,Comment = "apisteuto service"};
            Review rev3 = new Review() { Accuracy = 8, Checkin = 9, Cleanliness = 8, Location = 10, Value = 10, SubDate = new DateTime(2020, 8, 31), OverallRating = 9.5 ,Comment = "Super"};

            //================= Seeding Transactions =================
            //Transaction template = new Transaction() { Title = "", Duration = 0, PhotoUrl = "", Price = 0, ProductionYear = new DateTime(1, 1, 1), Rating = 0D, TrailerUrl = "", Watched = false ,Country=Country.United_States_of_America};
            Transaction t1 = new Transaction() { PaymentDate = new DateTime(2020, 5, 4), TotalAmount = 500, TotalFees = 120};
            Transaction t2 = new Transaction() { PaymentDate = new DateTime(2020, 6, 15), TotalAmount = 200, TotalFees = 80};
            Transaction t3 = new Transaction() { PaymentDate = new DateTime(2020, 7, 25), TotalAmount = 800, TotalFees = 160};


            context.Reviews.AddOrUpdate(x => x.Accuracy, rev1, rev2, rev3);
            //context.Transactions.AddOrUpdate(x => x.TotalAmount, t1, t2, t3);

            context.Reservations.AddOrUpdate(x => x.DaysOfStaying, r1, r2, r3, test);
            context.Places.AddOrUpdate(x => x.Price, p1, p2, p3);
            //context.Amenities.AddOrUpdate(x => x.Kind, g1, g2, g3, g4, g5, g6, g7, g8);

            //context.SaveChanges();
        }
    }
}

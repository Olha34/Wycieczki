using Wycieczki.Models;

namespace Wycieczki.Data
{
    public class DBInitializer
    {
        public static void Initialize(ReservationContext context)
        {
            if (context.Persons.Any())
            {
                return;
            }
            var persons = new Person[]
            {
                new Person{Name="Karol", LastName="Nowak", Email="skarol@gmail.com", PhoneNumber="846243"},
                new Person{Name="Marika", LastName="Daniszewska", Email="marikad@gmail.com", PhoneNumber="546854759"},
                new Person{Name="Jakub", LastName="Rylko", Email="jrylko@gmail.com", PhoneNumber="789564123"},
                new Person{Name="Vlada", LastName="Romaniuk", Email="romanuk@gmail.com", PhoneNumber="754896324"},
            };
            foreach (Person p in persons)
            {
                context.Persons.Add(p);
            }
            context.SaveChanges();
            var trips = new Trip[]
            {
                new Trip { Country = "Hiszpania", City = "Barcelona", PricePerPerson = "1500", NumberOfDays = "3", ImgUrl = "https://barcelona-cityguide.com/wp-content/uploads/2023/01/27C53801-1F1C-43DC-8FCA-826D005CB26B-640x427.jpeg" },
                new Trip { Country = "Wlochy", City = "Wenecja", PricePerPerson = "1200", NumberOfDays = "3", ImgUrl = "https://i.wpimg.pl/O/640x427/d.wpimg.pl/1527542728-733009040/wenecja_g215%20shutterstock_219076456.jpg" },
                new Trip { Country = "Egipt", City = "Marsa Alam", PricePerPerson = "1200", NumberOfDays = "3", ImgUrl = "https://i.wpimg.pl/O/640x427/d.wpimg.pl/2017916735-1299865369/szarm-el-szejk.jpg" },
            };
            foreach (Trip t in trips)
            {
                context.Trips.Add(t);
            }
            context.SaveChanges();
            var reservations = new Reservation[]
            {
                new Reservation{PersonID=1, TourID=1},
                new Reservation{PersonID=2, TourID=2},
                new Reservation{PersonID=3, TourID=3},   
            };

            foreach (Reservation r in reservations) 
            {
                context.Reservations.Add(r);
            }
            context.SaveChanges();
        }
    }
}

    
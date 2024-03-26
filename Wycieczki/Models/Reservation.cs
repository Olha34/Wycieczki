namespace Wycieczki.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }  
        public int TourID { get; set; }
        public int PersonID { get; set; }   
        public Trip Trip { get; set; }  
        public Person Person { get; set; }

            
    }
}

namespace Wycieczki.Models
{
    public class Trip
    {
        public int Id { get; set; } 
        public string Country {  get; set; }    
        public string City { get; set; }    
        public string PricePerPerson { get; set; }  
        public string NumberOfDays { get; set; }    
        public string Description { get; set; } 
        public string ImgUrl { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        
    }
}

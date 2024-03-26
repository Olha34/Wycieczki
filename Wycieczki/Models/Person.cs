namespace Wycieczki.Models
{
    public class Person
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }  
        public string PhoneNumber { get; set; }   
        public ICollection<Reservation> Reservations { get; set; }  

    }
}

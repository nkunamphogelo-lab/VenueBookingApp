namespace VenueBookingApp.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public decimal PricePerDay { get; set; }
        public string ImageUrl { get; set; } = "https://via.placeholder.com/150";
    }
}
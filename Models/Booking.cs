namespace EventEase2.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Booking
    {
        public int BookingId { get; set; }

        [Required]
        public string AttendeeName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string AttendeeEmail { get; set; } = string.Empty;

        public int EventId { get; set; }

        // Navigation property
        public Event? Event { get; set; }
    }
}

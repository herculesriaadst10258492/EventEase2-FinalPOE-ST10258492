namespace EventEase2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Event
    {
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; } = string.Empty;

        [Required]
        public string EventDescription { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EventDate { get; set; }

        public int VenueId { get; set; }

        // Navigation properties
        public Venue? Venue { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}

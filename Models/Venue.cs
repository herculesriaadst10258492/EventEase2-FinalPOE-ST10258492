namespace EventEase2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Venue
    {
        public int VenueId { get; set; }

        [Required]
        public string VenueName { get; set; } = string.Empty;

        [Required]
        public string Location { get; set; } = string.Empty;

        [Required]
        public string AvailabilityStatus { get; set; } = string.Empty;

        public int Capacity { get; set; }

        public string? ImageUrl { get; set; }

        // Navigation properties
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}

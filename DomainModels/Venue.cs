﻿namespace DomainModels
{
    public class Venue : BaseEntity
    {
        public string VenueName { get; set; }
        public int Capacity { get; set; }
        public string City { get; set; }
    }
}

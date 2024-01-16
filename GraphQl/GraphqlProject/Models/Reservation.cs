﻿namespace GraphqlProject.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int PartySize { get; set; }
        public string SpecialRequest { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}

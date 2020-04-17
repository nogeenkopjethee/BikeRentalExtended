using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRental2.Web.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public Customer Customer { get; set; }
        public Bike Bikes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Store PickUpStore { get; set; }
        public Store DropOffStore { get; set; }
    }
}
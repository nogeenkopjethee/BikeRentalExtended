using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalPractise.Model
{
    public class Reservation
    {
        public Customer Customer { get; set; }
        public Bike Bikes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Store PickUpStore { get; set; }
        public Store DropOffStore { get; set; }
    }
}
